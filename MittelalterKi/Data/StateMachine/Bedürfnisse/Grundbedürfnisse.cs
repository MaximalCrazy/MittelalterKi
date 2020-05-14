namespace MittelalterKi.Data.StateMachine.Bedürfnis
{
    public class Grundbedürfnisse : IGrundbedürfnisse
    {
        public Bedürfnis Nahrungsversorgung { get; set; }
        public Bedürfnis Wasserversorgung { get; set; }
        public Bedürfnis Moral { get; set; }
        public Bedürfnis Hygiene { get; set; }
        public Bedürfnis Schlaf { get; set; }
    }
}
