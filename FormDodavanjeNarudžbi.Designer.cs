namespace Narudžba
{
    partial class FormDodavanjeNarudžbi
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
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelDatum_nastanka = new System.Windows.Forms.Label();
            this.labelKupacId = new System.Windows.Forms.Label();
            this.labelRadnikId = new System.Windows.Forms.Label();
            this.labelTip_plaćanjaId = new System.Windows.Forms.Label();
            this.textBoxIznosSaPdv = new System.Windows.Forms.TextBox();
            this.textBoxPdv = new System.Windows.Forms.TextBox();
            this.labelIznosSaPdv = new System.Windows.Forms.Label();
            this.labelPdv = new System.Windows.Forms.Label();
            this.textBoxIznosBezPdv = new System.Windows.Forms.TextBox();
            this.labelIznosBezPdv = new System.Windows.Forms.Label();
            this.buttonUnesiNarudžbu = new System.Windows.Forms.Button();
            this.dateTimePickerDatumNastanka = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTipPlaćanja = new System.Windows.Forms.ComboBox();
            this.comboBoxRadnik = new System.Windows.Forms.ComboBox();
            this.comboBoxKupac = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(148, 208);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(117, 20);
            this.textBoxStatus.TabIndex = 37;
            this.textBoxStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStatus_KeyPress);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(34, 215);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 35;
            this.labelStatus.Text = "Status";
            // 
            // labelDatum_nastanka
            // 
            this.labelDatum_nastanka.AutoSize = true;
            this.labelDatum_nastanka.Location = new System.Drawing.Point(34, 173);
            this.labelDatum_nastanka.Name = "labelDatum_nastanka";
            this.labelDatum_nastanka.Size = new System.Drawing.Size(85, 13);
            this.labelDatum_nastanka.TabIndex = 34;
            this.labelDatum_nastanka.Text = "Datum nastanka";
            // 
            // labelKupacId
            // 
            this.labelKupacId.AutoSize = true;
            this.labelKupacId.Location = new System.Drawing.Point(34, 132);
            this.labelKupacId.Name = "labelKupacId";
            this.labelKupacId.Size = new System.Drawing.Size(47, 13);
            this.labelKupacId.TabIndex = 29;
            this.labelKupacId.Text = "KupacId";
            // 
            // labelRadnikId
            // 
            this.labelRadnikId.AutoSize = true;
            this.labelRadnikId.Location = new System.Drawing.Point(34, 85);
            this.labelRadnikId.Name = "labelRadnikId";
            this.labelRadnikId.Size = new System.Drawing.Size(50, 13);
            this.labelRadnikId.TabIndex = 28;
            this.labelRadnikId.Text = "RadnikId";
            // 
            // labelTip_plaćanjaId
            // 
            this.labelTip_plaćanjaId.AutoSize = true;
            this.labelTip_plaćanjaId.Location = new System.Drawing.Point(34, 39);
            this.labelTip_plaćanjaId.Name = "labelTip_plaćanjaId";
            this.labelTip_plaćanjaId.Size = new System.Drawing.Size(77, 13);
            this.labelTip_plaćanjaId.TabIndex = 27;
            this.labelTip_plaćanjaId.Text = "Tip_plaćanjaId";
            // 
            // textBoxIznosSaPdv
            // 
            this.textBoxIznosSaPdv.Location = new System.Drawing.Point(148, 331);
            this.textBoxIznosSaPdv.Name = "textBoxIznosSaPdv";
            this.textBoxIznosSaPdv.Size = new System.Drawing.Size(117, 20);
            this.textBoxIznosSaPdv.TabIndex = 43;
            this.textBoxIznosSaPdv.Text = "0";
            // 
            // textBoxPdv
            // 
            this.textBoxPdv.Location = new System.Drawing.Point(148, 289);
            this.textBoxPdv.Name = "textBoxPdv";
            this.textBoxPdv.Size = new System.Drawing.Size(117, 20);
            this.textBoxPdv.TabIndex = 42;
            this.textBoxPdv.Text = "0";
            // 
            // labelIznosSaPdv
            // 
            this.labelIznosSaPdv.AutoSize = true;
            this.labelIznosSaPdv.Location = new System.Drawing.Point(34, 338);
            this.labelIznosSaPdv.Name = "labelIznosSaPdv";
            this.labelIznosSaPdv.Size = new System.Drawing.Size(81, 13);
            this.labelIznosSaPdv.TabIndex = 41;
            this.labelIznosSaPdv.Text = "IznosSaPdv-om";
            // 
            // labelPdv
            // 
            this.labelPdv.AutoSize = true;
            this.labelPdv.Location = new System.Drawing.Point(34, 296);
            this.labelPdv.Name = "labelPdv";
            this.labelPdv.Size = new System.Drawing.Size(26, 13);
            this.labelPdv.TabIndex = 40;
            this.labelPdv.Text = "Pdv";
            // 
            // textBoxIznosBezPdv
            // 
            this.textBoxIznosBezPdv.Location = new System.Drawing.Point(148, 248);
            this.textBoxIznosBezPdv.Name = "textBoxIznosBezPdv";
            this.textBoxIznosBezPdv.Size = new System.Drawing.Size(117, 20);
            this.textBoxIznosBezPdv.TabIndex = 39;
            this.textBoxIznosBezPdv.Text = "0";
            // 
            // labelIznosBezPdv
            // 
            this.labelIznosBezPdv.AutoSize = true;
            this.labelIznosBezPdv.Location = new System.Drawing.Point(34, 255);
            this.labelIznosBezPdv.Name = "labelIznosBezPdv";
            this.labelIznosBezPdv.Size = new System.Drawing.Size(82, 13);
            this.labelIznosBezPdv.TabIndex = 38;
            this.labelIznosBezPdv.Text = "Iznos bez pdv-a";
            // 
            // buttonUnesiNarudžbu
            // 
            this.buttonUnesiNarudžbu.Location = new System.Drawing.Point(138, 377);
            this.buttonUnesiNarudžbu.Name = "buttonUnesiNarudžbu";
            this.buttonUnesiNarudžbu.Size = new System.Drawing.Size(142, 40);
            this.buttonUnesiNarudžbu.TabIndex = 44;
            this.buttonUnesiNarudžbu.Text = "Unesi narudžbu";
            this.buttonUnesiNarudžbu.UseVisualStyleBackColor = true;
            this.buttonUnesiNarudžbu.Click += new System.EventHandler(this.buttonUnesiNarudžbu_Click);
            // 
            // dateTimePickerDatumNastanka
            // 
            this.dateTimePickerDatumNastanka.Location = new System.Drawing.Point(148, 167);
            this.dateTimePickerDatumNastanka.Name = "dateTimePickerDatumNastanka";
            this.dateTimePickerDatumNastanka.Size = new System.Drawing.Size(180, 20);
            this.dateTimePickerDatumNastanka.TabIndex = 45;
            // 
            // comboBoxTipPlaćanja
            // 
            this.comboBoxTipPlaćanja.FormattingEnabled = true;
            this.comboBoxTipPlaćanja.Location = new System.Drawing.Point(148, 31);
            this.comboBoxTipPlaćanja.Name = "comboBoxTipPlaćanja";
            this.comboBoxTipPlaćanja.Size = new System.Drawing.Size(117, 21);
            this.comboBoxTipPlaćanja.TabIndex = 46;
            // 
            // comboBoxRadnik
            // 
            this.comboBoxRadnik.FormattingEnabled = true;
            this.comboBoxRadnik.Location = new System.Drawing.Point(148, 77);
            this.comboBoxRadnik.Name = "comboBoxRadnik";
            this.comboBoxRadnik.Size = new System.Drawing.Size(117, 21);
            this.comboBoxRadnik.TabIndex = 47;
            // 
            // comboBoxKupac
            // 
            this.comboBoxKupac.FormattingEnabled = true;
            this.comboBoxKupac.Location = new System.Drawing.Point(148, 124);
            this.comboBoxKupac.Name = "comboBoxKupac";
            this.comboBoxKupac.Size = new System.Drawing.Size(117, 21);
            this.comboBoxKupac.TabIndex = 48;
            // 
            // FormDodavanjeNarudžbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(373, 478);
            this.Controls.Add(this.comboBoxKupac);
            this.Controls.Add(this.comboBoxRadnik);
            this.Controls.Add(this.comboBoxTipPlaćanja);
            this.Controls.Add(this.dateTimePickerDatumNastanka);
            this.Controls.Add(this.buttonUnesiNarudžbu);
            this.Controls.Add(this.textBoxIznosSaPdv);
            this.Controls.Add(this.textBoxPdv);
            this.Controls.Add(this.labelIznosSaPdv);
            this.Controls.Add(this.labelPdv);
            this.Controls.Add(this.textBoxIznosBezPdv);
            this.Controls.Add(this.labelIznosBezPdv);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelDatum_nastanka);
            this.Controls.Add(this.labelKupacId);
            this.Controls.Add(this.labelRadnikId);
            this.Controls.Add(this.labelTip_plaćanjaId);
            this.Name = "FormDodavanjeNarudžbi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje novih narudžbi";
            this.Load += new System.EventHandler(this.FormDodavanjeNarudžbi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelDatum_nastanka;
        private System.Windows.Forms.Label labelKupacId;
        private System.Windows.Forms.Label labelRadnikId;
        private System.Windows.Forms.Label labelTip_plaćanjaId;
        private System.Windows.Forms.TextBox textBoxIznosSaPdv;
        private System.Windows.Forms.TextBox textBoxPdv;
        private System.Windows.Forms.Label labelIznosSaPdv;
        private System.Windows.Forms.Label labelPdv;
        private System.Windows.Forms.TextBox textBoxIznosBezPdv;
        private System.Windows.Forms.Label labelIznosBezPdv;
        private System.Windows.Forms.Button buttonUnesiNarudžbu;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumNastanka;
        private System.Windows.Forms.ComboBox comboBoxTipPlaćanja;
        private System.Windows.Forms.ComboBox comboBoxRadnik;
        private System.Windows.Forms.ComboBox comboBoxKupac;
    }
}