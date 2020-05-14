namespace MittelalterKi.Data.StateMachine.Bedürfnis
{
    public interface IBedürfnis
    {
        string Name { get; }
        decimal Wert { get; set; }

        decimal Min { get; set; }
        decimal Max { get; set; }
        public decimal Qualität { get; set; }

    }
}
