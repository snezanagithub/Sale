namespace Narudžba
{
    partial class FormMjesto
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
            this.listViewMjesto = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IzmijeniMjesto = new System.Windows.Forms.Button();
            this.buttonObrišiMjesto = new System.Windows.Forms.Button();
            this.buttonOsvježiPodatke = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPretragaNaziv = new System.Windows.Forms.Button();
            this.textBoxNazivMjesta = new System.Windows.Forms.TextBox();
            this.buttonPretraži = new System.Windows.Forms.Button();
            this.textBoxMjesto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewMjesto
            // 
            this.listViewMjesto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewMjesto.HideSelection = false;
            this.listViewMjesto.Location = new System.Drawing.Point(34, 27);
            this.listViewMjesto.Name = "listViewMjesto";
            this.listViewMjesto.Size = new System.Drawing.Size(164, 375);
            this.listViewMjesto.TabIndex = 8;
            this.listViewMjesto.UseCompatibleStateImageBehavior = false;
            this.listViewMjesto.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MjestoID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naziv";
            this.columnHeader2.Width = 102;
            // 
            // IzmijeniMjesto
            // 
            this.IzmijeniMjesto.BackColor = System.Drawing.Color.White;
            this.IzmijeniMjesto.Location = new System.Drawing.Point(232, 174);
            this.IzmijeniMjesto.Name = "IzmijeniMjesto";
            this.IzmijeniMjesto.Size = new System.Drawing.Size(88, 47);
            this.IzmijeniMjesto.TabIndex = 11;
            this.IzmijeniMjesto.Text = "Izmijeni";
            this.IzmijeniMjesto.UseVisualStyleBackColor = false;
            this.IzmijeniMjesto.Click += new System.EventHandler(this.IzmijeniMjesto_Click);
            // 
            // buttonObrišiMjesto
            // 
            this.buttonObrišiMjesto.BackColor = System.Drawing.Color.White;
            this.buttonObrišiMjesto.Location = new System.Drawing.Point(232, 98);
            this.buttonObrišiMjesto.Name = "buttonObrišiMjesto";
            this.buttonObrišiMjesto.Size = new System.Drawing.Size(88, 47);
            this.buttonObrišiMjesto.TabIndex = 12;
            this.buttonObrišiMjesto.Text = "Obriši";
            this.buttonObrišiMjesto.UseVisualStyleBackColor = false;
            this.buttonObrišiMjesto.Click += new System.EventHandler(this.buttonObrišiMjesto_Click_1);
            // 
            // buttonOsvježiPodatke
            // 
            this.buttonOsvježiPodatke.BackColor = System.Drawing.Color.White;
            this.buttonOsvježiPodatke.Location = new System.Drawing.Point(232, 27);
            this.buttonOsvježiPodatke.Name = "buttonOsvježiPodatke";
            this.buttonOsvježiPodatke.Size = new System.Drawing.Size(88, 47);
            this.buttonOsvježiPodatke.TabIndex = 13;
            this.buttonOsvježiPodatke.Text = "Osvježi podatke";
            this.buttonOsvježiPodatke.UseVisualStyleBackColor = false;
            this.buttonOsvježiPodatke.Click += new System.EventHandler(this.buttonOsvježiPodatke_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonPretragaNaziv);
            this.panel1.Controls.Add(this.textBoxNazivMjesta);
            this.panel1.Controls.Add(this.buttonPretraži);
            this.panel1.Controls.Add(this.textBoxMjesto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(34, 422);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 179);
            this.panel1.TabIndex = 10;
            // 
            // buttonPretragaNaziv
            // 
            this.buttonPretragaNaziv.BackColor = System.Drawing.Color.Magenta;
            this.buttonPretragaNaziv.Location = new System.Drawing.Point(329, 103);
            this.buttonPretragaNaziv.Name = "buttonPretragaNaziv";
            this.buttonPretragaNaziv.Size = new System.Drawing.Size(92, 52);
            this.buttonPretragaNaziv.TabIndex = 4;
            this.buttonPretragaNaziv.Text = "Pretraži";
            this.buttonPretragaNaziv.UseVisualStyleBackColor = false;
            this.buttonPretragaNaziv.Click += new System.EventHandler(this.buttonPretragaNaziv_Click);
            // 
            // textBoxNazivMjesta
            // 
            this.textBoxNazivMjesta.Location = new System.Drawing.Point(337, 56);
            this.textBoxNazivMjesta.Name = "textBoxNazivMjesta";
            this.textBoxNazivMjesta.Size = new System.Drawing.Size(81, 20);
            this.textBoxNazivMjesta.TabIndex = 3;
            this.textBoxNazivMjesta.Text = "Naziv";
            this.textBoxNazivMjesta.TextChanged += new System.EventHandler(this.textBoxNazivMjesta_TextChanged);
            this.textBoxNazivMjesta.Enter += new System.EventHandler(this.textBoxNazivMjesta_Enter);
            this.textBoxNazivMjesta.Leave += new System.EventHandler(this.textBoxNazivMjesta_Leave);
            // 
            // buttonPretraži
            // 
            this.buttonPretraži.BackColor = System.Drawing.Color.Cyan;
            this.buttonPretraži.Location = new System.Drawing.Point(25, 103);
            this.buttonPretraži.Name = "buttonPretraži";
            this.buttonPretraži.Size = new System.Drawing.Size(92, 52);
            this.buttonPretraži.TabIndex = 2;
            this.buttonPretraži.Text = "Pretraži";
            this.buttonPretraži.UseVisualStyleBackColor = false;
            this.buttonPretraži.Click += new System.EventHandler(this.buttonPretraži_Click_1);
            // 
            // textBoxMjesto
            // 
            this.textBoxMjesto.Location = new System.Drawing.Point(25, 56);
            this.textBoxMjesto.Name = "textBoxMjesto";
            this.textBoxMjesto.Size = new System.Drawing.Size(81, 20);
            this.textBoxMjesto.TabIndex = 1;
            this.textBoxMjesto.Text = "Id mjesta";
            this.textBoxMjesto.TextChanged += new System.EventHandler(this.textBoxMjesto_TextChanged_1);
            this.textBoxMjesto.Enter += new System.EventHandler(this.textBoxMjesto_Enter);
            this.textBoxMjesto.Leave += new System.EventHandler(this.textBoxMjesto_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pretraga podataka";
            // 
            // FormMjesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(479, 627);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewMjesto);
            this.Controls.Add(this.IzmijeniMjesto);
            this.Controls.Add(this.buttonObrišiMjesto);
            this.Controls.Add(this.buttonOsvježiPodatke);
            this.Name = "FormMjesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mjesta";
            this.Load += new System.EventHandler(this.FormMjesto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewMjesto;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button IzmijeniMjesto;
        private System.Windows.Forms.Button buttonObrišiMjesto;
        private System.Windows.Forms.Button buttonOsvježiPodatke;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPretraži;
        private System.Windows.Forms.TextBox textBoxMjesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNazivMjesta;
        private System.Windows.Forms.Button buttonPretragaNaziv;
    }
}