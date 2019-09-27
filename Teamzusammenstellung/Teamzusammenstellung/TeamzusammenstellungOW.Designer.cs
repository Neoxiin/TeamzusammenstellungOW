namespace Teamzusammenstellung
{
    partial class Frm_Teamzusammstellung
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        public void InitializeComponent()
        {
            this.btn_Hinzufuegen = new System.Windows.Forms.Button();
            this.list_Alle = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.list_Team1 = new System.Windows.Forms.ListBox();
            this.list_Team2 = new System.Windows.Forms.ListBox();
            this.radioBtn_Tank = new System.Windows.Forms.RadioButton();
            this.radioBtn_Dps = new System.Windows.Forms.RadioButton();
            this.radioBtn_Support = new System.Windows.Forms.RadioButton();
            this.btn_Teamerstellung = new System.Windows.Forms.Button();
            this.btn_Zufallsspiel = new System.Windows.Forms.Button();
            this.lbl_DurchschnittT1 = new System.Windows.Forms.Label();
            this.lbl_DurchschnittT2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Spielstart = new System.Windows.Forms.Button();
            this.lbl_SpielAnzahl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Hinzufuegen
            // 
            this.btn_Hinzufuegen.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hinzufuegen.Location = new System.Drawing.Point(107, 12);
            this.btn_Hinzufuegen.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Hinzufuegen.Name = "btn_Hinzufuegen";
            this.btn_Hinzufuegen.Size = new System.Drawing.Size(132, 28);
            this.btn_Hinzufuegen.TabIndex = 6;
            this.btn_Hinzufuegen.Text = "Hinzufügen";
            this.btn_Hinzufuegen.UseVisualStyleBackColor = true;
            this.btn_Hinzufuegen.Click += new System.EventHandler(this.Btn_Hinzufuegen_Click);
            // 
            // list_Alle
            // 
            this.list_Alle.FormattingEnabled = true;
            this.list_Alle.ItemHeight = 17;
            this.list_Alle.Location = new System.Drawing.Point(10, 113);
            this.list_Alle.Margin = new System.Windows.Forms.Padding(2);
            this.list_Alle.Name = "list_Alle";
            this.list_Alle.Size = new System.Drawing.Size(184, 259);
            this.list_Alle.TabIndex = 7;
            this.list_Alle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.list_Alle_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Alle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Team 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Team 2:";
            // 
            // list_Team1
            // 
            this.list_Team1.FormattingEnabled = true;
            this.list_Team1.ItemHeight = 17;
            this.list_Team1.Location = new System.Drawing.Point(216, 113);
            this.list_Team1.Margin = new System.Windows.Forms.Padding(2);
            this.list_Team1.Name = "list_Team1";
            this.list_Team1.Size = new System.Drawing.Size(179, 106);
            this.list_Team1.TabIndex = 12;
            // 
            // list_Team2
            // 
            this.list_Team2.FormattingEnabled = true;
            this.list_Team2.ItemHeight = 17;
            this.list_Team2.Location = new System.Drawing.Point(401, 113);
            this.list_Team2.Margin = new System.Windows.Forms.Padding(2);
            this.list_Team2.Name = "list_Team2";
            this.list_Team2.Size = new System.Drawing.Size(175, 106);
            this.list_Team2.TabIndex = 13;
            // 
            // radioBtn_Tank
            // 
            this.radioBtn_Tank.AutoSize = true;
            this.radioBtn_Tank.Checked = true;
            this.radioBtn_Tank.Location = new System.Drawing.Point(13, 7);
            this.radioBtn_Tank.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtn_Tank.Name = "radioBtn_Tank";
            this.radioBtn_Tank.Size = new System.Drawing.Size(65, 21);
            this.radioBtn_Tank.TabIndex = 14;
            this.radioBtn_Tank.TabStop = true;
            this.radioBtn_Tank.Text = "tank";
            this.radioBtn_Tank.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Dps
            // 
            this.radioBtn_Dps.AutoSize = true;
            this.radioBtn_Dps.Location = new System.Drawing.Point(13, 32);
            this.radioBtn_Dps.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtn_Dps.Name = "radioBtn_Dps";
            this.radioBtn_Dps.Size = new System.Drawing.Size(56, 21);
            this.radioBtn_Dps.TabIndex = 15;
            this.radioBtn_Dps.Text = "dps";
            this.radioBtn_Dps.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Support
            // 
            this.radioBtn_Support.AutoSize = true;
            this.radioBtn_Support.Location = new System.Drawing.Point(13, 58);
            this.radioBtn_Support.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtn_Support.Name = "radioBtn_Support";
            this.radioBtn_Support.Size = new System.Drawing.Size(92, 21);
            this.radioBtn_Support.TabIndex = 16;
            this.radioBtn_Support.Text = "support";
            this.radioBtn_Support.UseVisualStyleBackColor = true;
            // 
            // btn_Teamerstellung
            // 
            this.btn_Teamerstellung.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Teamerstellung.Location = new System.Drawing.Point(107, 44);
            this.btn_Teamerstellung.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Teamerstellung.Name = "btn_Teamerstellung";
            this.btn_Teamerstellung.Size = new System.Drawing.Size(132, 28);
            this.btn_Teamerstellung.TabIndex = 17;
            this.btn_Teamerstellung.Text = "Teamerstellung";
            this.btn_Teamerstellung.UseVisualStyleBackColor = true;
            this.btn_Teamerstellung.Click += new System.EventHandler(this.Btn_Teamerstellung_Click);
            // 
            // btn_Zufallsspiel
            // 
            this.btn_Zufallsspiel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Zufallsspiel.Location = new System.Drawing.Point(289, 44);
            this.btn_Zufallsspiel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Zufallsspiel.Name = "btn_Zufallsspiel";
            this.btn_Zufallsspiel.Size = new System.Drawing.Size(100, 28);
            this.btn_Zufallsspiel.TabIndex = 18;
            this.btn_Zufallsspiel.Text = "Zufallsspiel";
            this.btn_Zufallsspiel.UseVisualStyleBackColor = true;
            this.btn_Zufallsspiel.Click += new System.EventHandler(this.Btn_Zufallsspiel_Click);
            // 
            // lbl_DurchschnittT1
            // 
            this.lbl_DurchschnittT1.AutoSize = true;
            this.lbl_DurchschnittT1.Location = new System.Drawing.Point(213, 221);
            this.lbl_DurchschnittT1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DurchschnittT1.Name = "lbl_DurchschnittT1";
            this.lbl_DurchschnittT1.Size = new System.Drawing.Size(125, 17);
            this.lbl_DurchschnittT1.TabIndex = 20;
            this.lbl_DurchschnittT1.Text = "Durchschnitt:";
            // 
            // lbl_DurchschnittT2
            // 
            this.lbl_DurchschnittT2.AutoSize = true;
            this.lbl_DurchschnittT2.Location = new System.Drawing.Point(398, 221);
            this.lbl_DurchschnittT2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DurchschnittT2.Name = "lbl_DurchschnittT2";
            this.lbl_DurchschnittT2.Size = new System.Drawing.Size(125, 17);
            this.lbl_DurchschnittT2.TabIndex = 21;
            this.lbl_DurchschnittT2.Text = "Durchschnitt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(377, 51);
            this.label4.TabIndex = 22;
            this.label4.Text = "Hinweis:\r\neinen Spieler auswählen und mit Backspace\r\noder Delete löschen\r\n";
            // 
            // btn_Spielstart
            // 
            this.btn_Spielstart.Enabled = false;
            this.btn_Spielstart.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Spielstart.Location = new System.Drawing.Point(216, 344);
            this.btn_Spielstart.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Spielstart.Name = "btn_Spielstart";
            this.btn_Spielstart.Size = new System.Drawing.Size(100, 28);
            this.btn_Spielstart.TabIndex = 23;
            this.btn_Spielstart.Text = "Spielstart";
            this.btn_Spielstart.UseVisualStyleBackColor = true;
            this.btn_Spielstart.Click += new System.EventHandler(this.Btn_Spielstart_Click);
            // 
            // lbl_SpielAnzahl
            // 
            this.lbl_SpielAnzahl.AutoSize = true;
            this.lbl_SpielAnzahl.Location = new System.Drawing.Point(320, 351);
            this.lbl_SpielAnzahl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SpielAnzahl.Name = "lbl_SpielAnzahl";
            this.lbl_SpielAnzahl.Size = new System.Drawing.Size(188, 17);
            this.lbl_SpielAnzahl.TabIndex = 24;
            this.lbl_SpielAnzahl.Text = "Anzahl der Spiele: 0";
            // 
            // Frm_Teamzusammstellung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 433);
            this.Controls.Add(this.lbl_SpielAnzahl);
            this.Controls.Add(this.btn_Spielstart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_DurchschnittT2);
            this.Controls.Add(this.lbl_DurchschnittT1);
            this.Controls.Add(this.btn_Zufallsspiel);
            this.Controls.Add(this.btn_Teamerstellung);
            this.Controls.Add(this.radioBtn_Support);
            this.Controls.Add(this.radioBtn_Dps);
            this.Controls.Add(this.radioBtn_Tank);
            this.Controls.Add(this.list_Team2);
            this.Controls.Add(this.list_Team1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_Alle);
            this.Controls.Add(this.btn_Hinzufuegen);
            this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Teamzusammstellung";
            this.Text = "Overwatch Teamzusammenstellung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Hinzufuegen;
        public System.Windows.Forms.ListBox list_Alle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox list_Team1;
        private System.Windows.Forms.ListBox list_Team2;
        private System.Windows.Forms.RadioButton radioBtn_Tank;
        private System.Windows.Forms.RadioButton radioBtn_Dps;
        private System.Windows.Forms.RadioButton radioBtn_Support;
        private System.Windows.Forms.Button btn_Teamerstellung;
        private System.Windows.Forms.Button btn_Zufallsspiel;
        private System.Windows.Forms.Label lbl_DurchschnittT1;
        private System.Windows.Forms.Label lbl_DurchschnittT2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Spielstart;
        private System.Windows.Forms.Label lbl_SpielAnzahl;
    }
}

