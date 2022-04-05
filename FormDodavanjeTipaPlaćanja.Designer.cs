namespace Narudžba
{
    partial class FormDodavanjeTipaPlaćanja
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
            this.textBoxNazivId = new System.Windows.Forms.TextBox();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.buttonUnesiNoviTipPlaćanja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNazivId
            // 
            this.textBoxNazivId.Location = new System.Drawing.Point(232, 34);
            this.textBoxNazivId.Name = "textBoxNazivId";
            this.textBoxNazivId.Size = new System.Drawing.Size(112, 20);
            this.textBoxNazivId.TabIndex = 23;
            this.textBoxNazivId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNazivId_KeyPress);
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(15, 41);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(34, 13);
            this.labelNaziv.TabIndex = 21;
            this.labelNaziv.Text = "Naziv";
            // 
            // buttonUnesiNoviTipPlaćanja
            // 
            this.buttonUnesiNoviTipPlaćanja.Location = new System.Drawing.Point(204, 73);
            this.buttonUnesiNoviTipPlaćanja.Name = "buttonUnesiNoviTipPlaćanja";
            this.buttonUnesiNoviTipPlaćanja.Size = new System.Drawing.Size(165, 45);
            this.buttonUnesiNoviTipPlaćanja.TabIndex = 24;
            this.buttonUnesiNoviTipPlaćanja.Text = "Unesi novi tip plaćanja";
            this.buttonUnesiNoviTipPlaćanja.UseVisualStyleBackColor = true;
            this.buttonUnesiNoviTipPlaćanja.Click += new System.EventHandler(this.buttonUnesiNoviTipPlaćanja_Click);
            // 
            // FormDodavanjeTipaPlaćanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(459, 171);
            this.Controls.Add(this.buttonUnesiNoviTipPlaćanja);
            this.Controls.Add(this.textBoxNazivId);
            this.Controls.Add(this.labelNaziv);
            this.Name = "FormDodavanjeTipaPlaćanja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava novih tipova plaćanja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNazivId;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.Button buttonUnesiNoviTipPlaćanja;
    }
}