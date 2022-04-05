using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Narudžba
{
    public partial class FormRadnik : Form
    {
        public FormRadnik()
        {
            InitializeComponent();
        }
        // SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-58VR9SD;Initial Catalog=Narudžba;Integrated Security=True");
        ConnectionClass cc = new ConnectionClass();


        private void FormRadnik_Load(object sender, EventArgs e)
        {
            PopuniListu();
            buttonPretraži.Enabled = false;

        }
        public void PopuniListu()
        {

            SqlConnection conn = cc.conn;
            conn.Open();

            String sql = "UČITAJ_RADNIKE";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtRadnik = new DataTable();
            while (!sqlDataReader.IsClosed)
            {
                dtRadnik.Load(sqlDataReader);
            }
            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();

            listViewRadnik.Items.Clear();
            listViewRadnik.Refresh();

            ListViewItem lvi;
            if (dtRadnik.Rows.Count != 0)
            {
                foreach (DataRow red in dtRadnik.Rows)
                {
                    lvi = new ListViewItem();
                    lvi.Checked = false;
                    if (red["RADNIKID"].ToString() == "")
                        lvi.Text = "";
                    else
                        lvi.Text = red["RADNIKID"].ToString();

                    if (red["MJESTOID"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["MJESTOID"].ToString());

                    if (red["IME"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["IME"].ToString());

                    if (red["PREZIME"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["PREZIME"].ToString().Trim());

                    if (red["BR_TELEFONA"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["BR_TELEFONA"].ToString().Trim());


                    if (red["EMAIL"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["EMAIL"].ToString().Trim());
                    if (red["ADRESA"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["ADRESA"].ToString().Trim());


                    if (red["DATUM_ROĐENJA"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(DateTime.Parse(red["DATUM_ROĐENJA"].
                            ToString()).ToString("dd.MM.yyyy"));

                    if (red["DATUM_ZAPOSLENJA"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(DateTime.Parse(red["DATUM_ZAPOSLENJA"].
                            ToString()).ToString("dd.MM.yyyy"));
                    listViewRadnik.Items.Add(lvi);

                }
            }
        }


        private void buttonObrišiRadnika_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewRadnik.SelectedItems.Count > 0)
                {
                    string RadnikId = listViewRadnik.SelectedItems[0].Text;

                    SqlConnection conn = cc.conn;
                    conn.Open();
                    String sql = "OBRIŠI_RADNIKA ";
                    SqlCommand sqlCommand = new SqlCommand(sql, conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@RadnikID", RadnikId);
                    sqlCommand.ExecuteNonQuery();


                    sqlCommand.Dispose();
                    conn.Close();

                    PopuniListu();
                    MessageBox.Show("Uspješno ste obrisali radnika sa " +
                      "RadnikId  " + RadnikId);
                }
                else
                {
                    MessageBox.Show("Morate selektovati nekog radnika, ako želite da ga obrišete.");
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPretraži_Click(object sender, EventArgs e)
        {

            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "PRETRAŽI_RADNIKE";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@RadnikID", textBoxRadnikId.Text);
          
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            DataTable dtRadnik = new DataTable();
            while (!sqlDataReader.IsClosed)
            {
                dtRadnik.Load(sqlDataReader);
            }
            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();

            listViewRadnik.Items.Clear();
            listViewRadnik.Refresh();

            ListViewItem lvi;

            if (dtRadnik.Rows.Count != 0)
            {
                foreach (DataRow red in dtRadnik.Rows)
                {
                    lvi = new ListViewItem();
                    lvi.Checked = false;
                    if (red["RadnikID"].ToString() == "")
                        lvi.Text = "";
                    else
                        lvi.Text = red["RadnikID"].ToString();

                    if (red["MjestoID"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["MJESTOID"].ToString());

                    if (red["Ime"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Ime"].ToString());

                    if (red["Prezime"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Prezime"].ToString().Trim());


                    if (red["Br_telefona"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Br_telefona"].ToString().Trim());

                    if (red["Email"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Email"].ToString().Trim());
                    if (red["Adresa"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Adresa"].ToString().Trim());



                    if (red["Datum_rođenja"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(DateTime.Parse(red["Datum_rođenja"].
                            ToString()).ToString("dd.MM.yyyy"));

                    if (red["Datum_zaposlenja"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(DateTime.Parse(red["Datum_zaposlenja"].
                            ToString()).ToString("dd.MM.yyyy"));

                    listViewRadnik.Items.Add(lvi);

                }
            }
        }



        private void textBoxRadnik_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRadnikId.Text == "")
                buttonPretraži.Enabled = false;
            if (textBoxRadnikId.Text != "")
                buttonPretraži.Enabled = true;
        }

        private void textBoxRadnik_Enter(object sender, EventArgs e)
        {
            if (textBoxRadnikId.Text == "Id radnika")
                textBoxRadnikId.Text = "";

            textBoxRadnikId.ForeColor = Color.Black;
        }


        private void IzmijeniRadnika_Click(object sender, EventArgs e)
        {
            if (listViewRadnik.SelectedItems.Count > 0)
            {
                FormIzmjenaRadnika formIzmijeniRadnika = new FormIzmjenaRadnika(Convert.ToInt32(listViewRadnik.SelectedItems[0].Text.ToString()));
                formIzmijeniRadnika.Show();
            }
            else
            {
                MessageBox.Show("Morate selektovati nekog radnika da bi bilo moguće njegovo brisanje.");
            }
        }

        private void buttonOsvježiPodatke_Click(object sender, EventArgs e)
        {
            PopuniListu();
        }




        private void textBoxDatumZaposlenja_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDatumZaposlenja.Text == "")
                buttonPretragaPoDatumu.Enabled = false;
            if (textBoxDatumZaposlenja.Text != "")
                buttonPretragaPoDatumu.Enabled = true;
        }

        private void textBoxDatumZaposlenja_Leave(object sender, EventArgs e)
        {
            if (textBoxDatumZaposlenja.Text == "")
                textBoxDatumZaposlenja.Text = "Datum zaposlenja";

            textBoxDatumZaposlenja.ForeColor = Color.Silver;
        }

        private void textBoxDatumZaposlenja_Enter(object sender, EventArgs e)
        {
            if (textBoxDatumZaposlenja.Text == "Datum zaposlenja")
                textBoxDatumZaposlenja.Text = "";

            textBoxDatumZaposlenja.ForeColor = Color.Black;
        }

        private void buttonPretragaPoDatumu_Click(object sender, EventArgs e)
        {
            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "PRETRAŽI_RADNIKE_PO_DATUMU";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
           

            sqlCommand.Parameters.AddWithValue("@Datum_zaposlenja", DateTime.Parse(textBoxDatumZaposlenja.Text));
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            DataTable dtRadnik = new DataTable();
            while (!sqlDataReader.IsClosed)
            {
                dtRadnik.Load(sqlDataReader);
            }
            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();

            listViewRadnik.Items.Clear();
            listViewRadnik.Refresh();

            ListViewItem lvi;

            if (dtRadnik.Rows.Count != 0)
            {
                foreach (DataRow red in dtRadnik.Rows)
                {
                    lvi = new ListViewItem();
                    lvi.Checked = false;
                    if (red["RadnikID"].ToString() == "")
                        lvi.Text = "";
                    else
                        lvi.Text = red["RadnikID"].ToString();

                    if (red["MjestoID"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["MJESTOID"].ToString());

                    if (red["Ime"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Ime"].ToString());

                    if (red["Prezime"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Prezime"].ToString().Trim());


                    if (red["Br_telefona"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Br_telefona"].ToString().Trim());

                    if (red["Email"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Email"].ToString().Trim());
                    if (red["Adresa"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Adresa"].ToString().Trim());



                    if (red["Datum_rođenja"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(DateTime.Parse(red["Datum_rođenja"].
                            ToString()).ToString("dd.MM.yyyy"));

                    if (red["Datum_zaposlenja"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(DateTime.Parse(red["Datum_zaposlenja"].
                            ToString()).ToString("dd.MM.yyyy"));

                    listViewRadnik.Items.Add(lvi);

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxImePrezime.Text == "")
                buttonPretragaImePrezime.Enabled = false;
            if (textBoxImePrezime.Text != "")
                buttonPretragaImePrezime.Enabled = true;
        }

        private void textBoxImePrezime_Leave(object sender, EventArgs e)
        {
            if (textBoxImePrezime.Text == "")
                textBoxImePrezime.Text = "Ime ili Prezime";

            textBoxImePrezime.ForeColor = Color.Silver;
        }

        private void textBoxImePrezime_Enter(object sender, EventArgs e)
        {
            if (textBoxImePrezime.Text == "Ime ili Prezime")
                textBoxImePrezime.Text = "";

            textBoxImePrezime.ForeColor = Color.Black;
        }

        private void buttonPretragaImePrezime_Click(object sender, EventArgs e)
        {
            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "PRETRAŽI_RADNIKE_PO_IMENU_PREZIMENU";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Ime", textBoxImePrezime.Text);
            sqlCommand.Parameters.AddWithValue("@Prezime", textBoxImePrezime.Text);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            DataTable dtRadnik = new DataTable();
            while (!sqlDataReader.IsClosed)
            {
                dtRadnik.Load(sqlDataReader);
            }
            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();

            listViewRadnik.Items.Clear();
            listViewRadnik.Refresh();

            ListViewItem lvi;

            if (dtRadnik.Rows.Count != 0)
            {
                foreach (DataRow red in dtRadnik.Rows)
                {
                    lvi = new ListViewItem();
                    lvi.Checked = false;
                    if (red["RadnikID"].ToString() == "")
                        lvi.Text = "";
                    else
                        lvi.Text = red["RadnikID"].ToString();

                    if (red["MjestoID"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["MJESTOID"].ToString());

                    if (red["Ime"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Ime"].ToString());

                    if (red["Prezime"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Prezime"].ToString().Trim());


                    if (red["Br_telefona"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Br_telefona"].ToString().Trim());

                    if (red["Email"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Email"].ToString().Trim());
                    if (red["Adresa"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Adresa"].ToString().Trim());



                    if (red["Datum_rođenja"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(DateTime.Parse(red["Datum_rođenja"].
                            ToString()).ToString("dd.MM.yyyy"));

                    if (red["Datum_zaposlenja"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(DateTime.Parse(red["Datum_zaposlenja"].
                            ToString()).ToString("dd.MM.yyyy"));

                    listViewRadnik.Items.Add(lvi);

                }
            }
        }

    }
}


       
    






