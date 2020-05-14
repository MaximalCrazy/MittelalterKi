using System.Threading.Tasks;

namespace MittelalterKi.Data.StateMachine.HandlungenMuster
{
    public interface IHandlung
    {
        Task<IHandlung> BerechneNächste(decimal zeitEinheiten = 1);
    }
}
