using System;
using System.Collections.Generic;

namespace MittelalterKi.Data.Models
{
    public class Mensch
    {
        #region Identität
        public int Id { get; set; }
        public string Anrede { get; set; } //ToDo: Enum/Model für Herr, Frau...
        public string Vorname { get; set; }
        public string Name { get; set; }
        public Titel Titel { get; set; } //ToDo: Sinnvoll, hier einen eigenen Datentypen zu verwenden?
        public enum Geschlecht //ToDo: Sinnvoll, hier keinen eigenen Datentypen zu verwenden?
        {
            Männlich,
            Weiblich,
            Neutral
        }
        
        public uint Alter { get; set; } //ToDo: Globale Methoden, die die Altergruppe zuordnen, mit Eingabe des Alters

        public int Ansehen { get; set; }

        public uint Glaubensstärke { get; set; }
        public enum Glaubensart
        {
            ateist,
            christlich
            //ToDo: Glaubensarten erweitern
        }

        /// <summary>
        /// Größe in Zentimetern
        /// </summary>
        public int Größe { get; set; }

        //ToDo: Stammbaum?
        #endregion

        #region Werte
        public uint Lebenspunkte { get; set; }
        public uint Ausdauer { get; set; }
        public uint Hunger { get; set; }
        public uint Durst { get; set; }

        #endregion


        #region Bedürfnisse

        /// <summary>
        /// ToDo: Spanne definieren (z.B. 0 => 100)
        /// </summary>
        public uint Hygiene { get; set; }

        public int Schlaf { get; set; }
        public DateTime LetzterSchlaf { get; set; } //Zur Ermittlung des Malus/Vorteils


        /// <summary>
        /// Sicherheitsgefühl von 0 - 100
        /// </summary>
        public uint Sicherheit { get; set; }
        
        /// <summary>
        /// ToDo: Spanne definieren (z.B. -100 => +100)
        /// </summary>
        public int Zufriedenheit { get; set; }


        #endregion

        
        /// <summary>
        /// 
        /// </summary>
        public List<Bonus> Bonis { get; set; } //ToDo: Naming und optionale Trennung der Pro und Cons Vorteile
               
        //ToDo: Spezialiserungen hier oder besser später in den Modellen?
        //Kein Zwang einer primären Spezialiserung / Nullable?
        public List<Spezialiserung> Spezialiserungen { get; set; }
        

        //ToDo: Referenc zur Heimat?
    }

    public class Titel
    {
        //ToDo: Titel eintragen
    }

    public class Spezialiserung
    {
        //ToDo: Spezialiserungen eintragen
    }


}
