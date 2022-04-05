namespace Narudžba
{
    partial class FormNarudžba
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
            this.listViewNarudžba = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IzmijeniNarudžbu = new System.Windows.Forms.Button();
            this.buttonObrišiNarudžbu = new System.Windows.Forms.Button();
            this.buttonOsvježiPodatke = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxPretragaDatum = new System.Windows.Forms.TextBox();
            this.buttonPretragaDatum = new System.Windows.Forms.Button();
            this.buttonPretražiNarudžbe = new System.Windows.Forms.Button();
            this.textBoxNarudžbaID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewNarudžba
            // 
            this.listViewNarudžba.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listViewNarudžba.HideSelection = false;
            this.listViewNarudžba.Location = new System.Drawing.Point(12, 96);
            this.listViewNarudžba.Name = "listViewNarudžba";
            this.listViewNarudžba.Size = new System.Drawing.Size(798, 315);
            this.listViewNarudžba.TabIndex = 8;
            this.listViewNarudžba.UseCompatibleStateImageBehavior = false;
            this.listViewNarudžba.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NarudžbaId";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tip_plaćanjaId";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "RadnikID";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "KupacID";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Datum_nastanka";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Status";
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Iznos bez pdv-a";
            this.columnHeader7.Width = 90;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Pdv";
            this.columnHeader8.Width = 90;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Iznos sa pdv-om";
            this.columnHeader9.Width = 110;
            // 
            // IzmijeniNarudžbu
            // 
            this.IzmijeniNarudžbu.BackColor = System.Drawing.Color.White;
            this.IzmijeniNarudžbu.Location = new System.Drawing.Point(717, 26);
            this.IzmijeniNarudžbu.Name = "IzmijeniNarudžbu";
            this.IzmijeniNarudžbu.Size = new System.Drawing.Size(75, 40);
            this.IzmijeniNarudžbu.TabIndex = 7;
            this.IzmijeniNarudžbu.Text = "Izmijeni";
            this.IzmijeniNarudžbu.UseVisualStyleBackColor = false;
            this.IzmijeniNarudžbu.Click += new System.EventHandler(this.IzmijeniNarudžbu_Click_1);
            // 
            // buttonObrišiNarudžbu
            // 
            this.buttonObrišiNarudžbu.BackColor = System.Drawing.Color.White;
            this.buttonObrišiNarudžbu.Location = new System.Drawing.Point(138, 26);
            this.buttonObrišiNarudžbu.Name = "buttonObrišiNarudžbu";
            this.buttonObrišiNarudžbu.Size = new System.Drawing.Size(75, 40);
            this.buttonObrišiNarudžbu.TabIndex = 6;
            this.buttonObrišiNarudžbu.Text = "Obriši";
            this.buttonObrišiNarudžbu.UseVisualStyleBackColor = false;
            this.buttonObrišiNarudžbu.Click += new System.EventHandler(this.buttonObrišiNarudžbu_Click);
            // 
            // buttonOsvježiPodatke
            // 
            this.buttonOsvježiPodatke.BackColor = System.Drawing.Color.White;
            this.buttonOsvježiPodatke.Location = new System.Drawing.Point(22, 26);
            this.buttonOsvježiPodatke.Name = "buttonOsvježiPodatke";
            this.buttonOsvježiPodatke.Size = new System.Drawing.Size(75, 40);
            this.buttonOsvježiPodatke.TabIndex = 9;
            this.buttonOsvježiPodatke.Text = "Osvježi podatke";
            this.buttonOsvježiPodatke.UseVisualStyleBackColor = false;
            this.buttonOsvježiPodatke.Click += new System.EventHandler(this.buttonOsvježiPodatke_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxPretragaDatum);
            this.panel1.Controls.Add(this.buttonPretragaDatum);
            this.panel1.Controls.Add(this.buttonPretražiNarudžbe);
            this.panel1.Controls.Add(this.textBoxNarudžbaID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 454);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 161);
            this.panel1.TabIndex = 11;
            this.panel1.Enter += new System.EventHandler(this.textBoxNarudžbaID_Enter);
            // 
            // textBoxPretragaDatum
            // 
            this.textBoxPretragaDatum.Location = new System.Drawing.Point(670, 56);
            this.textBoxPretragaDatum.Name = "textBoxPretragaDatum";
            this.textBoxPretragaDatum.Size = new System.Drawing.Size(100, 20);
            this.textBoxPretragaDatum.TabIndex = 4;
            this.textBoxPretragaDatum.Text = "Datum nastanka";
            this.textBoxPretragaDatum.TextChanged += new System.EventHandler(this.textBoxPretragaDatum_TextChanged);
            this.textBoxPretragaDatum.Enter += new System.EventHandler(this.textBoxPretragaDatum_Enter);
            this.textBoxPretragaDatum.Leave += new System.EventHandler(this.textBoxPretragaDatum_Leave);
            // 
            // buttonPretragaDatum
            // 
            this.buttonPretragaDatum.BackColor = System.Drawing.Color.Coral;
            this.buttonPretragaDatum.Location = new System.Drawing.Point(678, 94);
            this.buttonPretragaDatum.Name = "buttonPretragaDatum";
            this.buttonPretragaDatum.Size = new System.Drawing.Size(92, 52);
            this.buttonPretragaDatum.TabIndex = 3;
            this.buttonPretragaDatum.Text = "Pretraži";
            this.buttonPretragaDatum.UseVisualStyleBackColor = false;
            this.buttonPretragaDatum.Click += new System.EventHandler(this.buttonPretragaDatum_Click);
            // 
            // buttonPretražiNarudžbe
            // 
            this.buttonPretražiNarudžbe.BackColor = System.Drawing.Color.Yellow;
            this.buttonPretražiNarudžbe.Location = new System.Drawing.Point(10, 94);
            this.buttonPretražiNarudžbe.Name = "buttonPretražiNarudžbe";
            this.buttonPretražiNarudžbe.Size = new System.Drawing.Size(92, 52);
            this.buttonPretražiNarudžbe.TabIndex = 2;
            this.buttonPretražiNarudžbe.Text = "Pretraži";
            this.buttonPretražiNarudžbe.UseVisualStyleBackColor = false;
            this.buttonPretražiNarudžbe.Click += new System.EventHandler(this.buttonPretražiNarudžbe_Click);
            // 
            // textBoxNarudžbaID
            // 
            this.textBoxNarudžbaID.Location = new System.Drawing.Point(24, 56);
            this.textBoxNarudžbaID.Name = "textBoxNarudžbaID";
            this.textBoxNarudžbaID.Size = new System.Drawing.Size(61, 20);
            this.textBoxNarudžbaID.TabIndex = 1;
            this.textBoxNarudžbaID.Text = "Id narudžbe";
            this.textBoxNarudžbaID.TextChanged += new System.EventHandler(this.textBoxNarudžbaID_TextChanged);
            this.textBoxNarudžbaID.Enter += new System.EventHandler(this.textBoxNarudžbaID_Enter);
            this.textBoxNarudžbaID.Leave += new System.EventHandler(this.textBoxNarudžbaID_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(305, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pretraga podataka";
            // 
            // FormNarudžba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(822, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewNarudžba);
            this.Controls.Add(this.IzmijeniNarudžbu);
            this.Controls.Add(this.buttonObrišiNarudžbu);
            this.Controls.Add(this.buttonOsvježiPodatke);
            this.Name = "FormNarudžba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Narudžbe";
            this.Load += new System.EventHandler(this.FormNarudžba_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewNarudžba;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button IzmijeniNarudžbu;
        private System.Windows.Forms.Button buttonObrišiNarudžbu;
        private System.Windows.Forms.Button buttonOsvježiPodatke;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPretražiNarudžbe;
        private System.Windows.Forms.TextBox textBoxNarudžbaID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPretragaDatum;
        private System.Windows.Forms.Button buttonPretragaDatum;
    }
}