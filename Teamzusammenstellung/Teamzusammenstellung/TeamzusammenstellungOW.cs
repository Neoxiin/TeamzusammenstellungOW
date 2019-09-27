using System;
using System.Windows.Forms;
using Microsoft.VisualBasic; //Für Einbindung Dialogfeld (Eingabe)
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Teamzusammenstellung
{
    public partial class Frm_Teamzusammstellung : Form
    {
        //private Variablen
        int i = 0;
        //test Zufallsgenerator
        Random r = new Random();
        //Spielerliste instaziieren
        SpielerListe sL = new SpielerListe();

        public Frm_Teamzusammstellung()
        {
            InitializeComponent();
        }

        //Klick-Methode um neue Spieler hinzuzufügen 
        private void Btn_Hinzufuegen_Click(object sender, EventArgs e)
        {
            //interne Variablen
            int sr;
            string rolle = "", name;

            //Eingabe rolle
            if (radioBtn_Tank.Checked) rolle = "tank";
            else if (radioBtn_Dps.Checked) rolle = "dps";
            else if (radioBtn_Support.Checked) rolle = "support";

            try
            {
                //Eingabe name & sr
                name = Interaction.InputBox("Bitte Spielernamen eingeben.", "Namensseingabe", "[Name]");
                sr = Convert.ToInt32(Interaction.InputBox("Bitte Skillrating eingeben.", "Skillratingseingabe", "[Skillrating]"));

                //Ausgabe
                list_Alle.Items.Add(rolle + " " + sr + " " + name);

                //fügt der liste einen neunen Spieler mit eingegebenen Attributen hinzu
                sL.AddSpieler(new Spieler(rolle, sr, name));
            }
            catch (FormatException) //Formatfehler
            {
                MessageBox.Show("Fehler: falsches Eingabeformat");
            }
            catch (Exception) //allgemeiner Fehler
            {
                MessageBox.Show("Fehler: allgemein");
            }
        }

        //zum Testen
        private void Btn_Zufallsspiel_Click(object sender, EventArgs e)
        {
            //lokale Variablen
            int sr;
            string rolle, name;

            //Listen löschen
            sL.DeleteAlleFelder();
            list_Alle.Items.Clear();
            list_Team1.Items.Clear();
            list_Team2.Items.Clear();
            //4 zufällige tanks
            for (int i = 1; i < 5; i++) 
            {
                rolle = "tank";
                sr = r.Next(1, 5001);
                name = "tank" + Convert.ToString(i);

                list_Alle.Items.Add(rolle + " " + sr + " " + name);

                sL.AddSpieler(new Spieler(rolle, sr, name));
            }
            //4 zufällige dps
            for (int i = 1; i < 5; i++) 
            {
                rolle = "dps";
                sr = r.Next(1, 5001);
                name = "dps" + Convert.ToString(i);

                list_Alle.Items.Add(rolle + " " + sr + " " + name);

                sL.AddSpieler(new Spieler(rolle, sr, name));
            }
            //4 zufällige support
            for (int i = 1; i < 5; i++) 
            {
                rolle = "support";
                sr = r.Next(1, 5001);
                name = "support" + Convert.ToString(i);

                list_Alle.Items.Add(rolle + " " + sr + " " + name);

                sL.AddSpieler(new Spieler(rolle, sr, name));
            }
        }

        //soll Liste aller Spieler auf die Teams verteilen
        private void Btn_Teamerstellung_Click(object sender, EventArgs e)
        {
            //Variablen
            bool genugSpieler = true;
            //Lösche alle Arrays außer Array für alle Spieler
            sL.DeleteVerarbeitungsfelder();
            sL.DeleteFeld(ref sL.t1list);
            sL.DeleteFeld(ref sL.t2list);
            list_Team1.Items.Clear();
            list_Team2.Items.Clear();

            //Spieler verteilen
            sL.DistributeSpieler(out genugSpieler);
            if (genugSpieler)
            {
                //Button Spielstart freischalten
                btn_Spielstart.Enabled = true;
                //ListBoxen für Teams leeren
                list_Team1.Items.Clear();
                list_Team2.Items.Clear();

                //Teamarrays auf die jeweiligen Listbox verteilen
                for (int i = 0; i < sL.t1list.Length; i++)
                {
                    list_Team1.Items.Add(sL.t1list[i].rolle + " " + sL.t1list[i].sr + " " + sL.t1list[i].name);
                }
                for (int i = 0; i < sL.t1list.Length; i++)
                {
                    list_Team2.Items.Add(sL.t2list[i].rolle + " " + sL.t2list[i].sr + " " + sL.t2list[i].name);
                }
                lbl_DurchschnittT1.Text = "Durchschnitt: " + Convert.ToString(sL.Mittelwert(sL.t1list));
                lbl_DurchschnittT2.Text = "Durchschnitt: " + Convert.ToString(sL.Mittelwert(sL.t2list));
            }
            else MessageBox.Show("Nicht genug Spieler oder nicht genug Spieler mit gleichen Rollen!");
        }

        private void list_Alle_KeyDown(object sender, KeyEventArgs e)
        {
            var key = e.KeyValue;
            //wenn Backspace oder Delete gedrückt wird wird der ausgewählte Spieler gelöscht
            if (key == 8 | key == 46)
            {
                //Spieler aus Array Löschen
                Array.Clear(sL.slist, list_Alle.SelectedIndex, 1);

                for (int i = list_Alle.SelectedIndex; i < sL.slist.Length - 1; i++)
                {
                    sL.slist[i] = sL.slist[i + 1];
                }
                Array.Resize(ref sL.slist, sL.slist.Length - 1);

                //Spieler aus ListBox löschen
                list_Alle.Items.Remove(list_Alle.SelectedItem);
            }
        }

        private void Btn_Spielstart_Click(object sender, EventArgs e)
        {
            i++;
            sL.Spielzähler();
            lbl_SpielAnzahl.Text = "Anzahl der Spiele: " + i;
        }
    }
}
