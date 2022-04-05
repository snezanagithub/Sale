namespace Narudžba
{
    partial class FormRadnik
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
            this.buttonOsvježiPodatke = new System.Windows.Forms.Button();
            this.buttonObrišiRadnika = new System.Windows.Forms.Button();
            this.IzmijeniRadnika = new System.Windows.Forms.Button();
            this.listViewRadnik = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPretragaImePrezime = new System.Windows.Forms.Button();
            this.textBoxImePrezime = new System.Windows.Forms.TextBox();
            this.buttonPretragaPoDatumu = new System.Windows.Forms.Button();
            this.textBoxDatumZaposlenja = new System.Windows.Forms.TextBox();
            this.buttonPretraži = new System.Windows.Forms.Button();
            this.textBoxRadnikId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOsvježiPodatke
            // 
            this.buttonOsvježiPodatke.BackColor = System.Drawing.Color.White;
            this.buttonOsvježiPodatke.Location = new System.Drawing.Point(12, 25);
            this.buttonOsvježiPodatke.Name = "buttonOsvježiPodatke";
            this.buttonOsvježiPodatke.Size = new System.Drawing.Size(75, 23);
            this.buttonOsvježiPodatke.TabIndex = 5;
            this.buttonOsvježiPodatke.Text = "Osvježi podatke";
            this.buttonOsvježiPodatke.UseVisualStyleBackColor = false;
            this.buttonOsvježiPodatke.Click += new System.EventHandler(this.buttonOsvježiPodatke_Click);
            // 
            // buttonObrišiRadnika
            // 
            this.buttonObrišiRadnika.BackColor = System.Drawing.Color.White;
            this.buttonObrišiRadnika.Location = new System.Drawing.Point(744, 37);
            this.buttonObrišiRadnika.Name = "buttonObrišiRadnika";
            this.buttonObrišiRadnika.Size = new System.Drawing.Size(75, 23);
            this.buttonObrišiRadnika.TabIndex = 1;
            this.buttonObrišiRadnika.Text = "Obriši";
            this.buttonObrišiRadnika.UseVisualStyleBackColor = false;
            this.buttonObrišiRadnika.Click += new System.EventHandler(this.buttonObrišiRadnika_Click);
            // 
            // IzmijeniRadnika
            // 
            this.IzmijeniRadnika.BackColor = System.Drawing.Color.White;
            this.IzmijeniRadnika.Location = new System.Drawing.Point(848, 37);
            this.IzmijeniRadnika.Name = "IzmijeniRadnika";
            this.IzmijeniRadnika.Size = new System.Drawing.Size(75, 23);
            this.IzmijeniRadnika.TabIndex = 2;
            this.IzmijeniRadnika.Text = "Izmijeni";
            this.IzmijeniRadnika.UseVisualStyleBackColor = false;
            this.IzmijeniRadnika.Click += new System.EventHandler(this.IzmijeniRadnika_Click);
            // 
            // listViewRadnik
            // 
            this.listViewRadnik.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader8});
            this.listViewRadnik.HideSelection = false;
            this.listViewRadnik.Location = new System.Drawing.Point(12, 90);
            this.listViewRadnik.Name = "listViewRadnik";
            this.listViewRadnik.Size = new System.Drawing.Size(922, 315);
            this.listViewRadnik.TabIndex = 3;
            this.listViewRadnik.UseCompatibleStateImageBehavior = false;
            this.listViewRadnik.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "RadnikId";
            this.columnHeader1.Width = 55;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "MjestoId";
            this.columnHeader2.Width = 55;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ime";
            this.columnHeader3.Width = 79;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Prezime";
            this.columnHeader4.Width = 83;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Broj telefona";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Email";
            this.columnHeader6.Width = 145;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Adresa";
            this.columnHeader7.Width = 212;
            // 
            // columnHeader9
            // 
            this.columnHeader9.DisplayIndex = 8;
            this.columnHeader9.Text = "Datum rođenja";
            this.columnHeader9.Width = 85;
            // 
            // columnHeader8
            // 
            this.columnHeader8.DisplayIndex = 7;
            this.columnHeader8.Text = "Datum zaposlenja";
            this.columnHeader8.Width = 105;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonPretragaImePrezime);
            this.panel1.Controls.Add(this.textBoxImePrezime);
            this.panel1.Controls.Add(this.buttonPretragaPoDatumu);
            this.panel1.Controls.Add(this.textBoxDatumZaposlenja);
            this.panel1.Controls.Add(this.buttonPretraži);
            this.panel1.Controls.Add(this.textBoxRadnikId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 411);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 207);
            this.panel1.TabIndex = 4;
            // 
            // buttonPretragaImePrezime
            // 
            this.buttonPretragaImePrezime.BackColor = System.Drawing.Color.Yellow;
            this.buttonPretragaImePrezime.Location = new System.Drawing.Point(802, 120);
            this.buttonPretragaImePrezime.Name = "buttonPretragaImePrezime";
            this.buttonPretragaImePrezime.Size = new System.Drawing.Size(92, 52);
            this.buttonPretragaImePrezime.TabIndex = 6;
            this.buttonPretragaImePrezime.Text = "Pretraži";
            this.buttonPretragaImePrezime.UseVisualStyleBackColor = false;
            this.buttonPretragaImePrezime.Click += new System.EventHandler(this.buttonPretragaImePrezime_Click);
            // 
            // textBoxImePrezime
            // 
            this.textBoxImePrezime.Location = new System.Drawing.Point(800, 73);
            this.textBoxImePrezime.Name = "textBoxImePrezime";
            this.textBoxImePrezime.Size = new System.Drawing.Size(94, 20);
            this.textBoxImePrezime.TabIndex = 5;
            this.textBoxImePrezime.Text = "Ime ili Prezime";
            this.textBoxImePrezime.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxImePrezime.Enter += new System.EventHandler(this.textBoxImePrezime_Enter);
            this.textBoxImePrezime.Leave += new System.EventHandler(this.textBoxImePrezime_Leave);
            // 
            // buttonPretragaPoDatumu
            // 
            this.buttonPretragaPoDatumu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonPretragaPoDatumu.Location = new System.Drawing.Point(412, 132);
            this.buttonPretragaPoDatumu.Name = "buttonPretragaPoDatumu";
            this.buttonPretragaPoDatumu.Size = new System.Drawing.Size(92, 52);
            this.buttonPretragaPoDatumu.TabIndex = 4;
            this.buttonPretragaPoDatumu.Text = "Pretraži";
            this.buttonPretragaPoDatumu.UseVisualStyleBackColor = false;
            this.buttonPretragaPoDatumu.Click += new System.EventHandler(this.buttonPretragaPoDatumu_Click);
            // 
            // textBoxDatumZaposlenja
            // 
            this.textBoxDatumZaposlenja.Location = new System.Drawing.Point(412, 85);
            this.textBoxDatumZaposlenja.Name = "textBoxDatumZaposlenja";
            this.textBoxDatumZaposlenja.Size = new System.Drawing.Size(94, 20);
            this.textBoxDatumZaposlenja.TabIndex = 3;
            this.textBoxDatumZaposlenja.Text = "Datum zaposlenja";
            this.textBoxDatumZaposlenja.TextChanged += new System.EventHandler(this.textBoxDatumZaposlenja_TextChanged);
            this.textBoxDatumZaposlenja.Enter += new System.EventHandler(this.textBoxDatumZaposlenja_Enter);
            this.textBoxDatumZaposlenja.Leave += new System.EventHandler(this.textBoxDatumZaposlenja_Leave);
            // 
            // buttonPretraži
            // 
            this.buttonPretraži.BackColor = System.Drawing.Color.Lime;
            this.buttonPretraži.Location = new System.Drawing.Point(49, 132);
            this.buttonPretraži.Name = "buttonPretraži";
            this.buttonPretraži.Size = new System.Drawing.Size(92, 52);
            this.buttonPretraži.TabIndex = 2;
            this.buttonPretraži.Text = "Pretraži";
            this.buttonPretraži.UseVisualStyleBackColor = false;
            this.buttonPretraži.Click += new System.EventHandler(this.buttonPretraži_Click);
            // 
            // textBoxRadnikId
            // 
            this.textBoxRadnikId.Location = new System.Drawing.Point(49, 85);
            this.textBoxRadnikId.Name = "textBoxRadnikId";
            this.textBoxRadnikId.Size = new System.Drawing.Size(94, 20);
            this.textBoxRadnikId.TabIndex = 1;
            this.textBoxRadnikId.Text = "Id radnika";
            this.textBoxRadnikId.TextChanged += new System.EventHandler(this.textBoxRadnik_TextChanged);
            this.textBoxRadnikId.Enter += new System.EventHandler(this.textBoxRadnik_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pretraga podataka";
            // 
            // FormRadnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(951, 633);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewRadnik);
            this.Controls.Add(this.IzmijeniRadnika);
            this.Controls.Add(this.buttonObrišiRadnika);
            this.Controls.Add(this.buttonOsvježiPodatke);
            this.Name = "FormRadnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radnici";
            this.Load += new System.EventHandler(this.FormRadnik_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOsvježiPodatke;
        private System.Windows.Forms.Button buttonObrišiRadnika;
        private System.Windows.Forms.Button IzmijeniRadnika;
        private System.Windows.Forms.ListView listViewRadnik;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPretraži;
        private System.Windows.Forms.TextBox textBoxRadnikId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button buttonPretragaPoDatumu;
        private System.Windows.Forms.TextBox textBoxDatumZaposlenja;
        private System.Windows.Forms.Button buttonPretragaImePrezime;
        private System.Windows.Forms.TextBox textBoxImePrezime;
    }
}