using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MittelalterKi.Data.StateMachine.Bedürfnisse
{
    public interface IGrundwerte
    {
        decimal Lebenspunkte { get; }



        decimal Ausdauer { get; set; }
        decimal Geschwindigkeit { get; }
        
        decimal Tragkraft { get; }
        decimal Angriffskraft { get; }
        decimal Verteidigung { get; }

        //ToDo: FiFo Queue
        List<IAufgaben> Aufgaben { get; }


        // Schlaf



        //ToDo: Inventar > Datentyp unbekannt

        //Liste/Verzeichnis von Ausrüstungen hier hin?

        //Moral nach hier verschieben?

        //Gesinnung ?
    }

    public interface IAufgaben
    {
        int Priorität { get; set; }
        string Name { get; set; }
        int TätigkeitsId { get; }

    }
}
