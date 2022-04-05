namespace Narudžba
{
    partial class FormTipPlaćanja
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPretražiTipovePlaćanja = new System.Windows.Forms.Button();
            this.textBoxTipPlaćanjaID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewTipPlaćanja = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IzmijeniTipPlaćanja = new System.Windows.Forms.Button();
            this.buttonObrišiTipPlaćanja = new System.Windows.Forms.Button();
            this.buttonOsvježiPodatkeTip = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.buttonPretražiTipovePlaćanja);
            this.panel1.Controls.Add(this.textBoxTipPlaćanjaID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 98);
            this.panel1.TabIndex = 15;
            // 
            // buttonPretražiTipovePlaćanja
            // 
            this.buttonPretražiTipovePlaćanja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonPretražiTipovePlaćanja.Location = new System.Drawing.Point(259, 60);
            this.buttonPretražiTipovePlaćanja.Name = "buttonPretražiTipovePlaćanja";
            this.buttonPretražiTipovePlaćanja.Size = new System.Drawing.Size(90, 35);
            this.buttonPretražiTipovePlaćanja.TabIndex = 2;
            this.buttonPretražiTipovePlaćanja.Text = "Pretraži";
            this.buttonPretražiTipovePlaćanja.UseVisualStyleBackColor = false;
            this.buttonPretražiTipovePlaćanja.Click += new System.EventHandler(this.buttonPretražiTipovePlaćanja_Click);
            // 
            // textBoxTipPlaćanjaID
            // 
            this.textBoxTipPlaćanjaID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBoxTipPlaćanjaID.Location = new System.Drawing.Point(259, 15);
            this.textBoxTipPlaćanjaID.Name = "textBoxTipPlaćanjaID";
            this.textBoxTipPlaćanjaID.Size = new System.Drawing.Size(90, 20);
            this.textBoxTipPlaćanjaID.TabIndex = 1;
            this.textBoxTipPlaćanjaID.Text = "Tip_plaćanjaID";
            this.textBoxTipPlaćanjaID.TextChanged += new System.EventHandler(this.textBoxTipPlaćanjaID_TextChanged);
            this.textBoxTipPlaćanjaID.Enter += new System.EventHandler(this.textBoxTipPlaćanjaID_Enter);
            this.textBoxTipPlaćanjaID.Leave += new System.EventHandler(this.textBoxTipPlaćanjaID_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pretraga podataka";
            // 
            // listViewTipPlaćanja
            // 
            this.listViewTipPlaćanja.BackColor = System.Drawing.Color.Red;
            this.listViewTipPlaćanja.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewTipPlaćanja.HideSelection = false;
            this.listViewTipPlaćanja.Location = new System.Drawing.Point(22, 63);
            this.listViewTipPlaćanja.Name = "listViewTipPlaćanja";
            this.listViewTipPlaćanja.Size = new System.Drawing.Size(171, 337);
            this.listViewTipPlaćanja.TabIndex = 14;
            this.listViewTipPlaćanja.UseCompatibleStateImageBehavior = false;
            this.listViewTipPlaćanja.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tip_plaćanjaID";
            this.columnHeader1.Width = 85;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naziv";
            this.columnHeader2.Width = 85;
            // 
            // IzmijeniTipPlaćanja
            // 
            this.IzmijeniTipPlaćanja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.IzmijeniTipPlaćanja.Location = new System.Drawing.Point(158, 3);
            this.IzmijeniTipPlaćanja.Name = "IzmijeniTipPlaćanja";
            this.IzmijeniTipPlaćanja.Size = new System.Drawing.Size(101, 41);
            this.IzmijeniTipPlaćanja.TabIndex = 16;
            this.IzmijeniTipPlaćanja.Text = "Izmijeni";
            this.IzmijeniTipPlaćanja.UseVisualStyleBackColor = false;
            this.IzmijeniTipPlaćanja.Click += new System.EventHandler(this.IzmijeniTipPlaćanja_Click);
            // 
            // buttonObrišiTipPlaćanja
            // 
            this.buttonObrišiTipPlaćanja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonObrišiTipPlaćanja.Location = new System.Drawing.Point(295, 3);
            this.buttonObrišiTipPlaćanja.Name = "buttonObrišiTipPlaćanja";
            this.buttonObrišiTipPlaćanja.Size = new System.Drawing.Size(101, 41);
            this.buttonObrišiTipPlaćanja.TabIndex = 17;
            this.buttonObrišiTipPlaćanja.Text = "Obriši";
            this.buttonObrišiTipPlaćanja.UseVisualStyleBackColor = false;
            this.buttonObrišiTipPlaćanja.Click += new System.EventHandler(this.buttonObrišiTipPlaćanja_Click);
            // 
            // buttonOsvježiPodatkeTip
            // 
            this.buttonOsvježiPodatkeTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonOsvježiPodatkeTip.Location = new System.Drawing.Point(22, 3);
            this.buttonOsvježiPodatkeTip.Name = "buttonOsvježiPodatkeTip";
            this.buttonOsvježiPodatkeTip.Size = new System.Drawing.Size(101, 41);
            this.buttonOsvježiPodatkeTip.TabIndex = 18;
            this.buttonOsvježiPodatkeTip.Text = "Osvježi podatke";
            this.buttonOsvježiPodatkeTip.UseVisualStyleBackColor = false;
            this.buttonOsvježiPodatkeTip.Click += new System.EventHandler(this.buttonOsvježiPodatkeTip_Click);
            // 
            // FormTipPlaćanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Narudžba.Properties.Resources.Novac_KM_Euri;
            this.ClientSize = new System.Drawing.Size(415, 535);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewTipPlaćanja);
            this.Controls.Add(this.IzmijeniTipPlaćanja);
            this.Controls.Add(this.buttonObrišiTipPlaćanja);
            this.Controls.Add(this.buttonOsvježiPodatkeTip);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormTipPlaćanja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipovi Plaćanja";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.FormTipPlaćanja_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPretražiTipovePlaćanja;
        private System.Windows.Forms.TextBox textBoxTipPlaćanjaID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewTipPlaćanja;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button IzmijeniTipPlaćanja;
        private System.Windows.Forms.Button buttonObrišiTipPlaćanja;
        private System.Windows.Forms.Button buttonOsvježiPodatkeTip;
    }
}