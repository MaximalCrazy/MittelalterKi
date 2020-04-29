using System.Threading.Tasks;

namespace MittelalterKi.Data.StateMachine.Bedürfnise
{
    public interface IBedürfnis
    {
        decimal Wert { get; set; }

        decimal Min { get; set; }
        decimal Max { get; set; }

        string Name { get; }
    }
}
