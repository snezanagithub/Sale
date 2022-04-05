namespace Narudžba
{
    partial class FormLogin
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonIzađi = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxŠifra = new System.Windows.Forms.TextBox();
            this.textBoxKorisničkoIme = new System.Windows.Forms.TextBox();
            this.labelŠifra = new System.Windows.Forms.Label();
            this.labelKorisničkoIme = new System.Windows.Forms.Label();
            this.buttonRegistrujSe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Narudžba.Properties.Resources.преузимање2;
            this.pictureBox2.Location = new System.Drawing.Point(675, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(227, 187);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Narudžba.Properties.Resources.users_man_woman_512;
            this.pictureBox1.Location = new System.Drawing.Point(48, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(513, 444);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // buttonIzađi
            // 
            this.buttonIzađi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonIzađi.Location = new System.Drawing.Point(971, 442);
            this.buttonIzađi.Name = "buttonIzađi";
            this.buttonIzađi.Size = new System.Drawing.Size(111, 48);
            this.buttonIzađi.TabIndex = 12;
            this.buttonIzađi.Text = "Izađi";
            this.buttonIzađi.UseVisualStyleBackColor = true;
            this.buttonIzađi.Click += new System.EventHandler(this.buttonIzađi_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogin.Location = new System.Drawing.Point(889, 366);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(111, 48);
            this.buttonLogin.TabIndex = 11;
            this.buttonLogin.Text = "Uloguj se";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxŠifra
            // 
            this.textBoxŠifra.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxŠifra.Location = new System.Drawing.Point(899, 309);
            this.textBoxŠifra.Multiline = true;
            this.textBoxŠifra.Name = "textBoxŠifra";
            this.textBoxŠifra.Size = new System.Drawing.Size(251, 33);
            this.textBoxŠifra.TabIndex = 10;
            this.textBoxŠifra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
   //         this.textBoxŠifra.TextChanged += new System.EventHandler(this.textBoxŠifra_TextChanged);
            // 
            // textBoxKorisničkoIme
            // 
            this.textBoxKorisničkoIme.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKorisničkoIme.Location = new System.Drawing.Point(899, 234);
            this.textBoxKorisničkoIme.Multiline = true;
            this.textBoxKorisničkoIme.Name = "textBoxKorisničkoIme";
            this.textBoxKorisničkoIme.Size = new System.Drawing.Size(251, 33);
            this.textBoxKorisničkoIme.TabIndex = 9;
            this.textBoxKorisničkoIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
   //         this.textBoxKorisničkoIme.TextChanged += new System.EventHandler(this.textBoxKorisničkoIme_TextChanged);
            // 
            // labelŠifra
            // 
            this.labelŠifra.AutoSize = true;
            this.labelŠifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelŠifra.Location = new System.Drawing.Point(671, 318);
            this.labelŠifra.Name = "labelŠifra";
            this.labelŠifra.Size = new System.Drawing.Size(46, 24);
            this.labelŠifra.TabIndex = 8;
            this.labelŠifra.Text = "Šifra";
            // 
            // labelKorisničkoIme
            // 
            this.labelKorisničkoIme.AutoSize = true;
            this.labelKorisničkoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKorisničkoIme.Location = new System.Drawing.Point(671, 237);
            this.labelKorisničkoIme.Name = "labelKorisničkoIme";
            this.labelKorisničkoIme.Size = new System.Drawing.Size(133, 24);
            this.labelKorisničkoIme.TabIndex = 7;
            this.labelKorisničkoIme.Text = "Korisničko ime";
            // 
            // buttonRegistrujSe
            // 
            this.buttonRegistrujSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonRegistrujSe.Location = new System.Drawing.Point(1039, 366);
            this.buttonRegistrujSe.Name = "buttonRegistrujSe";
            this.buttonRegistrujSe.Size = new System.Drawing.Size(111, 48);
            this.buttonRegistrujSe.TabIndex = 13;
            this.buttonRegistrujSe.Text = "Registruj se";
            this.buttonRegistrujSe.UseVisualStyleBackColor = true;
            this.buttonRegistrujSe.Click += new System.EventHandler(this.buttonRegistrujSe_Click_1);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.buttonRegistrujSe);
            this.Controls.Add(this.labelŠifra);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonIzađi);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBoxŠifra);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxKorisničkoIme);
            this.Controls.Add(this.labelKorisničkoIme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
      //      this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonIzađi;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxŠifra;
        private System.Windows.Forms.TextBox textBoxKorisničkoIme;
        private System.Windows.Forms.Label labelŠifra;
        private System.Windows.Forms.Label labelKorisničkoIme;
        private System.Windows.Forms.Button buttonRegistrujSe;
    }
}