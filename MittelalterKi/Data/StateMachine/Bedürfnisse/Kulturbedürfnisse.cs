using System;

namespace MittelalterKi.Data.StateMachine.Bedürfnis
{
    public class Kulturbedürfnisse : IKulturbedürfnisse
    {
        public Bedürfnis Kultur { get; set; }
        public Bedürfnis Ästhetik { get; set; }
        public Bedürfnis Kreativität { get; set; }
        public Bedürfnis Bildung { get; set; }
    }
}
