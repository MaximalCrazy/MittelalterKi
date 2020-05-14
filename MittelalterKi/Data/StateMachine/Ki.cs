using MittelalterKi.Data.StateMachine.Bedürfnisse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MittelalterKi.Data.StateMachine
{
    public class Ki //: IGrundwerte
    {
        public int Id { get; }

        public string Name { get; set; }

        public decimal Nahrung { get; set; }
        public decimal Nahrungslager { get; set; }
        public decimal Trinken { get; set; }
        public decimal Energie { get; set; }

        public decimal Alter { get; set; }


        //Temporär
        public int DistanzWasser { get; } = 15;

        //Übergang mit String als Datentyp
        public string Handlung { get; }


        //Zustände als Liste pflegen






    }
}
