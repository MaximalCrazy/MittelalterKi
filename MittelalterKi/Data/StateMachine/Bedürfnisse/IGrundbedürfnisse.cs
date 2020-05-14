namespace MittelalterKi.Data.StateMachine.Bedürfnisse
{
    public interface IGrundbedürfnisse
    {
        Bedürfnis Nahrungsversorgung { get; set; }
        Bedürfnis Wasserversorgung { get; set; }
        Bedürfnis Schlaf { get; set; }


        //Bessen Ort für folgende Werte?
        Bedürfnis Moral { get; set; }
        Bedürfnis Hygiene { get; set; }
    }
}
