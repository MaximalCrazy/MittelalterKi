using System;

namespace MittelalterKi.Data.StateMachine.Bedürfnisse
{
    public class MenschlicheBedürfnisse : IMenschlicheBedürfnisse
    {
        public Existenzbedürfnisse Existenzbedürfnisse { get; set; }
        public Grundbedürfnisse Grundbedürfnisse { get; set; }
        public Kulturbedürfnisse Kulturbedürfnisse { get; set; }
        public Luxusbedürfnisse ILuxusbedürfnisse { get; set; }
    }
}
