using Microsoft.Extensions.Logging;

namespace MittelalterKi.Data.StateMachine.Handlungen
{
    public abstract class IndividuumsBasisSubHandlung : IndividuumsBasisHandlung
    {
        protected readonly IHandlung vorherigeAktion;

        public IndividuumsBasisSubHandlung(Individuum individuum, IHandlung vorherigeAktion, ILogger logger) : base(individuum, logger)
        {
            this.vorherigeAktion = vorherigeAktion;
        }
    }
}
