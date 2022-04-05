namespace Narudžba
{
    partial class FormDodavanjeProizvoda
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
            this.textBoxPdvStopa = new System.Windows.Forms.TextBox();
            this.textBoxCijena = new System.Windows.Forms.TextBox();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.labelPdvStopa = new System.Windows.Forms.Label();
            this.labelCijena = new System.Windows.Forms.Label();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.buttonUnesiProizvod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPdvStopa
            // 
            this.textBoxPdvStopa.Location = new System.Drawing.Point(128, 121);
            this.textBoxPdvStopa.Name = "textBoxPdvStopa";
            this.textBoxPdvStopa.Size = new System.Drawing.Size(100, 20);
            this.textBoxPdvStopa.TabIndex = 35;
            this.textBoxPdvStopa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPdvStopa_KeyPress);
            // 
            // textBoxCijena
            // 
            this.textBoxCijena.Location = new System.Drawing.Point(128, 74);
            this.textBoxCijena.Name = "textBoxCijena";
            this.textBoxCijena.Size = new System.Drawing.Size(100, 20);
            this.textBoxCijena.TabIndex = 34;
            this.textBoxCijena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCijena_KeyPress);
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(128, 28);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(100, 20);
            this.textBoxNaziv.TabIndex = 33;
            this.textBoxNaziv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNaziv_KeyPress);
            // 
            // labelPdvStopa
            // 
            this.labelPdvStopa.AutoSize = true;
            this.labelPdvStopa.Location = new System.Drawing.Point(14, 128);
            this.labelPdvStopa.Name = "labelPdvStopa";
            this.labelPdvStopa.Size = new System.Drawing.Size(55, 13);
            this.labelPdvStopa.TabIndex = 31;
            this.labelPdvStopa.Text = "Pdv stopa";
            // 
            // labelCijena
            // 
            this.labelCijena.AutoSize = true;
            this.labelCijena.Location = new System.Drawing.Point(14, 81);
            this.labelCijena.Name = "labelCijena";
            this.labelCijena.Size = new System.Drawing.Size(36, 13);
            this.labelCijena.TabIndex = 30;
            this.labelCijena.Text = "Cijena";
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(14, 35);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(34, 13);
            this.labelNaziv.TabIndex = 29;
            this.labelNaziv.Text = "Naziv";
            // 
            // buttonUnesiProizvod
            // 
            this.buttonUnesiProizvod.Location = new System.Drawing.Point(128, 175);
            this.buttonUnesiProizvod.Name = "buttonUnesiProizvod";
            this.buttonUnesiProizvod.Size = new System.Drawing.Size(111, 40);
            this.buttonUnesiProizvod.TabIndex = 36;
            this.buttonUnesiProizvod.Text = "Unesi proizvod";
            this.buttonUnesiProizvod.UseVisualStyleBackColor = true;
            this.buttonUnesiProizvod.Click += new System.EventHandler(this.buttonUnesiProizvod_Click);
            // 
            // FormDodavanjeProizvoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(332, 273);
            this.Controls.Add(this.buttonUnesiProizvod);
            this.Controls.Add(this.textBoxPdvStopa);
            this.Controls.Add(this.textBoxCijena);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.labelPdvStopa);
            this.Controls.Add(this.labelCijena);
            this.Controls.Add(this.labelNaziv);
            this.Name = "FormDodavanjeProizvoda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava novih proizvoda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPdvStopa;
        private System.Windows.Forms.TextBox textBoxCijena;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.Label labelPdvStopa;
        private System.Windows.Forms.Label labelCijena;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.Button buttonUnesiProizvod;
    }
}