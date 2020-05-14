namespace MittelalterKi.Data.StateMachine.Bedürfnisse
{
    public interface ILuxusbedürfnisse
    {
        Bedürfnis Schmuck { get; set; }
        //ToDo: ergänzen

        //ToDo: Überdenken, da es primär als Motivation für Wohlstand dienen soll.
        Bedürfnis Reichtum { get; set; }
    }
}
