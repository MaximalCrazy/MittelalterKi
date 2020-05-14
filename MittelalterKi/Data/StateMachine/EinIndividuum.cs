using Microsoft.Extensions.Logging;
using MittelalterKi.Data.StateMachine.Fähigkeiten;
using MittelalterKi.Data.StateMachine.HandlungenMuster;

namespace MittelalterKi.Data.StateMachine
{
    public class EinIndividuum: Individuum
    {
        private static readonly System.Random rnd = new System.Random();

        protected readonly IFähigkeitenQuelle fähigkeitenQuelle;

        public EinIndividuum(ILogger<EinIndividuum> logger, IFähigkeitenQuelle fähigkeitenQuelle = null) : base(logger)
        {
            Name = $"{nameof(EinIndividuum)} Nr.: {Id}";
            this.fähigkeitenQuelle = fähigkeitenQuelle;
            bedürfnise.Add(new Bedürfnis("Narung", rnd.Next(10, 100)));
            bedürfnise.Add(new Bedürfnis("Wasser", rnd.Next(20, 80)));
            bedürfnise.Add(new Bedürfnis("NarungsLager", rnd.Next(0, 500)) { Min = 50, Max = 1000 });
            bedürfnise.Add(new Bedürfnis("Energi", rnd.Next(0, 100)) { Min = 0, Max = 100 });

            state = new Warte(this, logger);
        }
    }
}
