using Microsoft.Extensions.Logging;
using MittelalterKi.Data.StateMachine.Bedürfnise;
using MittelalterKi.Data.StateMachine.Fähigkeiten;
using MittelalterKi.Data.StateMachine.Handlungen;

namespace MittelalterKi.Data.StateMachine
{
    public class BauerPoC : Individuum
    {
        private static readonly System.Random rnd = new System.Random();

        protected readonly IFähigkeitenQuelle fähigkeitenQuelle;

        public BauerPoC(ILogger<BauerPoC> logger, IFähigkeitenQuelle fähigkeitenQuelle = null) : base(logger)
        {
            Name = $"{nameof(BauerPoC)} Nr.: {Id}";
            this.fähigkeitenQuelle = fähigkeitenQuelle;
            bedürfnise.Add(new Bedürfnis("Narung", rnd.Next(10,100)));
            bedürfnise.Add(new Bedürfnis("Wasser", rnd.Next(20, 80)));

            state = new Warte(this, logger);
        }
    }
}
