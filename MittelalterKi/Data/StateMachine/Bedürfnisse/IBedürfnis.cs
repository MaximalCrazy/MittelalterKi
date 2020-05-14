namespace MittelalterKi.Data.StateMachine.Bedürfnisse
{
    public interface IBedürfnis
    {
        string Name { get; }
        decimal Wert { get; set; }

        decimal Min { get; set; }
        decimal Max { get; set; }
        decimal Qualität { get; set; }

    }
}
