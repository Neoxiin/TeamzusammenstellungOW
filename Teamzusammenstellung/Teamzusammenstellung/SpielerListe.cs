using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamzusammenstellung
{   // Klasse für eine Liste von Spielerobjekten
    public class SpielerListe
    {
        //globale Objekt-Listen
        //Eingabe
        public Spieler[] slist = new Spieler[0];//Liste für alle Spieler
        //Verarbeitung
        private Spieler[] tanklist = new Spieler[0];
        private Spieler[] dpslist = new Spieler[0];
        private Spieler[] supportlist = new Spieler[0];
        //Ausgabe
        public Spieler[] t1list = new Spieler[0];//Liste für Team1
        public Spieler[] t2list = new Spieler[0];//Liste für Team2

        //fügt dem Array ein Objekt (Spieler) hinzu
        public void AddSpieler(Spieler s)
        {
            //Interne Variable
            int anz = slist.Length;

            Array.Resize(ref slist, anz + 1);//Platz für Spieler in der Liste machen

            slist[anz] = s;//Spieler hinzufügen
        }

        //SpielerListen löschen lassen
        public void DeleteAlleFelder()
        {
            DeleteFeld(ref slist);
            DeleteFeld(ref t1list);
            DeleteFeld(ref t2list);
            DeleteFeld(ref tanklist);
            DeleteFeld(ref dpslist);
            DeleteFeld(ref supportlist);
        }

        public void DeleteVerarbeitungsfelder()
        {
            DeleteFeld(ref tanklist);
            DeleteFeld(ref dpslist);
            DeleteFeld(ref supportlist);
        }

        public void DeleteFeld(ref Spieler[] spielers)
        {
            Array.Clear(spielers, 0, spielers.Length);
            Array.Resize(ref spielers, 0);
        }

        //Methode zum Verteilen der Spieler
        public void DistributeSpieler(out bool genugSpieler)
        {
            SortiereInRollenArrays();
            if (tanklist.Length >= 4 && dpslist.Length >= 4 && supportlist.Length >= 4)
            {
                int mittelwert1, mittelwert2;

                ZweiAuswählen(ref tanklist, ref t1list, out mittelwert1);//Spieler aus dem Array für tanks in Team 1 einordnen
                ZweiAuswählen(ref tanklist, ref t2list, out mittelwert2);//Spieler aus dem Array für tanks in Team 2 einordnen

                if (mittelwert1 >= mittelwert2)
                {
                    ZweiAuswählen(ref dpslist, ref t2list, out mittelwert2);//Spieler aus dem Array für dps in Team 2 einordnen
                    ZweiAuswählen(ref dpslist, ref t1list, out mittelwert1);//Spieler aus dem Array für dps in Team 1 einordnen
                }
                else
                {
                    ZweiAuswählen(ref dpslist, ref t1list, out mittelwert1);//Spieler aus dem Array für dps in Team 1 einordnen
                    ZweiAuswählen(ref dpslist, ref t2list, out mittelwert2);//Spieler aus dem Array für dps in Team 2 einordnen
                }
                if (mittelwert1 >= mittelwert2)
                {
                    ZweiAuswählen(ref supportlist, ref t2list, out mittelwert2);//Spieler aus dem Array für support in Team 2 einordnen
                    ZweiAuswählen(ref supportlist, ref t1list, out mittelwert1);//Spieler aus dem Array für support in Team 1 einordnen
                }
                else
                {
                    ZweiAuswählen(ref supportlist, ref t1list, out mittelwert1);//Spieler aus dem Array für support in Team 1 einordnen
                    ZweiAuswählen(ref supportlist, ref t2list, out mittelwert2);//Spieler aus dem Array für support in Team 2 einordnen
                }
                genugSpieler = true;
            }
            else genugSpieler = false;
        }

        //Methode zum sortieren der Spieler nach rollen auf die jeweiligen Arrays
        private void SortiereInRollenArrays()
        {
            //Array durchgehen
            for (int i = 0; i < slist.Length; i++)
            {
                //falls die rolle tank ist zur tankliste zuordnen
                if (slist[i].rolle == "tank")
                {
                    Array.Resize(ref tanklist, tanklist.Length + 1);
                    tanklist[tanklist.Length - 1] = slist[i];
                }
                //falls die rolle ist zur dpsliste zuordnen
                else if (slist[i].rolle == "dps")
                {
                    Array.Resize(ref dpslist, dpslist.Length + 1);
                    dpslist[dpslist.Length - 1] = slist[i];
                }
                //falls die rolle support ist zur supportliste zuordnen
                else if (slist[i].rolle == "support")
                {
                    Array.Resize(ref supportlist, supportlist.Length + 1);
                    supportlist[supportlist.Length - 1] = slist[i];
                }
            }
        }

        //Methode um 2 Spieler aus einem übergebenen Array auszuwählen und in ein anderes zu übergeben
        private void ZweiAuswählen(ref Spieler[] sEingabe, ref Spieler[] sAusgabe, out int mittelwertausgabe)
        {
            //interne Varibalen
            Spieler s1 = sEingabe[0];
            Spieler s2;
            int mittelwert = Mittelwert(sEingabe);
            int abwmittelwerts1, abwmittelwerts2;
            //------------------------------------------Erster Spieler-----------------------------------------------------------------
            //Wahl des ersten Spielers anhand der gespielten Spiele wenn jeder das gleiche -> erster Spieler im Array
            for (int i = 0; i < sEingabe.Length - 1; i++)
            {
                if (sEingabe[i].AnzGamesSpieler > sEingabe[i + 1].AnzGamesSpieler)
                {
                    s1 = sEingabe[i + 1];
                }
            }
            //Arraygröße des Ausgabe-Arrays um 1 erhöhen
            Array.Resize(ref sAusgabe, sAusgabe.Length + 1);
            //ausgewählter Spieler wird in Ausgabe-Array übertragen
            sAusgabe[sAusgabe.Length - 1] = s1;
            abwmittelwerts1 = mittelwert - s1.sr;//Abweichung des ersten Spieler vom Mittelwert ermitteln

            //Spieler aus Eingabe-Array löschen
            Array.Clear(sEingabe, Array.IndexOf(sEingabe, s1), 1);//Index vom Minimum suchen und Löschen

            for (int i = Array.IndexOf(sEingabe, null); i < sEingabe.Length - 1; i++)//von gelöschten index an Elemente nachrücken lassen
            {
                sEingabe[i] = sEingabe[i + 1];
            }
            Array.Resize(ref sEingabe, sEingabe.Length - 1);//Eingabe-Arraygröße um 1 verringern

            //------------------------------------------Zweiter Spieler-----------------------------------------------------------------
            s2 = sEingabe[0];//erst nach dem löschen des 1. Spielers den Spieler 2 deklarieren
            mittelwert = Mittelwert(sEingabe);//Mittelwert neu berechnen lassen

            for (int i = 0; i < sEingabe.Length - 1; i++)//Eingabe-Array durchgehen
            {
                abwmittelwerts2 = mittelwert - sEingabe[i].sr;//Abweichung des Spielers vom Mittelwert ermitteln
                //wenn "die Abweichung vom Mittelwerts des Spielers + die Abweichung des ersten Spielers in absoluten Zahlen" > "die Abweichung vom Mittelwerts des nächsten Spielers + die Abweichung des ersten Spielers in absoluten Zahlen"
                if (Math.Abs(abwmittelwerts1 + abwmittelwerts2) > Math.Abs(abwmittelwerts1 + (mittelwert - sEingabe[i + 1].sr)))
                {
                    s2 = sEingabe[i + 1];//Spieler mit passenden Wert wird vermerkt
                }
            }

            //Arraygröße des Ausgabe-Arrays um 1 erhöhen
            Array.Resize(ref sAusgabe, sAusgabe.Length + 1);
            //ausgewählter Spieler wird in Ausgabe-Array übertragen
            sAusgabe[sAusgabe.Length - 1] = s2;

            //Spieler aus Eingabe-Array löschen
            Array.Clear(sEingabe, Array.IndexOf(sEingabe, s2), 1);//Index vom Minimum suchen und Löschen

            for (int i = Array.IndexOf(sEingabe, null); i < sEingabe.Length - 1; i++)//von gelöschten index an Elemente nachrücken lassen
            {
                sEingabe[i] = sEingabe[i + 1];
            }
            Array.Resize(ref sEingabe, sEingabe.Length - 1);//Eingabe-Arraygröße um 1 verringern
            mittelwertausgabe = Mittelwert(sAusgabe);
        }

        //Mittelwert der sr aus übergebenen Array berechnen
        public int Mittelwert(Spieler[] spielers)
        {
            //interne Variablen
            int summe = 0;

            //Eingabe
            if (spielers.Length != 0)
            {
                for (int i = 0; i < spielers.Length; i++)
                {
                    summe += spielers[i].sr;
                }
                //Ausgabe Mittelwert
                return summe / spielers.Length;
            }
            //durch 0 teilen abfangen
            else return 0;
        }

        public void Spielzähler()
        {
            for (int i = 0; i < slist.Length; i++)
            {
                for (int k = 0; k < t1list.Length; k++)
                {
                    if (slist[i].Equals(t1list[k]))
                    {
                        slist[i].AnzGamesSpieler = slist[i].AnzGamesSpieler + 1;
                        break;
                    }
                }
                for (int k = 0; k < t2list.Length; k++)
                {
                    if (slist[i].Equals(t2list[k]))
                    {
                        slist[i].AnzGamesSpieler = slist[i].AnzGamesSpieler + 1;
                        break;
                    }
                }
            }
        }
    }
}