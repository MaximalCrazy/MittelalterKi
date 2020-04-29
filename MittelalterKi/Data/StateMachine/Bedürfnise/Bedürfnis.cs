namespace MittelalterKi.Data.StateMachine.Bedürfnise
{
    public class Bedürfnis : IBedürfnis
    {
        public Bedürfnis(string name, decimal staertWert = 50) {
            Name = name;
            Wert = staertWert;
        }
        public decimal Wert { get; set; }
        public decimal Min { get; set; } = 10;
        public decimal Max { get; set; } = 100;

        public string Name { get; }
    }
}
