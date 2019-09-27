using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Teamzusammenstellung
{   
    // Klasse für einen Spieler mit attributen
    public class Spieler
    {
        //Attribute
        public int sr;
        public string rolle, name;
        public int AnzGamesSpieler;

        public Spieler(string rolle, int sr, string name)
        {
            this.rolle = rolle;
            this.sr = sr;
            this.name = name;
            AnzGamesSpieler = 0;
        }

        /*
         Problem:
         1. nur die ersten 12 Spieler werden zugeordnet (bzw. nach sortieren der Liste von groß zu klein wird der SPieler mit der niedrigsten sr nicht wirklich beachtet), 
            falls es mehr Spieler gibt und es mehrere Spiele geben soll, sollen Spieler die das letzte mal nicht dran waren beforzugt ausgewählt werden
         */
    }
}

