namespace Narudžba
{
    partial class FormPočetna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPočetna));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButtonRadnik = new System.Windows.Forms.ToolStripSplitButton();
            this.PrijavaNovihRadnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmjenaRadnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brisanjeRadnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButtonKupac = new System.Windows.Forms.ToolStripSplitButton();
            this.PrijavaNovihKupacaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButtonMjesto = new System.Windows.Forms.ToolStripSplitButton();
            this.prijavaNovogMjestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmijeniMjestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButtonProizvod = new System.Windows.Forms.ToolStripSplitButton();
            this.prijavaNovihProizvodaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButtonNarudžba = new System.Windows.Forms.ToolStripSplitButton();
            this.prijavaNovihNarudžbiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButtonStavkeNarudžbe = new System.Windows.Forms.ToolStripSplitButton();
            this.prijavaNovihStavkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButtonTipPlaćanja = new System.Windows.Forms.ToolStripSplitButton();
            this.prijavaNovogTipaPlaćanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmijeniTipPlaćanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonIzlogujSe = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButtonRadnik,
            this.toolStripSeparator1,
            this.toolStripSplitButtonKupac,
            this.toolStripSeparator6,
            this.toolStripSplitButtonMjesto,
            this.toolStripSeparator5,
            this.toolStripSplitButtonProizvod,
            this.toolStripSeparator4,
            this.toolStripSplitButtonNarudžba,
            this.toolStripSeparator3,
            this.toolStripSplitButtonStavkeNarudžbe,
            this.toolStripSeparator2,
            this.toolStripSplitButtonTipPlaćanja,
            this.toolStripButtonIzlogujSe});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(919, 73);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripSplitButtonRadnik
            // 
            this.toolStripSplitButtonRadnik.AutoSize = false;
            this.toolStripSplitButtonRadnik.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButtonRadnik.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrijavaNovihRadnikaToolStripMenuItem,
            this.izmjenaRadnikaToolStripMenuItem,
            this.brisanjeRadnikaToolStripMenuItem});
            this.toolStripSplitButtonRadnik.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonRadnik.Image")));
            this.toolStripSplitButtonRadnik.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonRadnik.Name = "toolStripSplitButtonRadnik";
            this.toolStripSplitButtonRadnik.Size = new System.Drawing.Size(80, 70);
            this.toolStripSplitButtonRadnik.Text = "Radnik";
            this.toolStripSplitButtonRadnik.ButtonClick += new System.EventHandler(this.toolStripSplitRadnik_ButtonClick);
            // 
            // PrijavaNovihRadnikaToolStripMenuItem
            // 
            this.PrijavaNovihRadnikaToolStripMenuItem.Name = "PrijavaNovihRadnikaToolStripMenuItem";
            this.PrijavaNovihRadnikaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.PrijavaNovihRadnikaToolStripMenuItem.Text = "Prijava novih radnika";
            this.PrijavaNovihRadnikaToolStripMenuItem.Click += new System.EventHandler(this.PrijavaNovihRadnikaToolStripMenuItem_Click);
            // 
            // izmjenaRadnikaToolStripMenuItem
            // 
            this.izmjenaRadnikaToolStripMenuItem.Name = "izmjenaRadnikaToolStripMenuItem";
            this.izmjenaRadnikaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            // 
            // brisanjeRadnikaToolStripMenuItem
            // 
            this.brisanjeRadnikaToolStripMenuItem.Name = "brisanjeRadnikaToolStripMenuItem";
            this.brisanjeRadnikaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 73);
            // 
            // toolStripSplitButtonKupac
            // 
            this.toolStripSplitButtonKupac.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButtonKupac.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrijavaNovihKupacaToolStripMenuItem});
            this.toolStripSplitButtonKupac.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonKupac.Image")));
            this.toolStripSplitButtonKupac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonKupac.Name = "toolStripSplitButtonKupac";
            this.toolStripSplitButtonKupac.Size = new System.Drawing.Size(56, 70);
            this.toolStripSplitButtonKupac.Text = "Kupac";
            this.toolStripSplitButtonKupac.ButtonClick += new System.EventHandler(this.toolStripSplitButtonKupac_ButtonClick);
            // 
            // PrijavaNovihKupacaToolStripMenuItem
            // 
            this.PrijavaNovihKupacaToolStripMenuItem.Name = "PrijavaNovihKupacaToolStripMenuItem";
            this.PrijavaNovihKupacaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.PrijavaNovihKupacaToolStripMenuItem.Text = "Prijava novih kupaca";
            this.PrijavaNovihKupacaToolStripMenuItem.Click += new System.EventHandler(this.PrijavaNovihKupacaToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 73);
            // 
            // toolStripSplitButtonMjesto
            // 
            this.toolStripSplitButtonMjesto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButtonMjesto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prijavaNovogMjestaToolStripMenuItem,
            this.izmijeniMjestoToolStripMenuItem});
            this.toolStripSplitButtonMjesto.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonMjesto.Image")));
            this.toolStripSplitButtonMjesto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonMjesto.Name = "toolStripSplitButtonMjesto";
            this.toolStripSplitButtonMjesto.Size = new System.Drawing.Size(59, 70);
            this.toolStripSplitButtonMjesto.Text = "Mjesto";
            this.toolStripSplitButtonMjesto.ButtonClick += new System.EventHandler(this.toolStripSplitButtonMjesto_ButtonClick);
            // 
            // prijavaNovogMjestaToolStripMenuItem
            // 
            this.prijavaNovogMjestaToolStripMenuItem.Name = "prijavaNovogMjestaToolStripMenuItem";
            this.prijavaNovogMjestaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.prijavaNovogMjestaToolStripMenuItem.Text = "Prijava novog mjesta";
            this.prijavaNovogMjestaToolStripMenuItem.Click += new System.EventHandler(this.prijavaNovogMjestaToolStripMenuItem_Click);
            // 
            // izmijeniMjestoToolStripMenuItem
            // 
            this.izmijeniMjestoToolStripMenuItem.Name = "izmijeniMjestoToolStripMenuItem";
            this.izmijeniMjestoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 73);
            // 
            // toolStripSplitButtonProizvod
            // 
            this.toolStripSplitButtonProizvod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButtonProizvod.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prijavaNovihProizvodaToolStripMenuItem});
            this.toolStripSplitButtonProizvod.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonProizvod.Image")));
            this.toolStripSplitButtonProizvod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonProizvod.Name = "toolStripSplitButtonProizvod";
            this.toolStripSplitButtonProizvod.Size = new System.Drawing.Size(69, 70);
            this.toolStripSplitButtonProizvod.Text = "Proizvod";
            this.toolStripSplitButtonProizvod.ButtonClick += new System.EventHandler(this.toolStripSplitButtonProizvod_ButtonClick);
            // 
            // prijavaNovihProizvodaToolStripMenuItem
            // 
            this.prijavaNovihProizvodaToolStripMenuItem.Name = "prijavaNovihProizvodaToolStripMenuItem";
            this.prijavaNovihProizvodaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.prijavaNovihProizvodaToolStripMenuItem.Text = "Prijava novih proizvoda";
            this.prijavaNovihProizvodaToolStripMenuItem.Click += new System.EventHandler(this.prijavaNovihProizvodaToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 73);
            // 
            // toolStripSplitButtonNarudžba
            // 
            this.toolStripSplitButtonNarudžba.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButtonNarudžba.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prijavaNovihNarudžbiToolStripMenuItem});
            this.toolStripSplitButtonNarudžba.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonNarudžba.Image")));
            this.toolStripSplitButtonNarudžba.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonNarudžba.Name = "toolStripSplitButtonNarudžba";
            this.toolStripSplitButtonNarudžba.Size = new System.Drawing.Size(74, 70);
            this.toolStripSplitButtonNarudžba.Text = "Narudžba";
            this.toolStripSplitButtonNarudžba.ButtonClick += new System.EventHandler(this.toolStripSplitButtonNarudžba_ButtonClick);
            // 
            // prijavaNovihNarudžbiToolStripMenuItem
            // 
            this.prijavaNovihNarudžbiToolStripMenuItem.Name = "prijavaNovihNarudžbiToolStripMenuItem";
            this.prijavaNovihNarudžbiToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.prijavaNovihNarudžbiToolStripMenuItem.Text = "Prijava novih narudžbi";
            this.prijavaNovihNarudžbiToolStripMenuItem.Click += new System.EventHandler(this.prijavaNovihNarudžbiToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 73);
            // 
            // toolStripSplitButtonStavkeNarudžbe
            // 
            this.toolStripSplitButtonStavkeNarudžbe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButtonStavkeNarudžbe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prijavaNovihStavkiToolStripMenuItem});
            this.toolStripSplitButtonStavkeNarudžbe.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonStavkeNarudžbe.Image")));
            this.toolStripSplitButtonStavkeNarudžbe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonStavkeNarudžbe.Name = "toolStripSplitButtonStavkeNarudžbe";
            this.toolStripSplitButtonStavkeNarudžbe.Size = new System.Drawing.Size(109, 70);
            this.toolStripSplitButtonStavkeNarudžbe.Text = "Stavke narudžbe";
            this.toolStripSplitButtonStavkeNarudžbe.ButtonClick += new System.EventHandler(this.toolStripSplitButtonStavkeNarudžbe_ButtonClick);
            // 
            // prijavaNovihStavkiToolStripMenuItem
            // 
            this.prijavaNovihStavkiToolStripMenuItem.Name = "prijavaNovihStavkiToolStripMenuItem";
            this.prijavaNovihStavkiToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.prijavaNovihStavkiToolStripMenuItem.Text = "Prijava novih stavki";
            this.prijavaNovihStavkiToolStripMenuItem.Click += new System.EventHandler(this.prijavaNovihStavkiToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 73);
            // 
            // toolStripSplitButtonTipPlaćanja
            // 
            this.toolStripSplitButtonTipPlaćanja.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButtonTipPlaćanja.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prijavaNovogTipaPlaćanjaToolStripMenuItem,
            this.izmijeniTipPlaćanjaToolStripMenuItem});
            this.toolStripSplitButtonTipPlaćanja.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonTipPlaćanja.Image")));
            this.toolStripSplitButtonTipPlaćanja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonTipPlaćanja.Name = "toolStripSplitButtonTipPlaćanja";
            this.toolStripSplitButtonTipPlaćanja.Size = new System.Drawing.Size(86, 70);
            this.toolStripSplitButtonTipPlaćanja.Text = "Tip plaćanja";
            this.toolStripSplitButtonTipPlaćanja.ButtonClick += new System.EventHandler(this.toolStripSplitButtonTipPlaćanja_ButtonClick);
            // 
            // prijavaNovogTipaPlaćanjaToolStripMenuItem
            // 
            this.prijavaNovogTipaPlaćanjaToolStripMenuItem.Name = "prijavaNovogTipaPlaćanjaToolStripMenuItem";
            this.prijavaNovogTipaPlaćanjaToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.prijavaNovogTipaPlaćanjaToolStripMenuItem.Text = "Prijava novog tipa plaćanja";
            this.prijavaNovogTipaPlaćanjaToolStripMenuItem.Click += new System.EventHandler(this.prijavaNovogTipaPlaćanjaToolStripMenuItem_Click);
            // 
            // izmijeniTipPlaćanjaToolStripMenuItem
            // 
            this.izmijeniTipPlaćanjaToolStripMenuItem.Name = "izmijeniTipPlaćanjaToolStripMenuItem";
            this.izmijeniTipPlaćanjaToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            // 
            // toolStripButtonIzlogujSe
            // 
            this.toolStripButtonIzlogujSe.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonIzlogujSe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonIzlogujSe.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonIzlogujSe.Image")));
            this.toolStripButtonIzlogujSe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonIzlogujSe.Name = "toolStripButtonIzlogujSe";
            this.toolStripButtonIzlogujSe.Size = new System.Drawing.Size(60, 70);
            this.toolStripButtonIzlogujSe.Text = "Izloguj se";
            this.toolStripButtonIzlogujSe.Click += new System.EventHandler(this.toolStripButtonIzlogujSe_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(852, 479);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(534, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormPočetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(919, 556);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormPočetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Početna strana";
            this.Load += new System.EventHandler(this.FormPočetna_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonRadnik;
        private System.Windows.Forms.ToolStripMenuItem PrijavaNovihRadnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonKupac;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonMjesto;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonProizvod;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonNarudžba;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonStavkeNarudžbe;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonTipPlaćanja;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton toolStripButtonIzlogujSe;
        private System.Windows.Forms.ToolStripMenuItem PrijavaNovihKupacaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmjenaRadnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brisanjeRadnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prijavaNovogMjestaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prijavaNovihProizvodaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prijavaNovihNarudžbiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prijavaNovihStavkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prijavaNovogTipaPlaćanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmijeniTipPlaćanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmijeniMjestoToolStripMenuItem;
    }
}