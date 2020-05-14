namespace MittelalterKi.Data.StateMachine.Bedürfnisse
{
    public interface IKulturbedürfnisse
    {
        //ToDo: Andere Typen sinnvoll?
        Bedürfnis Kultur { get; set; }
        Bedürfnis Ästhetik { get; set; }
        Bedürfnis Kreativität { get; set; }
        Bedürfnis Bildung { get; set; }
    }
}
