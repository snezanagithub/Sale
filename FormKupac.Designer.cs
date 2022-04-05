namespace Narudžba
{
    partial class FormKupac
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
            this.listViewKupac = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IzmijeniKupca = new System.Windows.Forms.Button();
            this.buttonObrišiKupca = new System.Windows.Forms.Button();
            this.buttonOsvježiPodatkeKupca = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPretragaImePrezime = new System.Windows.Forms.Button();
            this.textBoxImePrezime = new System.Windows.Forms.TextBox();
            this.buttonPretražiKupca = new System.Windows.Forms.Button();
            this.textBoxKupacId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewKupac
            // 
            this.listViewKupac.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewKupac.HideSelection = false;
            this.listViewKupac.Location = new System.Drawing.Point(12, 84);
            this.listViewKupac.Name = "listViewKupac";
            this.listViewKupac.Size = new System.Drawing.Size(702, 315);
            this.listViewKupac.TabIndex = 8;
            this.listViewKupac.UseCompatibleStateImageBehavior = false;
            this.listViewKupac.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "KupacId";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "MjestoId";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ime";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Prezime";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adresa";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "JMB";
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Broj telefona";
            this.columnHeader7.Width = 129;
            // 
            // IzmijeniKupca
            // 
            this.IzmijeniKupca.BackColor = System.Drawing.Color.White;
            this.IzmijeniKupca.Location = new System.Drawing.Point(639, 23);
            this.IzmijeniKupca.Name = "IzmijeniKupca";
            this.IzmijeniKupca.Size = new System.Drawing.Size(75, 23);
            this.IzmijeniKupca.TabIndex = 7;
            this.IzmijeniKupca.Text = "Izmijeni";
            this.IzmijeniKupca.UseVisualStyleBackColor = false;
            this.IzmijeniKupca.Click += new System.EventHandler(this.IzmijeniKupca_Click);
            // 
            // buttonObrišiKupca
            // 
            this.buttonObrišiKupca.BackColor = System.Drawing.Color.White;
            this.buttonObrišiKupca.Location = new System.Drawing.Point(512, 23);
            this.buttonObrišiKupca.Name = "buttonObrišiKupca";
            this.buttonObrišiKupca.Size = new System.Drawing.Size(75, 23);
            this.buttonObrišiKupca.TabIndex = 6;
            this.buttonObrišiKupca.Text = "Obriši";
            this.buttonObrišiKupca.UseVisualStyleBackColor = false;
            this.buttonObrišiKupca.Click += new System.EventHandler(this.buttonObrišiKupca_Click);
            // 
            // buttonOsvježiPodatkeKupca
            // 
            this.buttonOsvježiPodatkeKupca.BackColor = System.Drawing.Color.White;
            this.buttonOsvježiPodatkeKupca.Location = new System.Drawing.Point(36, 23);
            this.buttonOsvježiPodatkeKupca.Name = "buttonOsvježiPodatkeKupca";
            this.buttonOsvježiPodatkeKupca.Size = new System.Drawing.Size(75, 23);
            this.buttonOsvježiPodatkeKupca.TabIndex = 9;
            this.buttonOsvježiPodatkeKupca.Text = "Osvježi podatke";
            this.buttonOsvježiPodatkeKupca.UseVisualStyleBackColor = false;
            this.buttonOsvježiPodatkeKupca.Click += new System.EventHandler(this.buttonOsvježiPodatkeKupca_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonPretragaImePrezime);
            this.panel1.Controls.Add(this.textBoxImePrezime);
            this.panel1.Controls.Add(this.buttonPretražiKupca);
            this.panel1.Controls.Add(this.textBoxKupacId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 422);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 205);
            this.panel1.TabIndex = 10;
            // 
            // buttonPretragaImePrezime
            // 
            this.buttonPretragaImePrezime.Location = new System.Drawing.Point(595, 108);
            this.buttonPretragaImePrezime.Name = "buttonPretragaImePrezime";
            this.buttonPretragaImePrezime.Size = new System.Drawing.Size(92, 52);
            this.buttonPretragaImePrezime.TabIndex = 4;
            this.buttonPretragaImePrezime.Text = "Pretraži";
            this.buttonPretragaImePrezime.UseVisualStyleBackColor = true;
            this.buttonPretragaImePrezime.Click += new System.EventHandler(this.buttonPretragaImePrezime_Click);
            // 
            // textBoxImePrezime
            // 
            this.textBoxImePrezime.Location = new System.Drawing.Point(595, 61);
            this.textBoxImePrezime.Name = "textBoxImePrezime";
            this.textBoxImePrezime.Size = new System.Drawing.Size(79, 20);
            this.textBoxImePrezime.TabIndex = 3;
            this.textBoxImePrezime.Text = "Ime ili Prezime";
            this.textBoxImePrezime.TextChanged += new System.EventHandler(this.textBoxImePrezime_TextChanged);
            this.textBoxImePrezime.Enter += new System.EventHandler(this.textBoxImePrezime_Enter);
            this.textBoxImePrezime.Leave += new System.EventHandler(this.textBoxImePrezime_Leave);
            // 
            // buttonPretražiKupca
            // 
            this.buttonPretražiKupca.Location = new System.Drawing.Point(24, 108);
            this.buttonPretražiKupca.Name = "buttonPretražiKupca";
            this.buttonPretražiKupca.Size = new System.Drawing.Size(92, 52);
            this.buttonPretražiKupca.TabIndex = 2;
            this.buttonPretražiKupca.Text = "Pretraži";
            this.buttonPretražiKupca.UseVisualStyleBackColor = true;
            this.buttonPretražiKupca.Click += new System.EventHandler(this.buttonPretražiKupca_Click);
            // 
            // textBoxKupacId
            // 
            this.textBoxKupacId.Location = new System.Drawing.Point(38, 61);
            this.textBoxKupacId.Name = "textBoxKupacId";
            this.textBoxKupacId.Size = new System.Drawing.Size(61, 20);
            this.textBoxKupacId.TabIndex = 1;
            this.textBoxKupacId.Text = "Id kupca";
            this.textBoxKupacId.TextChanged += new System.EventHandler(this.textBoxKupacId_TextChanged);
            this.textBoxKupacId.Enter += new System.EventHandler(this.textBoxKupacId_Enter);
            this.textBoxKupacId.Leave += new System.EventHandler(this.textBoxKupacId_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pretraga podataka";
            // 
            // FormKupac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(752, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewKupac);
            this.Controls.Add(this.IzmijeniKupca);
            this.Controls.Add(this.buttonObrišiKupca);
            this.Controls.Add(this.buttonOsvježiPodatkeKupca);
            this.Name = "FormKupac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kupci";
            this.Load += new System.EventHandler(this.FormKupac_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewKupac;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button IzmijeniKupca;
        private System.Windows.Forms.Button buttonObrišiKupca;
        private System.Windows.Forms.Button buttonOsvježiPodatkeKupca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPretražiKupca;
        private System.Windows.Forms.TextBox textBoxKupacId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPretragaImePrezime;
        private System.Windows.Forms.TextBox textBoxImePrezime;
    }
}