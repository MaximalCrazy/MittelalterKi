using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MittelalterKi.Data.StateMachine
{
    public class Spieler
    {
        public int Id { get; }
        public string Name { get; set; }

        public decimal Nahrung { get; set; }
        public decimal Trinken { get; set; }
        public decimal Energie { get; set; }
        public decimal Alter { get; set; }




        //Berufe (Primär / Sekundär)
        //

        //ToDo: Logger implementieren


    }
}
