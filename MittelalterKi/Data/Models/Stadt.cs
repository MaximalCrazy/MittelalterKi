using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KITestMitBlazorApps.Data
{
    public class Stadt
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public int EntwicklungsStufe { get; set; }
        public int Händler { get; set; }
        public int Ruf { get; set; }

        public Stadtverteidigung Stadtverteidigung { get; set; }

        //Soldaten/Armee, Verteidigung, 
        public Diplomatie Diplomatie { get; set; }
    }
}
