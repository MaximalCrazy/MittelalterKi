namespace MittelalterKi.Data.StateMachine.Bedürfnis
{
    public interface IExistenzbedürfnisse
    {
        Bedürfnis Nahrung { get; set; }
        Bedürfnis Wasser { get; set; }
        Bedürfnis Hygiene { get; set; }
        Bedürfnis Wohnraum { get; set; }        
    }
}
