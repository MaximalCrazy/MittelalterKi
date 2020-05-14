﻿using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;

namespace MittelalterKi.Data.StateMachine.HandlungenMuster
{
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
            var narungsLager = individuum.Bedürfnise.FirstOrDefault(b => b.Name == "NarungsLager");
            if (narung != null)
            {
                if (narungsLager != null
                 && narungsLager.Wert > 0)
                {
                    var braucht = narung.Max - narung.Wert + 1;
                    var ausLager = System.Math.Min(braucht, narungsLager.Wert);
                    narungsLager.Wert -= ausLager;
                    narung.Wert += ausLager;
                }
                else
                {
                    //Beim Essen wird Narung mehr aufgefüllt als "normalerweise" gesenkt
                    narung.Wert = narung.Wert + zeitEinheiten * 1.5M;
                }

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
}
