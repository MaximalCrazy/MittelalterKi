namespace MittelalterKi.Data.StateMachine.Bedürfnisse
{
    public interface IExistenzbedürfnisse
    {
        Bedürfnis Nahrung { get; set; }
        Bedürfnis Wasser { get; set; }
        Bedürfnis Hygiene { get; set; }
        Bedürfnis Wohnraum { get; set; }        
    }
}
