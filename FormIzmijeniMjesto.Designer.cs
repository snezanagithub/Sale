namespace Narudžba
{
    partial class FormIzmijeniMjesto
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
            this.buttonIzmijeniMjesto = new System.Windows.Forms.Button();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.textBoxMjestoId = new System.Windows.Forms.TextBox();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.labelMjestoId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonIzmijeniMjesto
            // 
            this.buttonIzmijeniMjesto.BackColor = System.Drawing.Color.Snow;
            this.buttonIzmijeniMjesto.Location = new System.Drawing.Point(113, 131);
            this.buttonIzmijeniMjesto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIzmijeniMjesto.Name = "buttonIzmijeniMjesto";
            this.buttonIzmijeniMjesto.Size = new System.Drawing.Size(111, 29);
            this.buttonIzmijeniMjesto.TabIndex = 101;
            this.buttonIzmijeniMjesto.Text = "Izmijeni podatke";
            this.buttonIzmijeniMjesto.UseVisualStyleBackColor = false;
            this.buttonIzmijeniMjesto.Click += new System.EventHandler(this.buttonIzmijeniMjesto_Click);
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(102, 80);
            this.textBoxNaziv.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(132, 20);
            this.textBoxNaziv.TabIndex = 100;
            this.textBoxNaziv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNaziv_KeyPress);
            // 
            // textBoxMjestoId
            // 
            this.textBoxMjestoId.Location = new System.Drawing.Point(102, 43);
            this.textBoxMjestoId.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMjestoId.Name = "textBoxMjestoId";
            this.textBoxMjestoId.Size = new System.Drawing.Size(132, 20);
            this.textBoxMjestoId.TabIndex = 99;
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(17, 87);
            this.labelNaziv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(34, 13);
            this.labelNaziv.TabIndex = 98;
            this.labelNaziv.Text = "Naziv";
            // 
            // labelMjestoId
            // 
            this.labelMjestoId.AutoSize = true;
            this.labelMjestoId.Location = new System.Drawing.Point(17, 50);
            this.labelMjestoId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMjestoId.Name = "labelMjestoId";
            this.labelMjestoId.Size = new System.Drawing.Size(47, 13);
            this.labelMjestoId.TabIndex = 97;
            this.labelMjestoId.Text = "MjestoId";
            // 
            // FormIzmijeniMjesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(311, 198);
            this.Controls.Add(this.buttonIzmijeniMjesto);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.textBoxMjestoId);
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.labelMjestoId);
            this.Name = "FormIzmijeniMjesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izmijeni Mjesto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIzmijeniMjesto;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.TextBox textBoxMjestoId;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.Label labelMjestoId;
    }
}