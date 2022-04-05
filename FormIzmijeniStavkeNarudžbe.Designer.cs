namespace Narudžba
{
    partial class FormIzmijeniStavkeNarudžbe
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
            this.textBoxKoličina = new System.Windows.Forms.TextBox();
            this.labelCijena = new System.Windows.Forms.Label();
            this.labelKoličina = new System.Windows.Forms.Label();
            this.labelImeProizvodID = new System.Windows.Forms.Label();
            this.labelNarudžbaID = new System.Windows.Forms.Label();
            this.textBoxNarudžbaProizvodID = new System.Windows.Forms.TextBox();
            this.labelNarudžba_ProizvodID = new System.Windows.Forms.Label();
            this.buttonIzmijeniStavkeNarudžbe = new System.Windows.Forms.Button();
            this.comboBoxNarudžbaID = new System.Windows.Forms.ComboBox();
            this.comboBoxProizvodID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxCijena
            // 
            this.textBoxCijena.Location = new System.Drawing.Point(166, 226);
            this.textBoxCijena.Name = "textBoxCijena";
            this.textBoxCijena.Size = new System.Drawing.Size(100, 20);
            this.textBoxCijena.TabIndex = 47;
            this.textBoxCijena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCijena_KeyPress);
            // 
            // textBoxKoličina
            // 
            this.textBoxKoličina.Location = new System.Drawing.Point(166, 182);
            this.textBoxKoličina.Name = "textBoxKoličina";
            this.textBoxKoličina.Size = new System.Drawing.Size(100, 20);
            this.textBoxKoličina.TabIndex = 46;
            this.textBoxKoličina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKoličina_KeyPress);
            // 
            // labelCijena
            // 
            this.labelCijena.AutoSize = true;
            this.labelCijena.Location = new System.Drawing.Point(26, 233);
            this.labelCijena.Name = "labelCijena";
            this.labelCijena.Size = new System.Drawing.Size(36, 13);
            this.labelCijena.TabIndex = 43;
            this.labelCijena.Text = "Cijena";
            // 
            // labelKoličina
            // 
            this.labelKoličina.AutoSize = true;
            this.labelKoličina.Location = new System.Drawing.Point(26, 185);
            this.labelKoličina.Name = "labelKoličina";
            this.labelKoličina.Size = new System.Drawing.Size(44, 13);
            this.labelKoličina.TabIndex = 42;
            this.labelKoličina.Text = "Količina";
            // 
            // labelImeProizvodID
            // 
            this.labelImeProizvodID.AutoSize = true;
            this.labelImeProizvodID.Location = new System.Drawing.Point(26, 139);
            this.labelImeProizvodID.Name = "labelImeProizvodID";
            this.labelImeProizvodID.Size = new System.Drawing.Size(59, 13);
            this.labelImeProizvodID.TabIndex = 41;
            this.labelImeProizvodID.Text = "ProizvodID";
            // 
            // labelNarudžbaID
            // 
            this.labelNarudžbaID.AutoSize = true;
            this.labelNarudžbaID.Location = new System.Drawing.Point(26, 93);
            this.labelNarudžbaID.Name = "labelNarudžbaID";
            this.labelNarudžbaID.Size = new System.Drawing.Size(64, 13);
            this.labelNarudžbaID.TabIndex = 40;
            this.labelNarudžbaID.Text = "NarudžbaID";
            // 
            // textBoxNarudžbaProizvodID
            // 
            this.textBoxNarudžbaProizvodID.Location = new System.Drawing.Point(166, 37);
            this.textBoxNarudžbaProizvodID.Multiline = true;
            this.textBoxNarudžbaProizvodID.Name = "textBoxNarudžbaProizvodID";
            this.textBoxNarudžbaProizvodID.Size = new System.Drawing.Size(100, 21);
            this.textBoxNarudžbaProizvodID.TabIndex = 39;
            // 
            // labelNarudžba_ProizvodID
            // 
            this.labelNarudžba_ProizvodID.AutoSize = true;
            this.labelNarudžba_ProizvodID.Location = new System.Drawing.Point(26, 45);
            this.labelNarudžba_ProizvodID.Name = "labelNarudžba_ProizvodID";
            this.labelNarudžba_ProizvodID.Size = new System.Drawing.Size(111, 13);
            this.labelNarudžba_ProizvodID.TabIndex = 38;
            this.labelNarudžba_ProizvodID.Text = "Narudžba_ProizvodID";
            // 
            // buttonIzmijeniStavkeNarudžbe
            // 
            this.buttonIzmijeniStavkeNarudžbe.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonIzmijeniStavkeNarudžbe.Location = new System.Drawing.Point(149, 274);
            this.buttonIzmijeniStavkeNarudžbe.Name = "buttonIzmijeniStavkeNarudžbe";
            this.buttonIzmijeniStavkeNarudžbe.Size = new System.Drawing.Size(117, 43);
            this.buttonIzmijeniStavkeNarudžbe.TabIndex = 48;
            this.buttonIzmijeniStavkeNarudžbe.Text = "Izmijeni stavke narudžbe";
            this.buttonIzmijeniStavkeNarudžbe.UseVisualStyleBackColor = false;
            this.buttonIzmijeniStavkeNarudžbe.Click += new System.EventHandler(this.buttonIzmijeniStavkeNarudžbe_Click);
            // 
            // comboBoxNarudžbaID
            // 
            this.comboBoxNarudžbaID.FormattingEnabled = true;
            this.comboBoxNarudžbaID.Location = new System.Drawing.Point(166, 85);
            this.comboBoxNarudžbaID.Name = "comboBoxNarudžbaID";
            this.comboBoxNarudžbaID.Size = new System.Drawing.Size(100, 21);
            this.comboBoxNarudžbaID.TabIndex = 49;
            this.comboBoxNarudžbaID.SelectedIndexChanged += new System.EventHandler(this.comboBoxNarudžbaID_SelectedIndexChanged);
            // 
            // comboBoxProizvodID
            // 
            this.comboBoxProizvodID.FormattingEnabled = true;
            this.comboBoxProizvodID.Location = new System.Drawing.Point(166, 131);
            this.comboBoxProizvodID.Name = "comboBoxProizvodID";
            this.comboBoxProizvodID.Size = new System.Drawing.Size(100, 21);
            this.comboBoxProizvodID.TabIndex = 50;
            this.comboBoxProizvodID.SelectedIndexChanged += new System.EventHandler(this.comboBoxProizvodID_SelectedIndexChanged);
            // 
            // FormIzmijeniStavkeNarudžbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(344, 370);
            this.Controls.Add(this.comboBoxProizvodID);
            this.Controls.Add(this.comboBoxNarudžbaID);
            this.Controls.Add(this.buttonIzmijeniStavkeNarudžbe);
            this.Controls.Add(this.textBoxCijena);
            this.Controls.Add(this.textBoxKoličina);
            this.Controls.Add(this.labelCijena);
            this.Controls.Add(this.labelKoličina);
            this.Controls.Add(this.labelImeProizvodID);
            this.Controls.Add(this.labelNarudžbaID);
            this.Controls.Add(this.textBoxNarudžbaProizvodID);
            this.Controls.Add(this.labelNarudžba_ProizvodID);
            this.Name = "FormIzmijeniStavkeNarudžbe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izmijeni Stavku Narudžbe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCijena;
        private System.Windows.Forms.TextBox textBoxKoličina;
        private System.Windows.Forms.Label labelCijena;
        private System.Windows.Forms.Label labelKoličina;
        private System.Windows.Forms.Label labelImeProizvodID;
        private System.Windows.Forms.Label labelNarudžbaID;
        private System.Windows.Forms.TextBox textBoxNarudžbaProizvodID;
        private System.Windows.Forms.Label labelNarudžba_ProizvodID;
        private System.Windows.Forms.Button buttonIzmijeniStavkeNarudžbe;
        private System.Windows.Forms.ComboBox comboBoxNarudžbaID;
        private System.Windows.Forms.ComboBox comboBoxProizvodID;
    }
}