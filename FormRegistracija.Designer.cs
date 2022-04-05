namespace Narudžba
{
    partial class FormRegistracija
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
            this.labelKorisničkoIme = new System.Windows.Forms.Label();
            this.textBoxKorisničkoIme = new System.Windows.Forms.TextBox();
            this.labelŠifra = new System.Windows.Forms.Label();
            this.labelIme = new System.Windows.Forms.Label();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxŠifra = new System.Windows.Forms.MaskedTextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.buttonRegistrujSe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelKorisničkoIme
            // 
            this.labelKorisničkoIme.AutoSize = true;
            this.labelKorisničkoIme.Location = new System.Drawing.Point(31, 57);
            this.labelKorisničkoIme.Name = "labelKorisničkoIme";
            this.labelKorisničkoIme.Size = new System.Drawing.Size(75, 13);
            this.labelKorisničkoIme.TabIndex = 0;
            this.labelKorisničkoIme.Text = "Korisničko ime";
            // 
            // textBoxKorisničkoIme
            // 
            this.textBoxKorisničkoIme.Location = new System.Drawing.Point(141, 54);
            this.textBoxKorisničkoIme.Name = "textBoxKorisničkoIme";
            this.textBoxKorisničkoIme.Size = new System.Drawing.Size(105, 20);
            this.textBoxKorisničkoIme.TabIndex = 1;
            // 
            // labelŠifra
            // 
            this.labelŠifra.AutoSize = true;
            this.labelŠifra.Location = new System.Drawing.Point(31, 110);
            this.labelŠifra.Name = "labelŠifra";
            this.labelŠifra.Size = new System.Drawing.Size(28, 13);
            this.labelŠifra.TabIndex = 2;
            this.labelŠifra.Text = "Šifra";
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(31, 154);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(24, 13);
            this.labelIme.TabIndex = 3;
            this.labelIme.Text = "Ime";
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Location = new System.Drawing.Point(31, 198);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(44, 13);
            this.labelPrezime.TabIndex = 4;
            this.labelPrezime.Text = "Prezime";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(31, 241);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email";
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(141, 147);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(105, 20);
            this.textBoxIme.TabIndex = 6;
            this.textBoxIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIme_KeyPress);
            // 
            // textBoxŠifra
            // 
            this.textBoxŠifra.Location = new System.Drawing.Point(141, 103);
            this.textBoxŠifra.Name = "textBoxŠifra";
            this.textBoxŠifra.Size = new System.Drawing.Size(105, 20);
            this.textBoxŠifra.TabIndex = 7;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(141, 191);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(105, 20);
            this.textBoxPrezime.TabIndex = 8;
            this.textBoxPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrezime_KeyPress);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(141, 234);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(105, 20);
            this.textBoxEmail.TabIndex = 9;
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.Location = new System.Drawing.Point(79, 325);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(75, 23);
            this.buttonOdustani.TabIndex = 10;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = true;
            this.buttonOdustani.Click += new System.EventHandler(this.buttonOdustani_Click);
            // 
            // buttonRegistrujSe
            // 
            this.buttonRegistrujSe.Location = new System.Drawing.Point(205, 325);
            this.buttonRegistrujSe.Name = "buttonRegistrujSe";
            this.buttonRegistrujSe.Size = new System.Drawing.Size(75, 23);
            this.buttonRegistrujSe.TabIndex = 11;
            this.buttonRegistrujSe.Text = "Registruj se ";
            this.buttonRegistrujSe.UseVisualStyleBackColor = true;
            this.buttonRegistrujSe.Click += new System.EventHandler(this.buttonRegistrujSe_Click);
            // 
            // FormRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(416, 441);
            this.Controls.Add(this.buttonRegistrujSe);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxŠifra);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPrezime);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.labelŠifra);
            this.Controls.Add(this.textBoxKorisničkoIme);
            this.Controls.Add(this.labelKorisničkoIme);
            this.Name = "FormRegistracija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registracija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKorisničkoIme;
        private System.Windows.Forms.TextBox textBoxKorisničkoIme;
        private System.Windows.Forms.Label labelŠifra;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.MaskedTextBox textBoxŠifra;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonOdustani;
        private System.Windows.Forms.Button buttonRegistrujSe;
    }
}