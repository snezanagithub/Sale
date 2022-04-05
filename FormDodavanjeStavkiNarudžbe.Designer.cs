namespace Narudžba
{
    partial class FormDodavanjeStavkiNarudžbe
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
            this.textBoxCijena = new System.Windows.Forms.TextBox();
            this.labelCijena = new System.Windows.Forms.Label();
            this.textBoxKoličina = new System.Windows.Forms.TextBox();
            this.labelKoličina = new System.Windows.Forms.Label();
            this.labelProizvodID = new System.Windows.Forms.Label();
            this.labelNarudžbaID = new System.Windows.Forms.Label();
            this.buttonUnesiStavkuNarudžbe = new System.Windows.Forms.Button();
            this.comboBoxNarudžbaID = new System.Windows.Forms.ComboBox();
            this.comboBoxProizvodID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxCijena
            // 
            this.textBoxCijena.Location = new System.Drawing.Point(236, 166);
            this.textBoxCijena.Name = "textBoxCijena";
            this.textBoxCijena.Size = new System.Drawing.Size(112, 20);
            this.textBoxCijena.TabIndex = 23;
            this.textBoxCijena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCijena_KeyPress);
            // 
            // labelCijena
            // 
            this.labelCijena.AutoSize = true;
            this.labelCijena.Location = new System.Drawing.Point(19, 173);
            this.labelCijena.Name = "labelCijena";
            this.labelCijena.Size = new System.Drawing.Size(36, 13);
            this.labelCijena.TabIndex = 22;
            this.labelCijena.Text = "Cijena";
            // 
            // textBoxKoličina
            // 
            this.textBoxKoličina.Location = new System.Drawing.Point(236, 125);
            this.textBoxKoličina.Name = "textBoxKoličina";
            this.textBoxKoličina.Size = new System.Drawing.Size(112, 20);
            this.textBoxKoličina.TabIndex = 21;
            this.textBoxKoličina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKoličina_KeyPress);
            // 
            // labelKoličina
            // 
            this.labelKoličina.AutoSize = true;
            this.labelKoličina.Location = new System.Drawing.Point(19, 132);
            this.labelKoličina.Name = "labelKoličina";
            this.labelKoličina.Size = new System.Drawing.Size(44, 13);
            this.labelKoličina.TabIndex = 17;
            this.labelKoličina.Text = "Količina";
            // 
            // labelProizvodID
            // 
            this.labelProizvodID.AutoSize = true;
            this.labelProizvodID.Location = new System.Drawing.Point(19, 85);
            this.labelProizvodID.Name = "labelProizvodID";
            this.labelProizvodID.Size = new System.Drawing.Size(59, 13);
            this.labelProizvodID.TabIndex = 16;
            this.labelProizvodID.Text = "ProizvodID";
            // 
            // labelNarudžbaID
            // 
            this.labelNarudžbaID.AutoSize = true;
            this.labelNarudžbaID.Location = new System.Drawing.Point(19, 39);
            this.labelNarudžbaID.Name = "labelNarudžbaID";
            this.labelNarudžbaID.Size = new System.Drawing.Size(62, 13);
            this.labelNarudžbaID.TabIndex = 15;
            this.labelNarudžbaID.Text = "NarudžbaId";
            // 
            // buttonUnesiStavkuNarudžbe
            // 
            this.buttonUnesiStavkuNarudžbe.Location = new System.Drawing.Point(226, 223);
            this.buttonUnesiStavkuNarudžbe.Name = "buttonUnesiStavkuNarudžbe";
            this.buttonUnesiStavkuNarudžbe.Size = new System.Drawing.Size(133, 51);
            this.buttonUnesiStavkuNarudžbe.TabIndex = 24;
            this.buttonUnesiStavkuNarudžbe.Text = "Unesi novu stavku narudžbe";
            this.buttonUnesiStavkuNarudžbe.UseVisualStyleBackColor = true;
            this.buttonUnesiStavkuNarudžbe.Click += new System.EventHandler(this.buttonUnesiStavkuNarudžbe_Click);
            // 
            // comboBoxNarudžbaID
            // 
            this.comboBoxNarudžbaID.FormattingEnabled = true;
            this.comboBoxNarudžbaID.Location = new System.Drawing.Point(236, 31);
            this.comboBoxNarudžbaID.Name = "comboBoxNarudžbaID";
            this.comboBoxNarudžbaID.Size = new System.Drawing.Size(112, 21);
            this.comboBoxNarudžbaID.TabIndex = 25;
            // 
            // comboBoxProizvodID
            // 
            this.comboBoxProizvodID.FormattingEnabled = true;
            this.comboBoxProizvodID.Location = new System.Drawing.Point(236, 77);
            this.comboBoxProizvodID.Name = "comboBoxProizvodID";
            this.comboBoxProizvodID.Size = new System.Drawing.Size(112, 21);
            this.comboBoxProizvodID.TabIndex = 26;
            // 
            // FormDodavanjeStavkiNarudžbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(428, 330);
            this.Controls.Add(this.comboBoxProizvodID);
            this.Controls.Add(this.comboBoxNarudžbaID);
            this.Controls.Add(this.buttonUnesiStavkuNarudžbe);
            this.Controls.Add(this.textBoxCijena);
            this.Controls.Add(this.labelCijena);
            this.Controls.Add(this.textBoxKoličina);
            this.Controls.Add(this.labelKoličina);
            this.Controls.Add(this.labelProizvodID);
            this.Controls.Add(this.labelNarudžbaID);
            this.Name = "FormDodavanjeStavkiNarudžbe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava novih stavki narudžbe";
            this.Load += new System.EventHandler(this.FormDodavanjeStavkiNarudžbe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxCijena;
        private System.Windows.Forms.Label labelCijena;
        private System.Windows.Forms.TextBox textBoxKoličina;
        private System.Windows.Forms.Label labelKoličina;
        private System.Windows.Forms.Label labelProizvodID;
        private System.Windows.Forms.Label labelNarudžbaID;
        private System.Windows.Forms.Button buttonUnesiStavkuNarudžbe;
        private System.Windows.Forms.ComboBox comboBoxNarudžbaID;
        private System.Windows.Forms.ComboBox comboBoxProizvodID;
    }
}