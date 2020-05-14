namespace MittelalterKi.Data.StateMachine.Bedürfnis
{
    public class Existenzbedürfnisse : IExistenzbedürfnisse
    {
        public Bedürfnis Nahrung { get; set; }
        public Bedürfnis Wasser { get; set; }
        public Bedürfnis Hygiene { get; set; }
        public Bedürfnis Wohnraum { get; set; }
    }
}
