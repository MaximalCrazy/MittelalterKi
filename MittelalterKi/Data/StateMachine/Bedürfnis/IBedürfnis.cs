using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MittelalterKi.Data.StateMachine.Bedürfnis
{
    interface IBedürfnis
    {
        string Name { get; }
        decimal Wert { get; set; }

        decimal Min { get; set; }
        decimal Max { get; set; }

    }
}
