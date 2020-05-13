namespace MittelalterKi.Data.StateMachine.Bedürfnis
{
    interface IGrundbedürfnisse
    {
        Bedürfnis Nahrung { get; set; }
        Bedürfnis Trinken { get; set; }
        Bedürfnis Moral { get; set; }
        Bedürfnis Hygiene { get; set; }
    }
}
