namespace Narudžba
{
    partial class FormIzmijeniKupca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxBrojTelefonaKupca = new System.Windows.Forms.TextBox();
            this.textBoxJMB = new System.Windows.Forms.TextBox();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.labelBrojTelefonaKupca = new System.Windows.Forms.Label();
            this.labelJMBKupca = new System.Windows.Forms.Label();
            this.labelAdresaKupca = new System.Windows.Forms.Label();
            this.labelPrezimeRadnikaIzmjena = new System.Windows.Forms.Label();
            this.labelImeRadnikaIzmjena = new System.Windows.Forms.Label();
            this.labelMjestoId = new System.Windows.Forms.Label();
            this.textBoxKupacId = new System.Windows.Forms.TextBox();
            this.labelRadnikIdIzmjena = new System.Windows.Forms.Label();
            this.buttonIzmijeniKupca = new System.Windows.Forms.Button();
            this.comboBoxIzmjena = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxBrojTelefonaKupca
            // 
            this.textBoxBrojTelefonaKupca.Location = new System.Drawing.Point(173, 309);
            this.textBoxBrojTelefonaKupca.Name = "textBoxBrojTelefonaKupca";
            this.textBoxBrojTelefonaKupca.Size = new System.Drawing.Size(100, 20);
            this.textBoxBrojTelefonaKupca.TabIndex = 29;
            this.textBoxBrojTelefonaKupca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBrojTelefonaKupca_KeyPress);
            // 
            // textBoxJMB
            // 
            this.textBoxJMB.Location = new System.Drawing.Point(173, 261);
            this.textBoxJMB.Name = "textBoxJMB";
            this.textBoxJMB.Size = new System.Drawing.Size(100, 20);
            this.textBoxJMB.TabIndex = 28;
            this.textBoxJMB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxJMB_KeyPress);
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Location = new System.Drawing.Point(173, 219);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdresa.TabIndex = 27;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(173, 175);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrezime.TabIndex = 26;
            this.textBoxPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrezime_KeyPress);
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(173, 129);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(100, 20);
            this.textBoxIme.TabIndex = 25;
            this.textBoxIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIme_KeyPress);
            // 
            // labelBrojTelefonaKupca
            // 
            this.labelBrojTelefonaKupca.AutoSize = true;
            this.labelBrojTelefonaKupca.Location = new System.Drawing.Point(33, 316);
            this.labelBrojTelefonaKupca.Name = "labelBrojTelefonaKupca";
            this.labelBrojTelefonaKupca.Size = new System.Drawing.Size(66, 13);
            this.labelBrojTelefonaKupca.TabIndex = 23;
            this.labelBrojTelefonaKupca.Text = "Broj telefona";
            // 
            // labelJMBKupca
            // 
            this.labelJMBKupca.AutoSize = true;
            this.labelJMBKupca.Location = new System.Drawing.Point(33, 268);
            this.labelJMBKupca.Name = "labelJMBKupca";
            this.labelJMBKupca.Size = new System.Drawing.Size(28, 13);
            this.labelJMBKupca.TabIndex = 22;
            this.labelJMBKupca.Text = "JMB";
            // 
            // labelAdresaKupca
            // 
            this.labelAdresaKupca.AutoSize = true;
            this.labelAdresaKupca.Location = new System.Drawing.Point(33, 226);
            this.labelAdresaKupca.Name = "labelAdresaKupca";
            this.labelAdresaKupca.Size = new System.Drawing.Size(40, 13);
            this.labelAdresaKupca.TabIndex = 21;
            this.labelAdresaKupca.Text = "Adresa";
            // 
            // labelPrezimeRadnikaIzmjena
            // 
            this.labelPrezimeRadnikaIzmjena.AutoSize = true;
            this.labelPrezimeRadnikaIzmjena.Location = new System.Drawing.Point(33, 178);
            this.labelPrezimeRadnikaIzmjena.Name = "labelPrezimeRadnikaIzmjena";
            this.labelPrezimeRadnikaIzmjena.Size = new System.Drawing.Size(44, 13);
            this.labelPrezimeRadnikaIzmjena.TabIndex = 20;
            this.labelPrezimeRadnikaIzmjena.Text = "Prezime";
            // 
            // labelImeRadnikaIzmjena
            // 
            this.labelImeRadnikaIzmjena.AutoSize = true;
            this.labelImeRadnikaIzmjena.Location = new System.Drawing.Point(33, 132);
            this.labelImeRadnikaIzmjena.Name = "labelImeRadnikaIzmjena";
            this.labelImeRadnikaIzmjena.Size = new System.Drawing.Size(24, 13);
            this.labelImeRadnikaIzmjena.TabIndex = 19;
            this.labelImeRadnikaIzmjena.Text = "Ime";
            // 
            // labelMjestoId
            // 
            this.labelMjestoId.AutoSize = true;
            this.labelMjestoId.Location = new System.Drawing.Point(33, 86);
            this.labelMjestoId.Name = "labelMjestoId";
            this.labelMjestoId.Size = new System.Drawing.Size(47, 13);
            this.labelMjestoId.TabIndex = 18;
            this.labelMjestoId.Text = "MjestoId";
            // 
            // textBoxKupacId
            // 
            this.textBoxKupacId.Location = new System.Drawing.Point(173, 30);
            this.textBoxKupacId.Multiline = true;
            this.textBoxKupacId.Name = "textBoxKupacId";
            this.textBoxKupacId.Size = new System.Drawing.Size(100, 21);
            this.textBoxKupacId.TabIndex = 17;
            // 
            // labelRadnikIdIzmjena
            // 
            this.labelRadnikIdIzmjena.AutoSize = true;
            this.labelRadnikIdIzmjena.Location = new System.Drawing.Point(33, 38);
            this.labelRadnikIdIzmjena.Name = "labelRadnikIdIzmjena";
            this.labelRadnikIdIzmjena.Size = new System.Drawing.Size(47, 13);
            this.labelRadnikIdIzmjena.TabIndex = 16;
            this.labelRadnikIdIzmjena.Text = "KupacId";
            // 
            // buttonIzmijeniKupca
            // 
            this.buttonIzmijeniKupca.BackColor = System.Drawing.Color.White;
            this.buttonIzmijeniKupca.Location = new System.Drawing.Point(163, 365);
            this.buttonIzmijeniKupca.Name = "buttonIzmijeniKupca";
            this.buttonIzmijeniKupca.Size = new System.Drawing.Size(127, 26);
            this.buttonIzmijeniKupca.TabIndex = 30;
            this.buttonIzmijeniKupca.Text = "Izmijeni kupca";
            this.buttonIzmijeniKupca.UseVisualStyleBackColor = false;
            this.buttonIzmijeniKupca.Click += new System.EventHandler(this.buttonIzmijeniKupca_Click);
            // 
            // comboBoxIzmjena
            // 
            this.comboBoxIzmjena.FormattingEnabled = true;
            this.comboBoxIzmjena.Location = new System.Drawing.Point(173, 83);
            this.comboBoxIzmjena.Name = "comboBoxIzmjena";
            this.comboBoxIzmjena.Size = new System.Drawing.Size(100, 21);
            this.comboBoxIzmjena.TabIndex = 31;
            this.comboBoxIzmjena.SelectedIndexChanged += new System.EventHandler(this.comboBoxIzmjena_SelectedIndexChanged);
            // 
            // FormIzmijeniKupca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(364, 450);
            this.Controls.Add(this.comboBoxIzmjena);
            this.Controls.Add(this.buttonIzmijeniKupca);
            this.Controls.Add(this.textBoxBrojTelefonaKupca);
            this.Controls.Add(this.textBoxJMB);
            this.Controls.Add(this.textBoxAdresa);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.labelBrojTelefonaKupca);
            this.Controls.Add(this.labelJMBKupca);
            this.Controls.Add(this.labelAdresaKupca);
            this.Controls.Add(this.labelPrezimeRadnikaIzmjena);
            this.Controls.Add(this.labelImeRadnikaIzmjena);
            this.Controls.Add(this.labelMjestoId);
            this.Controls.Add(this.textBoxKupacId);
            this.Controls.Add(this.labelRadnikIdIzmjena);
            this.Name = "FormIzmijeniKupca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izmijeni Kupca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBrojTelefonaKupca;
        private System.Windows.Forms.TextBox textBoxJMB;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.Label labelBrojTelefonaKupca;
        private System.Windows.Forms.Label labelJMBKupca;
        private System.Windows.Forms.Label labelAdresaKupca;
        private System.Windows.Forms.Label labelPrezimeRadnikaIzmjena;
        private System.Windows.Forms.Label labelImeRadnikaIzmjena;
        private System.Windows.Forms.Label labelMjestoId;
        private System.Windows.Forms.TextBox textBoxKupacId;
        private System.Windows.Forms.Label labelRadnikIdIzmjena;
        private System.Windows.Forms.Button buttonIzmijeniKupca;
        private System.Windows.Forms.ComboBox comboBoxIzmjena;
    }
}