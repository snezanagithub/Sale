namespace Narudžba
{
    partial class FormProizvod
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
            this.listViewProizvod = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IzmijeniProizvod = new System.Windows.Forms.Button();
            this.buttonObrišiProizvod = new System.Windows.Forms.Button();
            this.buttonOsvježiPodatkeProizvod = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPretragaNaziv = new System.Windows.Forms.Button();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.buttonPretražiProizvode = new System.Windows.Forms.Button();
            this.textBoxProizvodId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewProizvod
            // 
            this.listViewProizvod.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewProizvod.HideSelection = false;
            this.listViewProizvod.Location = new System.Drawing.Point(22, 22);
            this.listViewProizvod.Name = "listViewProizvod";
            this.listViewProizvod.Size = new System.Drawing.Size(305, 380);
            this.listViewProizvod.TabIndex = 12;
            this.listViewProizvod.UseCompatibleStateImageBehavior = false;
            this.listViewProizvod.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ProizvodId";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naziv";
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cijena";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Pdv stopa";
            // 
            // IzmijeniProizvod
            // 
            this.IzmijeniProizvod.BackColor = System.Drawing.Color.White;
            this.IzmijeniProizvod.Location = new System.Drawing.Point(353, 156);
            this.IzmijeniProizvod.Name = "IzmijeniProizvod";
            this.IzmijeniProizvod.Size = new System.Drawing.Size(92, 37);
            this.IzmijeniProizvod.TabIndex = 11;
            this.IzmijeniProizvod.Text = "Izmijeni";
            this.IzmijeniProizvod.UseVisualStyleBackColor = false;
            this.IzmijeniProizvod.Click += new System.EventHandler(this.IzmijeniProizvod_Click);
            // 
            // buttonObrišiProizvod
            // 
            this.buttonObrišiProizvod.BackColor = System.Drawing.Color.White;
            this.buttonObrišiProizvod.Location = new System.Drawing.Point(353, 86);
            this.buttonObrišiProizvod.Name = "buttonObrišiProizvod";
            this.buttonObrišiProizvod.Size = new System.Drawing.Size(92, 37);
            this.buttonObrišiProizvod.TabIndex = 10;
            this.buttonObrišiProizvod.Text = "Obriši";
            this.buttonObrišiProizvod.UseVisualStyleBackColor = false;
            this.buttonObrišiProizvod.Click += new System.EventHandler(this.buttonObrišiProizvod_Click);
            // 
            // buttonOsvježiPodatkeProizvod
            // 
            this.buttonOsvježiPodatkeProizvod.BackColor = System.Drawing.Color.White;
            this.buttonOsvježiPodatkeProizvod.Location = new System.Drawing.Point(353, 22);
            this.buttonOsvježiPodatkeProizvod.Name = "buttonOsvježiPodatkeProizvod";
            this.buttonOsvježiPodatkeProizvod.Size = new System.Drawing.Size(92, 37);
            this.buttonOsvježiPodatkeProizvod.TabIndex = 13;
            this.buttonOsvježiPodatkeProizvod.Text = "Osvježi podatke";
            this.buttonOsvježiPodatkeProizvod.UseVisualStyleBackColor = false;
            this.buttonOsvježiPodatkeProizvod.Click += new System.EventHandler(this.buttonOsvježiPodatkeProizvod_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonPretragaNaziv);
            this.panel1.Controls.Add(this.textBoxNaziv);
            this.panel1.Controls.Add(this.buttonPretražiProizvode);
            this.panel1.Controls.Add(this.textBoxProizvodId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 422);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 166);
            this.panel1.TabIndex = 14;
            // 
            // buttonPretragaNaziv
            // 
            this.buttonPretragaNaziv.BackColor = System.Drawing.Color.Lime;
            this.buttonPretragaNaziv.Location = new System.Drawing.Point(213, 97);
            this.buttonPretragaNaziv.Name = "buttonPretragaNaziv";
            this.buttonPretragaNaziv.Size = new System.Drawing.Size(92, 52);
            this.buttonPretragaNaziv.TabIndex = 4;
            this.buttonPretragaNaziv.Text = "Pretraži";
            this.buttonPretragaNaziv.UseVisualStyleBackColor = false;
            this.buttonPretragaNaziv.Click += new System.EventHandler(this.buttonPretragaNaziv_Click);
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(223, 56);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(68, 20);
            this.textBoxNaziv.TabIndex = 3;
            this.textBoxNaziv.Text = "Naziv";
            this.textBoxNaziv.TextChanged += new System.EventHandler(this.textBoxNaziv_TextChanged);
            this.textBoxNaziv.Enter += new System.EventHandler(this.textBoxNaziv_Enter);
            this.textBoxNaziv.Leave += new System.EventHandler(this.textBoxNaziv_Leave);
            // 
            // buttonPretražiProizvode
            // 
            this.buttonPretražiProizvode.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonPretražiProizvode.Location = new System.Drawing.Point(0, 97);
            this.buttonPretražiProizvode.Name = "buttonPretražiProizvode";
            this.buttonPretražiProizvode.Size = new System.Drawing.Size(92, 52);
            this.buttonPretražiProizvode.TabIndex = 2;
            this.buttonPretražiProizvode.Text = "Pretraži";
            this.buttonPretražiProizvode.UseVisualStyleBackColor = false;
            this.buttonPretražiProizvode.Click += new System.EventHandler(this.buttonPretražiProizvode_Click);
            // 
            // textBoxProizvodId
            // 
            this.textBoxProizvodId.Location = new System.Drawing.Point(15, 56);
            this.textBoxProizvodId.Name = "textBoxProizvodId";
            this.textBoxProizvodId.Size = new System.Drawing.Size(68, 20);
            this.textBoxProizvodId.TabIndex = 1;
            this.textBoxProizvodId.Text = "Id proizvoda";
            this.textBoxProizvodId.TextChanged += new System.EventHandler(this.textBoxProizvodId_TextChanged);
            this.textBoxProizvodId.Enter += new System.EventHandler(this.textBoxProizvodId_Enter);
            this.textBoxProizvodId.Leave += new System.EventHandler(this.textBoxProizvodId_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(98, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pretraga podataka";
            // 
            // FormProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(457, 623);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewProizvod);
            this.Controls.Add(this.IzmijeniProizvod);
            this.Controls.Add(this.buttonObrišiProizvod);
            this.Controls.Add(this.buttonOsvježiPodatkeProizvod);
            this.Name = "FormProizvod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proizvodi";
            this.Load += new System.EventHandler(this.FormProizvod_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewProizvod;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button IzmijeniProizvod;
        private System.Windows.Forms.Button buttonObrišiProizvod;
        private System.Windows.Forms.Button buttonOsvježiPodatkeProizvod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPretražiProizvode;
        private System.Windows.Forms.TextBox textBoxProizvodId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.Button buttonPretragaNaziv;
    }
}