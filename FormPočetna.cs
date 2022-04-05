using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Narudžba
{
    public partial class FormPočetna : Form
    {
        public FormPočetna()
        {
            InitializeComponent();
        }

        private void FormPočetna_Load(object sender, EventArgs e)
        {
            label1.Text = "Dobrodošli  " + FormLogin.Ime;
        }

        private void toolStripSplitRadnik_ButtonClick(object sender, EventArgs e)
        {
            FormRadnik formRadnik = new FormRadnik();
            formRadnik.Show();
        }

        private void PrijavaNovihRadnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDodavanjeRadnika formDodavanjeRadnika = new FormDodavanjeRadnika();
            formDodavanjeRadnika.Show();
        }

        private void toolStripSplitButtonKupac_ButtonClick(object sender, EventArgs e)
        {
            FormKupac formKupac = new FormKupac();
            formKupac.Show();
        }

        private void toolStripSplitButtonMjesto_ButtonClick(object sender, EventArgs e)
        {
            FormMjesto formMjesto = new FormMjesto();
            formMjesto.Show();

        }

        private void toolStripSplitButtonProizvod_ButtonClick(object sender, EventArgs e)
        {
            FormProizvod formProizvod = new FormProizvod();
            formProizvod.Show();
        }

        private void toolStripSplitButtonNarudžba_ButtonClick(object sender, EventArgs e)
        {
            FormNarudžba formNarudžba = new FormNarudžba();
            formNarudžba.Show();
        }

        private void toolStripSplitButtonStavkeNarudžbe_ButtonClick(object sender, EventArgs e)
        {
            FormStavkeNarudžbe formStavkeNarudžbe = new FormStavkeNarudžbe();
            formStavkeNarudžbe.Show();
        }

        private void toolStripSplitButtonTipPlaćanja_ButtonClick(object sender, EventArgs e)
        {
            FormTipPlaćanja formTipPlaćanja = new FormTipPlaćanja();
            formTipPlaćanja.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonIzlogujSe_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PrijavaNovihKupacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDodavanjeKupaca formDodavanjeKupaca = new FormDodavanjeKupaca();
            formDodavanjeKupaca.Show();
        }

        private void prijavaNovogMjestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDodavanjeMjesta formDodavanjeMjesta = new FormDodavanjeMjesta();
            formDodavanjeMjesta.Show();
        }

        private void prijavaNovihProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDodavanjeProizvoda formDodavanjeProizvoda = new FormDodavanjeProizvoda();
            formDodavanjeProizvoda.Show();
        }

        private void prijavaNovihNarudžbiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDodavanjeNarudžbi formDodavanjeNarudžbi = new FormDodavanjeNarudžbi();
            formDodavanjeNarudžbi.Show();
        }

        private void prijavaNovihStavkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDodavanjeStavkiNarudžbe formDodavanjeStavkiNarudžbe = new FormDodavanjeStavkiNarudžbe();
            formDodavanjeStavkiNarudžbe.Show();
        }

        private void prijavaNovogTipaPlaćanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDodavanjeTipaPlaćanja formDodavanjeTipaPlaćanja = new FormDodavanjeTipaPlaćanja();
            formDodavanjeTipaPlaćanja.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
