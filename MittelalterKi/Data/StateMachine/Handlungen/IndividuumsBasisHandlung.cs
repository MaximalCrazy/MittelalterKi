using Microsoft.Extensions.Logging;
using MittelalterKi.Data.StateMachine.Bedürfnise;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MittelalterKi.Data.StateMachine.Handlungen
{
    public abstract class IndividuumsBasisHandlung : IHandlung
    {
        protected readonly Individuum individuum;
        protected readonly ILogger logger;

        public IndividuumsBasisHandlung(Individuum individuum, ILogger logger)
        {
            this.individuum = individuum;
            this.logger = logger;
        }
        protected IEnumerable<IBedürfnis> ReduziereGrundBedürfnise(decimal zeitEinheiten = 1)
        {
            var grundBedürfnise = individuum.Bedürfnise
                .Where(b => b.Name == "Narung" || b.Name == "Wasser");
            foreach (var gb in grundBedürfnise)
            {
                gb.Wert -= zeitEinheiten;
            }

            var schlechte = grundBedürfnise.Where(b => b.Wert < b.Min);
            if (schlechte.Any())
            {
                logger.LogDebug($"[{individuum.Name}].ReduziereGrundBedürfnise({zeitEinheiten}) => schlechte=[{string.Join(",", schlechte.Select(b => $"'{b.Name}':{b.Wert}<{b.Min}"))}]");
            }
            return schlechte;
        }

        public abstract Task<IHandlung> BerechneNächste(decimal zeitEinheiten = 1);
    }

    public abstract class IndividuumsBasisSubHandlung : IndividuumsBasisHandlung
    {
        protected readonly IHandlung vorherigeAktion;

        public IndividuumsBasisSubHandlung(Individuum individuum, IHandlung vorherigeAktion, ILogger logger) : base(individuum, logger)
        {
            this.vorherigeAktion = vorherigeAktion;
        }
    }
    public class Warte : IndividuumsBasisHandlung
    {
        public Warte(Individuum individuum, ILogger logger) : base(individuum, logger) { }

#pragma warning disable CS1998 // Bei der asynchronen Methode fehlen "await"-Operatoren. Die Methode wird synchron ausgeführt. Ist einen enfache implementierung ohne asyncrone Vorgänge
        public override async Task<IHandlung> BerechneNächste(decimal zeitEinheiten = 1)
#pragma warning restore CS1998 // Bei der asynchronen Methode fehlen "await"-Operatoren. Die Methode wird synchron ausgeführt.
        {
            var schlecht = ReduziereGrundBedürfnise(zeitEinheiten);

            if (schlecht.Any(b => b.Name == "Wasser"))
            {
                return new Trinken(individuum, this, logger);
            }
            if (schlecht.Any(b => b.Name == "Narung"))
            {
                return new Essen(individuum, this, logger);
            }
            return this;
        }
    }

    internal class Essen : IndividuumsBasisSubHandlung
    {

        public Essen(Individuum individuum, IHandlung vorherigeAktion, ILogger logger) : base(individuum, vorherigeAktion, logger)
        {
            logger.LogDebug($"[{individuum.Name}].Beginne Essen");
        }

#pragma warning disable CS1998 // Bei der asynchronen Methode fehlen "await"-Operatoren. Die Methode wird synchron ausgeführt. Ist einen enfache implementierung ohne asyncrone Vorgänge
        public override async Task<IHandlung> BerechneNächste(decimal zeitEinheiten = 1)
#pragma warning restore CS1998 // Bei der asynchronen Methode fehlen "await"-Operatoren. Die Methode wird synchron ausgeführt.
        {
            var narung = individuum.Bedürfnise.FirstOrDefault(b => b.Name == "Narung");
            if (narung != null)
            {
                //Beim Essen wird Narung mehr aufgefüllt als "normalerweise" gesenkt
                narung.Wert += zeitEinheiten * 2;
            }

            var schlecht = ReduziereGrundBedürfnise(zeitEinheiten);

            if (schlecht.Any(b => b.Name == "Wasser"))
            {
                return new Trinken(individuum, this, logger);
            }
            if (schlecht.Any(b => b.Name == "Narung"))
            {
                return this;
            }
            if (narung != null
                && narung.Wert >= narung.Max)
            {
                logger.LogDebug($"[{individuum.Name}].Beende Essen");
                return vorherigeAktion;
            }

            return this;
        }
    }

    internal class Trinken : IndividuumsBasisSubHandlung
    {
        public Trinken(Individuum individuum, IHandlung vorherigeAktion, ILogger logger) : base(individuum, vorherigeAktion, logger)
        {
            logger.LogDebug($"[{individuum.Name}].Beginne Trinken");
        }

#pragma warning disable CS1998 // Bei der asynchronen Methode fehlen "await"-Operatoren. Die Methode wird synchron ausgeführt. Ist einen enfache implementierung ohne asyncrone Vorgänge
        public override async Task<IHandlung> BerechneNächste(decimal zeitEinheiten = 1)
#pragma warning restore CS1998 // Bei der asynchronen Methode fehlen "await"-Operatoren. Die Methode wird synchron ausgeführt.
        {
            var wasser = individuum.Bedürfnise.FirstOrDefault(b => b.Name == "Wasser");
            if (wasser != null)
            {
                //Beim Trinken wird Wasser mehr aufgefüllt als "normalerweise" gesenkt
                wasser.Wert += zeitEinheiten * 6;
            }

            var schlecht = ReduziereGrundBedürfnise(zeitEinheiten);

            if (schlecht.Any(b => b.Name == "Wasser"))
            {
                return this;
            }
            if (schlecht.Any(b => b.Name == "Narung"))
            {
                return new Essen(individuum, this, logger);
            }
            if (wasser != null
                && wasser.Wert > (wasser.Max / 100) * 80)
            {
                logger.LogDebug($"[{individuum.Name}].Beende Trinken");
                return vorherigeAktion;
            }

            return this;
        }
    }
}
