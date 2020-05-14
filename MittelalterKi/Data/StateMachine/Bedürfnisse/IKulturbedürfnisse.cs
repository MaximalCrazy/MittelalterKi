namespace MittelalterKi.Data.StateMachine.Bedürfnis
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
