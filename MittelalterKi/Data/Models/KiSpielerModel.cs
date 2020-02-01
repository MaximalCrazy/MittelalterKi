using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KITestMitBlazorApps.Data
{
    public class KiSpielerModel
    {
        //Grundwerte
        public int Id { get; set; }
        public int Lebenspunkte { get; set; }
        public int Ausdauer { get; set; }
        public int Hunger { get; set; }
        public int Durst { get; set; }



        //Spezielle Bonis
        public Ausrüstung Ausrüstung { get; set; }
        public List<VorteilPerson> Vorteile { get; set; }
        public Verletzung Verletzung { get; set; }


        //Globale Einflüsse
        public Diplomatie Diplomatie { get; set; }


        //???
        public Familie Familie { get; set; }
    }
}
