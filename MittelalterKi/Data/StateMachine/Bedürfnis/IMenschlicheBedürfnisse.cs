using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MittelalterKi.Data.StateMachine.Bedürfnis
{

    /*    
        Existenzbedürfnisse sind auch in der Not erforderlich: 
        - ausreichend Nahrung und Wasser
        - Kleidung
        - Wohnraum
        - Arbeit
        - Medizinische Versorgung

        Grundbedürfnisse umfassen: 
        - sauberes Wasser und Nahrung
        - Schlaf
        - Unterkunft
        - Kleidung
        - Krankenversorgung (Mittelalter => Kinder)
        - "Geborgenheit und Partnerschaft"

        Kulturbedürfnisse beschreiben den Wunsch nach Kultur:
        - Ästhetik
        - kreativem Ausdruck 
        - Bildung
        
        Luxusbedürfnisse umfassen die Bedürfnisse nach luxuriösen Gütern und Dienstleistungen 
        - Schmuck
        - Sicherheit
        
        Leitsatz: "Eine Grenze zur Begierde ist nicht vorhanden."
    */

    interface IMenschlicheBedürfnisse
    {
        Existenzbedürfnisse Existenzbedürfnisse { get; set; }
        Grundbedürfnisse Grundbedürfnisse { get; set; }
        Kulturbedürfnisse Kulturbedürfnisse { get; set; }
        Luxusbedürfnisse ILuxusbedürfnisse { get; set; }
    }
}
