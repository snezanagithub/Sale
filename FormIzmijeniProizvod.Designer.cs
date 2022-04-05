namespace Narudžba
{
    partial class FormIzmijeniProizvod
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
            this.buttonIzmijeniProizvod = new System.Windows.Forms.Button();
            this.textBoxPdvStopa = new System.Windows.Forms.TextBox();
            this.textBoxCijena = new System.Windows.Forms.TextBox();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.labelPdvStopa = new System.Windows.Forms.Label();
            this.labelCijena = new System.Windows.Forms.Label();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.textBoxProizvodId = new System.Windows.Forms.TextBox();
            this.labelProizvodIdIzmjena = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonIzmijeniProizvod
            // 
            this.buttonIzmijeniProizvod.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonIzmijeniProizvod.Location = new System.Drawing.Point(150, 225);
            this.buttonIzmijeniProizvod.Name = "buttonIzmijeniProizvod";
            this.buttonIzmijeniProizvod.Size = new System.Drawing.Size(117, 29);
            this.buttonIzmijeniProizvod.TabIndex = 45;
            this.buttonIzmijeniProizvod.Text = "Izmijeni proizvod";
            this.buttonIzmijeniProizvod.UseVisualStyleBackColor = false;
            this.buttonIzmijeniProizvod.Click += new System.EventHandler(this.buttonIzmijeniProizvod_Click);
            // 
            // textBoxPdvStopa
            // 
            this.textBoxPdvStopa.Location = new System.Drawing.Point(167, 169);
            this.textBoxPdvStopa.Name = "textBoxPdvStopa";
            this.textBoxPdvStopa.Size = new System.Drawing.Size(100, 20);
            this.textBoxPdvStopa.TabIndex = 41;
            this.textBoxPdvStopa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPdvStopa_KeyPress);
            // 
            // textBoxCijena
            // 
            this.textBoxCijena.Location = new System.Drawing.Point(167, 123);
            this.textBoxCijena.Name = "textBoxCijena";
            this.textBoxCijena.Size = new System.Drawing.Size(100, 20);
            this.textBoxCijena.TabIndex = 40;
            this.textBoxCijena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCijena_KeyPress);
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(167, 73);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(100, 20);
            this.textBoxNaziv.TabIndex = 39;
            this.textBoxNaziv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNaziv_KeyPress);
            // 
            // labelPdvStopa
            // 
            this.labelPdvStopa.AutoSize = true;
            this.labelPdvStopa.Location = new System.Drawing.Point(27, 172);
            this.labelPdvStopa.Name = "labelPdvStopa";
            this.labelPdvStopa.Size = new System.Drawing.Size(55, 13);
            this.labelPdvStopa.TabIndex = 35;
            this.labelPdvStopa.Text = "Pdv stopa";
            // 
            // labelCijena
            // 
            this.labelCijena.AutoSize = true;
            this.labelCijena.Location = new System.Drawing.Point(27, 126);
            this.labelCijena.Name = "labelCijena";
            this.labelCijena.Size = new System.Drawing.Size(36, 13);
            this.labelCijena.TabIndex = 34;
            this.labelCijena.Text = "Cijena";
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(27, 80);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(34, 13);
            this.labelNaziv.TabIndex = 33;
            this.labelNaziv.Text = "Naziv";
            // 
            // textBoxProizvodId
            // 
            this.textBoxProizvodId.Location = new System.Drawing.Point(167, 24);
            this.textBoxProizvodId.Multiline = true;
            this.textBoxProizvodId.Name = "textBoxProizvodId";
            this.textBoxProizvodId.Size = new System.Drawing.Size(100, 21);
            this.textBoxProizvodId.TabIndex = 32;
            // 
            // labelProizvodIdIzmjena
            // 
            this.labelProizvodIdIzmjena.AutoSize = true;
            this.labelProizvodIdIzmjena.Location = new System.Drawing.Point(27, 32);
            this.labelProizvodIdIzmjena.Name = "labelProizvodIdIzmjena";
            this.labelProizvodIdIzmjena.Size = new System.Drawing.Size(57, 13);
            this.labelProizvodIdIzmjena.TabIndex = 31;
            this.labelProizvodIdIzmjena.Text = "ProizvodId";
            // 
            // FormIzmijeniProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(320, 315);
            this.Controls.Add(this.buttonIzmijeniProizvod);
            this.Controls.Add(this.textBoxPdvStopa);
            this.Controls.Add(this.textBoxCijena);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.labelPdvStopa);
            this.Controls.Add(this.labelCijena);
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.textBoxProizvodId);
            this.Controls.Add(this.labelProizvodIdIzmjena);
            this.Name = "FormIzmijeniProizvod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izmijeni Proizvod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIzmijeniProizvod;
        private System.Windows.Forms.TextBox textBoxPdvStopa;
        private System.Windows.Forms.TextBox textBoxCijena;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.Label labelPdvStopa;
        private System.Windows.Forms.Label labelCijena;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.TextBox textBoxProizvodId;
        private System.Windows.Forms.Label labelProizvodIdIzmjena;
    }
}