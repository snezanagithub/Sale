namespace Narudžba
{
    partial class FormDodavanjeMjesta
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
            this.textBoxNazivMjesta = new System.Windows.Forms.TextBox();
            this.labelNazivMjesta = new System.Windows.Forms.Label();
            this.buttonPrijaviNovoMjesto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNazivMjesta
            // 
            this.textBoxNazivMjesta.Location = new System.Drawing.Point(138, 54);
            this.textBoxNazivMjesta.Name = "textBoxNazivMjesta";
            this.textBoxNazivMjesta.Size = new System.Drawing.Size(97, 20);
            this.textBoxNazivMjesta.TabIndex = 3;
            this.textBoxNazivMjesta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNazivMjesta_KeyPress);
            // 
            // labelNazivMjesta
            // 
            this.labelNazivMjesta.AutoSize = true;
            this.labelNazivMjesta.Location = new System.Drawing.Point(21, 57);
            this.labelNazivMjesta.Name = "labelNazivMjesta";
            this.labelNazivMjesta.Size = new System.Drawing.Size(67, 13);
            this.labelNazivMjesta.TabIndex = 2;
            this.labelNazivMjesta.Text = "Naziv mjesta";
            // 
            // buttonPrijaviNovoMjesto
            // 
            this.buttonPrijaviNovoMjesto.Location = new System.Drawing.Point(119, 134);
            this.buttonPrijaviNovoMjesto.Name = "buttonPrijaviNovoMjesto";
            this.buttonPrijaviNovoMjesto.Size = new System.Drawing.Size(116, 35);
            this.buttonPrijaviNovoMjesto.TabIndex = 4;
            this.buttonPrijaviNovoMjesto.Text = "Prijavi novo mjesto";
            this.buttonPrijaviNovoMjesto.UseVisualStyleBackColor = true;
            this.buttonPrijaviNovoMjesto.Click += new System.EventHandler(this.buttonPrijaviNovoMjesto_Click);
            // 
            // FormDodavanjeMjesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(326, 227);
            this.Controls.Add(this.buttonPrijaviNovoMjesto);
            this.Controls.Add(this.textBoxNazivMjesta);
            this.Controls.Add(this.labelNazivMjesta);
            this.Name = "FormDodavanjeMjesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje novih mjesta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNazivMjesta;
        private System.Windows.Forms.Label labelNazivMjesta;
        private System.Windows.Forms.Button buttonPrijaviNovoMjesto;
    }
}