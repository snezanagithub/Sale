namespace Narudžba
{
    partial class FormStavkeNarudžbe
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
            this.listViewStavkeNarudžbe = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IzmijeniStavkeNarudžbe = new System.Windows.Forms.Button();
            this.buttonObrišiStavkuNarudžbe = new System.Windows.Forms.Button();
            this.buttonOsvježiPodatke = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxCijena = new System.Windows.Forms.TextBox();
            this.buttonPretraga = new System.Windows.Forms.Button();
            this.buttonPretražiStavkeNarudžbe = new System.Windows.Forms.Button();
            this.textBoxNarudžbaProizvodID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewStavkeNarudžbe
            // 
            this.listViewStavkeNarudžbe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewStavkeNarudžbe.HideSelection = false;
            this.listViewStavkeNarudžbe.Location = new System.Drawing.Point(23, 100);
            this.listViewStavkeNarudžbe.Name = "listViewStavkeNarudžbe";
            this.listViewStavkeNarudžbe.Size = new System.Drawing.Size(387, 315);
            this.listViewStavkeNarudžbe.TabIndex = 12;
            this.listViewStavkeNarudžbe.UseCompatibleStateImageBehavior = false;
            this.listViewStavkeNarudžbe.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Narudžba_ProizvodId";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NarudžbaId";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ProizvodID";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Količina";
            this.columnHeader4.Width = 50;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Cijena";
            this.columnHeader5.Width = 50;
            // 
            // IzmijeniStavkeNarudžbe
            // 
            this.IzmijeniStavkeNarudžbe.BackColor = System.Drawing.Color.White;
            this.IzmijeniStavkeNarudžbe.Location = new System.Drawing.Point(335, 33);
            this.IzmijeniStavkeNarudžbe.Name = "IzmijeniStavkeNarudžbe";
            this.IzmijeniStavkeNarudžbe.Size = new System.Drawing.Size(75, 29);
            this.IzmijeniStavkeNarudžbe.TabIndex = 11;
            this.IzmijeniStavkeNarudžbe.Text = "Izmijeni";
            this.IzmijeniStavkeNarudžbe.UseVisualStyleBackColor = false;
            this.IzmijeniStavkeNarudžbe.Click += new System.EventHandler(this.IzmijeniStavkeNarudžbe_Click);
            // 
            // buttonObrišiStavkuNarudžbe
            // 
            this.buttonObrišiStavkuNarudžbe.BackColor = System.Drawing.Color.White;
            this.buttonObrišiStavkuNarudžbe.Location = new System.Drawing.Point(243, 33);
            this.buttonObrišiStavkuNarudžbe.Name = "buttonObrišiStavkuNarudžbe";
            this.buttonObrišiStavkuNarudžbe.Size = new System.Drawing.Size(75, 29);
            this.buttonObrišiStavkuNarudžbe.TabIndex = 10;
            this.buttonObrišiStavkuNarudžbe.Text = "Obriši";
            this.buttonObrišiStavkuNarudžbe.UseVisualStyleBackColor = false;
            this.buttonObrišiStavkuNarudžbe.Click += new System.EventHandler(this.buttonObrišiStavkuNarudžbe_Click);
            // 
            // buttonOsvježiPodatke
            // 
            this.buttonOsvježiPodatke.BackColor = System.Drawing.Color.White;
            this.buttonOsvježiPodatke.Location = new System.Drawing.Point(23, 33);
            this.buttonOsvježiPodatke.Name = "buttonOsvježiPodatke";
            this.buttonOsvježiPodatke.Size = new System.Drawing.Size(75, 29);
            this.buttonOsvježiPodatke.TabIndex = 13;
            this.buttonOsvježiPodatke.Text = "Osvježi podatke";
            this.buttonOsvježiPodatke.UseVisualStyleBackColor = false;
            this.buttonOsvježiPodatke.Click += new System.EventHandler(this.buttonOsvježiPodatke_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxCijena);
            this.panel1.Controls.Add(this.buttonPretraga);
            this.panel1.Controls.Add(this.buttonPretražiStavkeNarudžbe);
            this.panel1.Controls.Add(this.textBoxNarudžbaProizvodID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 455);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 183);
            this.panel1.TabIndex = 14;
            // 
            // textBoxCijena
            // 
            this.textBoxCijena.Location = new System.Drawing.Point(273, 62);
            this.textBoxCijena.Name = "textBoxCijena";
            this.textBoxCijena.Size = new System.Drawing.Size(61, 20);
            this.textBoxCijena.TabIndex = 4;
            this.textBoxCijena.Text = "Cijena";
            this.textBoxCijena.TextChanged += new System.EventHandler(this.textBoxCijena_TextChanged);
            this.textBoxCijena.Enter += new System.EventHandler(this.textBoxCijena_Enter);
            this.textBoxCijena.Leave += new System.EventHandler(this.textBoxCijena_Leave);
            // 
            // buttonPretraga
            // 
            this.buttonPretraga.Location = new System.Drawing.Point(254, 97);
            this.buttonPretraga.Name = "buttonPretraga";
            this.buttonPretraga.Size = new System.Drawing.Size(92, 52);
            this.buttonPretraga.TabIndex = 3;
            this.buttonPretraga.Text = "Pretraži";
            this.buttonPretraga.UseVisualStyleBackColor = true;
            this.buttonPretraga.Click += new System.EventHandler(this.buttonPretraga_Click);
            // 
            // buttonPretražiStavkeNarudžbe
            // 
            this.buttonPretražiStavkeNarudžbe.BackColor = System.Drawing.Color.White;
            this.buttonPretražiStavkeNarudžbe.Location = new System.Drawing.Point(12, 97);
            this.buttonPretražiStavkeNarudžbe.Name = "buttonPretražiStavkeNarudžbe";
            this.buttonPretražiStavkeNarudžbe.Size = new System.Drawing.Size(92, 52);
            this.buttonPretražiStavkeNarudžbe.TabIndex = 2;
            this.buttonPretražiStavkeNarudžbe.Text = "Pretraži";
            this.buttonPretražiStavkeNarudžbe.UseVisualStyleBackColor = false;
            this.buttonPretražiStavkeNarudžbe.Click += new System.EventHandler(this.buttonPretražiStavkeNarudžbe_Click);
            // 
            // textBoxNarudžbaProizvodID
            // 
            this.textBoxNarudžbaProizvodID.Location = new System.Drawing.Point(28, 62);
            this.textBoxNarudžbaProizvodID.Name = "textBoxNarudžbaProizvodID";
            this.textBoxNarudžbaProizvodID.Size = new System.Drawing.Size(61, 20);
            this.textBoxNarudžbaProizvodID.TabIndex = 1;
            this.textBoxNarudžbaProizvodID.Text = "Id stavke";
            this.textBoxNarudžbaProizvodID.TextChanged += new System.EventHandler(this.textBoxNarudžbaProizvodID_TextChanged);
            this.textBoxNarudžbaProizvodID.Enter += new System.EventHandler(this.textBoxNarudžbaProizvodID_Enter);
            this.textBoxNarudžbaProizvodID.Leave += new System.EventHandler(this.textBoxNarudžbaProizvodID_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(121, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pretraga podataka";
            // 
            // FormStavkeNarudžbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(439, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewStavkeNarudžbe);
            this.Controls.Add(this.IzmijeniStavkeNarudžbe);
            this.Controls.Add(this.buttonObrišiStavkuNarudžbe);
            this.Controls.Add(this.buttonOsvježiPodatke);
            this.Name = "FormStavkeNarudžbe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stavke Narudžbe";
            this.Load += new System.EventHandler(this.FormStavkeNarudžbe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewStavkeNarudžbe;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button IzmijeniStavkeNarudžbe;
        private System.Windows.Forms.Button buttonObrišiStavkuNarudžbe;
        private System.Windows.Forms.Button buttonOsvježiPodatke;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPretražiStavkeNarudžbe;
        private System.Windows.Forms.TextBox textBoxNarudžbaProizvodID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPretraga;
        private System.Windows.Forms.TextBox textBoxCijena;
    }
}