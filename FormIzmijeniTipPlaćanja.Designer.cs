namespace Narudžba
{
    partial class FormIzmijeniTipPlaćanja
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
            this.textBoxTipPlaćanjaID = new System.Windows.Forms.TextBox();
            this.labelIdTipaPlaćanja = new System.Windows.Forms.Label();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.buttonIzmijeniTipPlaćanja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTipPlaćanjaID
            // 
            this.textBoxTipPlaćanjaID.Enabled = false;
            this.textBoxTipPlaćanjaID.Location = new System.Drawing.Point(183, 30);
            this.textBoxTipPlaćanjaID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTipPlaćanjaID.Name = "textBoxTipPlaćanjaID";
            this.textBoxTipPlaćanjaID.Size = new System.Drawing.Size(132, 20);
            this.textBoxTipPlaćanjaID.TabIndex = 91;
            // 
            // labelIdTipaPlaćanja
            // 
            this.labelIdTipaPlaćanja.AutoSize = true;
            this.labelIdTipaPlaćanja.Location = new System.Drawing.Point(34, 37);
            this.labelIdTipaPlaćanja.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIdTipaPlaćanja.Name = "labelIdTipaPlaćanja";
            this.labelIdTipaPlaćanja.Size = new System.Drawing.Size(79, 13);
            this.labelIdTipaPlaćanja.TabIndex = 93;
            this.labelIdTipaPlaćanja.Text = "Id tipa plaćanja";
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(183, 69);
            this.textBoxNaziv.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(132, 20);
            this.textBoxNaziv.TabIndex = 94;
            this.textBoxNaziv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNaziv_KeyPress);
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(34, 76);
            this.labelNaziv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(34, 13);
            this.labelNaziv.TabIndex = 92;
            this.labelNaziv.Text = "Naziv";
            // 
            // buttonIzmijeniTipPlaćanja
            // 
            this.buttonIzmijeniTipPlaćanja.Location = new System.Drawing.Point(183, 118);
            this.buttonIzmijeniTipPlaćanja.Name = "buttonIzmijeniTipPlaćanja";
            this.buttonIzmijeniTipPlaćanja.Size = new System.Drawing.Size(132, 38);
            this.buttonIzmijeniTipPlaćanja.TabIndex = 95;
            this.buttonIzmijeniTipPlaćanja.Text = "Izmijeni tip plaćanja";
            this.buttonIzmijeniTipPlaćanja.UseVisualStyleBackColor = true;
            this.buttonIzmijeniTipPlaćanja.Click += new System.EventHandler(this.buttonIzmijeniTipPlaćanja_Click_1);
            // 
            // FormIzmijeniTipPlaćanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(453, 188);
            this.Controls.Add(this.buttonIzmijeniTipPlaćanja);
            this.Controls.Add(this.textBoxTipPlaćanjaID);
            this.Controls.Add(this.labelIdTipaPlaćanja);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.labelNaziv);
            this.Name = "FormIzmijeniTipPlaćanja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izmijeni Tip Plaćanja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTipPlaćanjaID;
        private System.Windows.Forms.Label labelIdTipaPlaćanja;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.Button buttonIzmijeniTipPlaćanja;
    }
}