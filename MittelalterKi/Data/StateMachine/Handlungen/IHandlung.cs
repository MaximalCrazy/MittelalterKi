using System.Threading.Tasks;

namespace MittelalterKi.Data.StateMachine.Handlungen
{
    public interface IHandlung
    {
        Task<IHandlung> BerechneNächste(decimal zeitEinheiten = 1);
    }
}
