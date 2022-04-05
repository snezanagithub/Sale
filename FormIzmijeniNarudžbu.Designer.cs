namespace Narudžba
{
    partial class FormIzmijeniNarudžbu
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
            this.textBoxIznosBezPdv = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.labelIznosBezPdv = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelDatum_nastanka = new System.Windows.Forms.Label();
            this.labelKupacID = new System.Windows.Forms.Label();
            this.labelImeRadnikID = new System.Windows.Forms.Label();
            this.labelTip_plaćanjaID = new System.Windows.Forms.Label();
            this.textBoxNarudžbaID = new System.Windows.Forms.TextBox();
            this.labelNarudžbaID = new System.Windows.Forms.Label();
            this.textBoxIznosSaPdv = new System.Windows.Forms.TextBox();
            this.textBoxPdv = new System.Windows.Forms.TextBox();
            this.labelIznosSaPdv = new System.Windows.Forms.Label();
            this.labelPdv = new System.Windows.Forms.Label();
            this.buttonIzmijeniNarudžbu = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDatumNastanka = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTipPlaćanja = new System.Windows.Forms.ComboBox();
            this.comboBoxRadnikID = new System.Windows.Forms.ComboBox();
            this.comboBoxKupacID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxIznosBezPdv
            // 
            this.textBoxIznosBezPdv.Location = new System.Drawing.Point(175, 308);
            this.textBoxIznosBezPdv.Name = "textBoxIznosBezPdv";
            this.textBoxIznosBezPdv.Size = new System.Drawing.Size(123, 20);
            this.textBoxIznosBezPdv.TabIndex = 29;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(175, 260);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(123, 20);
            this.textBoxStatus.TabIndex = 28;
            this.textBoxStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStatus_KeyPress);
            // 
            // labelIznosBezPdv
            // 
            this.labelIznosBezPdv.AutoSize = true;
            this.labelIznosBezPdv.Location = new System.Drawing.Point(35, 315);
            this.labelIznosBezPdv.Name = "labelIznosBezPdv";
            this.labelIznosBezPdv.Size = new System.Drawing.Size(82, 13);
            this.labelIznosBezPdv.TabIndex = 23;
            this.labelIznosBezPdv.Text = "Iznos bez pdv-a";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(35, 267);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 22;
            this.labelStatus.Text = "Status";
            // 
            // labelDatum_nastanka
            // 
            this.labelDatum_nastanka.AutoSize = true;
            this.labelDatum_nastanka.Location = new System.Drawing.Point(35, 225);
            this.labelDatum_nastanka.Name = "labelDatum_nastanka";
            this.labelDatum_nastanka.Size = new System.Drawing.Size(85, 13);
            this.labelDatum_nastanka.TabIndex = 21;
            this.labelDatum_nastanka.Text = "Datum nastanka";
            // 
            // labelKupacID
            // 
            this.labelKupacID.AutoSize = true;
            this.labelKupacID.Location = new System.Drawing.Point(35, 177);
            this.labelKupacID.Name = "labelKupacID";
            this.labelKupacID.Size = new System.Drawing.Size(49, 13);
            this.labelKupacID.TabIndex = 20;
            this.labelKupacID.Text = "KupacID";
            // 
            // labelImeRadnikID
            // 
            this.labelImeRadnikID.AutoSize = true;
            this.labelImeRadnikID.Location = new System.Drawing.Point(35, 131);
            this.labelImeRadnikID.Name = "labelImeRadnikID";
            this.labelImeRadnikID.Size = new System.Drawing.Size(52, 13);
            this.labelImeRadnikID.TabIndex = 19;
            this.labelImeRadnikID.Text = "RadnikID";
            // 
            // labelTip_plaćanjaID
            // 
            this.labelTip_plaćanjaID.AutoSize = true;
            this.labelTip_plaćanjaID.Location = new System.Drawing.Point(35, 85);
            this.labelTip_plaćanjaID.Name = "labelTip_plaćanjaID";
            this.labelTip_plaćanjaID.Size = new System.Drawing.Size(79, 13);
            this.labelTip_plaćanjaID.TabIndex = 18;
            this.labelTip_plaćanjaID.Text = "Tip_plaćanjaID";
            // 
            // textBoxNarudžbaID
            // 
            this.textBoxNarudžbaID.Location = new System.Drawing.Point(175, 29);
            this.textBoxNarudžbaID.Multiline = true;
            this.textBoxNarudžbaID.Name = "textBoxNarudžbaID";
            this.textBoxNarudžbaID.Size = new System.Drawing.Size(123, 21);
            this.textBoxNarudžbaID.TabIndex = 17;
            // 
            // labelNarudžbaID
            // 
            this.labelNarudžbaID.AutoSize = true;
            this.labelNarudžbaID.Location = new System.Drawing.Point(35, 37);
            this.labelNarudžbaID.Name = "labelNarudžbaID";
            this.labelNarudžbaID.Size = new System.Drawing.Size(64, 13);
            this.labelNarudžbaID.TabIndex = 16;
            this.labelNarudžbaID.Text = "NarudžbaID";
            // 
            // textBoxIznosSaPdv
            // 
            this.textBoxIznosSaPdv.Location = new System.Drawing.Point(175, 405);
            this.textBoxIznosSaPdv.Name = "textBoxIznosSaPdv";
            this.textBoxIznosSaPdv.Size = new System.Drawing.Size(123, 20);
            this.textBoxIznosSaPdv.TabIndex = 33;
            // 
            // textBoxPdv
            // 
            this.textBoxPdv.Location = new System.Drawing.Point(175, 357);
            this.textBoxPdv.Name = "textBoxPdv";
            this.textBoxPdv.Size = new System.Drawing.Size(123, 20);
            this.textBoxPdv.TabIndex = 32;
            // 
            // labelIznosSaPdv
            // 
            this.labelIznosSaPdv.AutoSize = true;
            this.labelIznosSaPdv.Location = new System.Drawing.Point(35, 412);
            this.labelIznosSaPdv.Name = "labelIznosSaPdv";
            this.labelIznosSaPdv.Size = new System.Drawing.Size(84, 13);
            this.labelIznosSaPdv.TabIndex = 31;
            this.labelIznosSaPdv.Text = "Iznos sa pdv-om";
            // 
            // labelPdv
            // 
            this.labelPdv.AutoSize = true;
            this.labelPdv.Location = new System.Drawing.Point(35, 364);
            this.labelPdv.Name = "labelPdv";
            this.labelPdv.Size = new System.Drawing.Size(26, 13);
            this.labelPdv.TabIndex = 30;
            this.labelPdv.Text = "Pdv";
            // 
            // buttonIzmijeniNarudžbu
            // 
            this.buttonIzmijeniNarudžbu.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonIzmijeniNarudžbu.Location = new System.Drawing.Point(175, 463);
            this.buttonIzmijeniNarudžbu.Name = "buttonIzmijeniNarudžbu";
            this.buttonIzmijeniNarudžbu.Size = new System.Drawing.Size(117, 37);
            this.buttonIzmijeniNarudžbu.TabIndex = 34;
            this.buttonIzmijeniNarudžbu.Text = "Izmijeni narudžbu";
            this.buttonIzmijeniNarudžbu.UseVisualStyleBackColor = false;
            this.buttonIzmijeniNarudžbu.Click += new System.EventHandler(this.buttonIzmijeniNarudžbu_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(380, 438);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // dateTimePickerDatumNastanka
            // 
            this.dateTimePickerDatumNastanka.Location = new System.Drawing.Point(177, 218);
            this.dateTimePickerDatumNastanka.Name = "dateTimePickerDatumNastanka";
            this.dateTimePickerDatumNastanka.Size = new System.Drawing.Size(180, 20);
            this.dateTimePickerDatumNastanka.TabIndex = 36;
            // 
            // comboBoxTipPlaćanja
            // 
            this.comboBoxTipPlaćanja.FormattingEnabled = true;
            this.comboBoxTipPlaćanja.Location = new System.Drawing.Point(177, 82);
            this.comboBoxTipPlaćanja.Name = "comboBoxTipPlaćanja";
            this.comboBoxTipPlaćanja.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipPlaćanja.TabIndex = 37;
            this.comboBoxTipPlaćanja.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipPlaćanja_SelectedIndexChanged);
            // 
            // comboBoxRadnikID
            // 
            this.comboBoxRadnikID.FormattingEnabled = true;
            this.comboBoxRadnikID.Location = new System.Drawing.Point(177, 131);
            this.comboBoxRadnikID.Name = "comboBoxRadnikID";
            this.comboBoxRadnikID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRadnikID.TabIndex = 38;
            this.comboBoxRadnikID.SelectedIndexChanged += new System.EventHandler(this.comboBoxRadnikID_SelectedIndexChanged);
            // 
            // comboBoxKupacID
            // 
            this.comboBoxKupacID.FormattingEnabled = true;
            this.comboBoxKupacID.Location = new System.Drawing.Point(177, 174);
            this.comboBoxKupacID.Name = "comboBoxKupacID";
            this.comboBoxKupacID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKupacID.TabIndex = 39;
            this.comboBoxKupacID.SelectedIndexChanged += new System.EventHandler(this.comboBoxKupacID_SelectedIndexChanged);
            // 
            // FormIzmijeniNarudžbu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(385, 534);
            this.Controls.Add(this.comboBoxKupacID);
            this.Controls.Add(this.comboBoxRadnikID);
            this.Controls.Add(this.comboBoxTipPlaćanja);
            this.Controls.Add(this.dateTimePickerDatumNastanka);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonIzmijeniNarudžbu);
            this.Controls.Add(this.textBoxIznosSaPdv);
            this.Controls.Add(this.textBoxPdv);
            this.Controls.Add(this.labelIznosSaPdv);
            this.Controls.Add(this.labelPdv);
            this.Controls.Add(this.textBoxIznosBezPdv);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.labelIznosBezPdv);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelDatum_nastanka);
            this.Controls.Add(this.labelKupacID);
            this.Controls.Add(this.labelImeRadnikID);
            this.Controls.Add(this.labelTip_plaćanjaID);
            this.Controls.Add(this.textBoxNarudžbaID);
            this.Controls.Add(this.labelNarudžbaID);
            this.Name = "FormIzmijeniNarudžbu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izmijeni Narudžbu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIznosBezPdv;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labelIznosBezPdv;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelDatum_nastanka;
        private System.Windows.Forms.Label labelKupacID;
        private System.Windows.Forms.Label labelImeRadnikID;
        private System.Windows.Forms.Label labelTip_plaćanjaID;
        private System.Windows.Forms.TextBox textBoxNarudžbaID;
        private System.Windows.Forms.Label labelNarudžbaID;
        private System.Windows.Forms.TextBox textBoxIznosSaPdv;
        private System.Windows.Forms.TextBox textBoxPdv;
        private System.Windows.Forms.Label labelIznosSaPdv;
        private System.Windows.Forms.Label labelPdv;
        private System.Windows.Forms.Button buttonIzmijeniNarudžbu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumNastanka;
        private System.Windows.Forms.ComboBox comboBoxTipPlaćanja;
        private System.Windows.Forms.ComboBox comboBoxRadnikID;
        private System.Windows.Forms.ComboBox comboBoxKupacID;
    }
}