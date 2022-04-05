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
    public partial class FormStavkeNarudžbe : Form
    {
        public FormStavkeNarudžbe()
        {
            InitializeComponent();
        }
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-58VR9SD;Initial Catalog=Narudžba;Integrated Security=True");
        ConnectionClass cc = new ConnectionClass();

        private void FormStavkeNarudžbe_Load(object sender, EventArgs e)
        {
            PopuniListu();
            buttonPretražiStavkeNarudžbe.Enabled = false;
        }
        public void PopuniListu()
        {

            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "UČITAJ_STAVKE_NARUDŽBE";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtNarudžba_Proizvod = new DataTable();
            while (!sqlDataReader.IsClosed)
            {
                dtNarudžba_Proizvod.Load(sqlDataReader);
            }
            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();

            listViewStavkeNarudžbe.Items.Clear();
            listViewStavkeNarudžbe.Refresh();
            ListViewItem lvi;
            if (dtNarudžba_Proizvod.Rows.Count != 0)
            {
                foreach (DataRow red in dtNarudžba_Proizvod.Rows)
                {
                    lvi = new ListViewItem();
                    lvi.Checked = false;
                    if (red["Narudžba_ProizvodId"].ToString() == "")
                        lvi.Text = "";
                    else
                        lvi.Text = red["Narudžba_ProizvodId"].ToString();

                    if (red["NarudžbaId"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["NarudžbaId"].ToString());

                    if (red["ProizvodID"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["ProizvodID"].ToString());

                    if (red["Količina"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Količina"].ToString());

                    if (red["Cijena"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Cijena"].ToString());
                    listViewStavkeNarudžbe.Items.Add(lvi);
                    conn.Close();
                }
            }
        }

        private void buttonObrišiStavkuNarudžbe_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewStavkeNarudžbe.SelectedItems.Count > 0)
                {
                    string NarudžbaId = listViewStavkeNarudžbe.SelectedItems[0].Text;

                    SqlConnection conn = cc.conn;
                    conn.Open();
                    String sql = "OBRIŠI_STAVKE_NARUDŽBE";
                    SqlCommand sqlCommand = new SqlCommand(sql, conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Narudžba_ProizvodId", NarudžbaId);
                    sqlCommand.ExecuteNonQuery();


                    sqlCommand.Dispose();
                    conn.Close();

                    PopuniListu();
                    MessageBox.Show("Uspješno ste obrisali stavku narudžbe .");
                    //  "Narudžba_ProizvodID "  + Narudžba_ProizvodID);
                }
                else
                {
                    MessageBox.Show("Morate selektovati neku stavku narudžbe, ako želite da je obrišete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPretražiStavkeNarudžbe_Click(object sender, EventArgs e)
        {

            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "PRETRAŽI_STAVKE_NARUDŽBE";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Narudžba_ProizvodId", textBoxNarudžbaProizvodID.Text);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            DataTable dtNarudžba_Proizvod = new DataTable();
            while (!sqlDataReader.IsClosed)
            {
                dtNarudžba_Proizvod.Load(sqlDataReader);
            }
            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();

            listViewStavkeNarudžbe.Items.Clear();
            listViewStavkeNarudžbe.Refresh();

            ListViewItem lvi;

            if (dtNarudžba_Proizvod.Rows.Count != 0)
            {
                foreach (DataRow red in dtNarudžba_Proizvod.Rows)
                {
                    lvi = new ListViewItem();
                    lvi.Checked = false;
                    if (red["Narudžba_ProizvodId"].ToString() == "")
                        lvi.Text = "";
                    else
                        lvi.Text = red["Narudžba_ProizvodId"].ToString();

                    if (red["NarudžbaId"].ToString() == "")
                        lvi.SubItems.Add(" ");
                    else
                        lvi.SubItems.Add(red["NarudžbaId"].ToString());

                    if (red["ProizvodID"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["ProizvodID"].ToString());

                    if (red["Količina"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Količina"].ToString());

                    if (red["Cijena"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Cijena"].ToString());
                    listViewStavkeNarudžbe.Items.Add(lvi);
                    conn.Close();
                }
            }
        }

        private void textBoxNarudžbaProizvodID_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNarudžbaProizvodID.Text == "")
                buttonPretražiStavkeNarudžbe.Enabled = false;
            if (textBoxNarudžbaProizvodID.Text != "")
                buttonPretražiStavkeNarudžbe.Enabled = true;
        }



        private void textBoxNarudžbaProizvodID_Enter(object sender, EventArgs e)
        {
            if (textBoxNarudžbaProizvodID.Text == "Id stavke")
                textBoxNarudžbaProizvodID.Text = "";

            textBoxNarudžbaProizvodID.ForeColor = Color.Black;
        }

        private void textBoxNarudžbaProizvodID_Leave(object sender, EventArgs e)
        {
            if (textBoxNarudžbaProizvodID.Text == "")
                textBoxNarudžbaProizvodID.Text = "Id stavke";

            textBoxNarudžbaProizvodID.ForeColor = Color.Silver;
        }

        private void buttonOsvježiPodatke_Click(object sender, EventArgs e)
        {
            PopuniListu();
        }

        private void IzmijeniStavkeNarudžbe_Click(object sender, EventArgs e)
        {
            if (listViewStavkeNarudžbe.SelectedItems.Count > 0)
            {
                FormIzmijeniStavkeNarudžbe formIzmijeniStavkeNarudžbe = new FormIzmijeniStavkeNarudžbe(Convert.ToInt32(listViewStavkeNarudžbe.SelectedItems[0].Text.ToString()));
                formIzmijeniStavkeNarudžbe.Show();
            }
            else
            {
                MessageBox.Show("Morate selektovati neku stavku narudžbe da bi bilo moguća njena izmjena.");
            }
        }

        private void buttonPretraga_Click(object sender, EventArgs e)
        {
            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "PRETRAŽI_STAVKE_NARUDŽBE_PO_CIJENI";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Cijena", decimal.Parse(textBoxCijena.Text));
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            DataTable dtNarudžba_Proizvod = new DataTable();
            while (!sqlDataReader.IsClosed)
            {
                dtNarudžba_Proizvod.Load(sqlDataReader);
            }
            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();

            listViewStavkeNarudžbe.Items.Clear();
            listViewStavkeNarudžbe.Refresh();

            ListViewItem lvi;

            if (dtNarudžba_Proizvod.Rows.Count != 0)
            {
                foreach (DataRow red in dtNarudžba_Proizvod.Rows)
                {
                    lvi = new ListViewItem();
                    lvi.Checked = false;
                    if (red["Narudžba_ProizvodId"].ToString() == "")
                        lvi.Text = "";
                    else
                        lvi.Text = red["Narudžba_ProizvodId"].ToString();

                    if (red["NarudžbaId"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["NarudžbaId"].ToString());

                    if (red["ProizvodID"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["ProizvodID"].ToString());

                    if (red["Količina"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Količina"].ToString());

                    if (red["Cijena"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Cijena"].ToString());
                    listViewStavkeNarudžbe.Items.Add(lvi);
                    conn.Close();
                }
            }
        }

        private void textBoxCijena_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCijena.Text == "")
                buttonPretraga.Enabled = false;
            if (textBoxCijena.Text != "")
                buttonPretraga.Enabled = true;
        }

        private void textBoxCijena_Leave(object sender, EventArgs e)
        {
            if (textBoxCijena.Text == "")
                textBoxCijena.Text = "Cijena";

            textBoxCijena.ForeColor = Color.Silver;

        }

        private void textBoxCijena_Enter(object sender, EventArgs e)
        {
            if (textBoxCijena.Text == "Cijena")
                textBoxCijena.Text = "";

            textBoxCijena.ForeColor = Color.Black;
        }
    }
    }



