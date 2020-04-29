using Microsoft.Extensions.Logging;
using MittelalterKi.Data.StateMachine.Bedürfnise;
using MittelalterKi.Data.StateMachine.Handlungen;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MittelalterKi.Data.StateMachine
{
    public abstract class Individuum
    {
        private static int sID = 1;
        public int Id { get; } = sID++;

        public string Name { get; set; }

        public List<string> Zustände { get; } = new List<string>();

        public IReadOnlyList<IBedürfnis> Bedürfnise => (IReadOnlyList<IBedürfnis>)bedürfnise;
        protected IList<IBedürfnis> bedürfnise = new List<IBedürfnis>();

        protected IHandlung state;
        protected readonly ILogger<Individuum> logger;


        public Individuum(ILogger<Individuum> logger)
        {
            this.logger = logger;
        }

        public async Task BerechneNächstenZustand(decimal zeitEinheiten = 1)
        {
            logger.LogTrace($"BerechneNächstenZustand({zeitEinheiten})");
            state = await state.BerechneNächste(zeitEinheiten);
        }
    }
}
