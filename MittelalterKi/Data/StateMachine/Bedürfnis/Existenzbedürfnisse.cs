using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MittelalterKi.Data.StateMachine.Bedürfnis
{
    public class Existenzbedürfnisse : IExistenzbedürfnisse
    {
        public Bedürfnis Nahrung { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Bedürfnis Trinken { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Bedürfnis Moral { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Bedürfnis Hygiene { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
