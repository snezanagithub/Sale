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
    public partial class FormProizvod : Form
    {
        public FormProizvod()
        {
            InitializeComponent();
        }

        // SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-58VR9SD;Initial Catalog=Narudžba;Integrated Security=True");
        ConnectionClass cc = new ConnectionClass();
      
        private void FormProizvod_Load(object sender, EventArgs e)
        {
            PopuniListu();
            buttonPretražiProizvode.Enabled = false;
        }
        public void PopuniListu()
        {
           
            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "UČITAJ_PROIZVODE";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtProizvod = new DataTable();
            while (!sqlDataReader.IsClosed)
            {
                dtProizvod.Load(sqlDataReader);
            }
            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();

            listViewProizvod.Items.Clear();
            listViewProizvod.Refresh();

            ListViewItem lvi;
            if (dtProizvod.Rows.Count != 0)
            {
                foreach (DataRow red in dtProizvod.Rows)
                {
                    lvi = new ListViewItem();
                    lvi.Checked = false;
                    if (red["ProizvodID"].ToString() == "")
                        lvi.Text = "";
                    else
                        lvi.Text = red["ProizvodID"].ToString();

                    if (red["Naziv"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Naziv"].ToString());
                    if (red["Cijena"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Cijena"].ToString().Trim());

                    if (red["PdvStopa"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["PdvStopa"].ToString().Trim());
                    listViewProizvod.Items.Add(lvi);
                }
            }
        }

        private void buttonObrišiProizvod_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewProizvod.SelectedItems.Count > 0)
                {
                    string KupacId = listViewProizvod.SelectedItems[0].Text;

                    SqlConnection conn = cc.conn;
                    conn.Open();
                    String sql = "OBRIŠI_PROIZVOD";
                    SqlCommand sqlCommand = new SqlCommand(sql, conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ProizvodID", KupacId);
                    sqlCommand.ExecuteNonQuery();


                    sqlCommand.Dispose();
                    conn.Close();

                    PopuniListu();
                    MessageBox.Show("Uspješno ste obrisali proizvod.");
                   //  "ProizvodID " + ProizvodId);
                }
                else
                {
                    MessageBox.Show("Morate selektovani proizvod koji želite obrisati.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPretražiProizvode_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "PRETRAŽI_PROIZVODE";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@ProizvodId", textBoxProizvodId.Text);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            DataTable dtProizvod = new DataTable();
            while (!sqlDataReader.IsClosed)
            {
                dtProizvod.Load(sqlDataReader);
            }
            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();

            listViewProizvod.Items.Clear();
            listViewProizvod.Refresh();

            ListViewItem lvi;

            if (dtProizvod.Rows.Count != 0)
            {
                foreach (DataRow red in dtProizvod.Rows)
                {
                    lvi = new ListViewItem();
                    lvi.Checked = false;
                    if (red["ProizvodID"].ToString() == "")
                        lvi.Text = "";
                    else
                        lvi.Text = red["ProizvodID"].ToString();

                    if (red["Naziv"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Naziv"].ToString());
                    if (red["Cijena"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Cijena"].ToString().Trim());

                    if (red["PdvStopa"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["PdvStopa"].ToString().Trim());
                    listViewProizvod.Items.Add(lvi);
                }
            }
        }

        private void textBoxProizvodId_TextChanged(object sender, EventArgs e)
        {
            if (textBoxProizvodId.Text == "")
                buttonPretražiProizvode.Enabled = false;
            if (textBoxProizvodId.Text != "")
                buttonPretražiProizvode.Enabled = true;
        }
       
       
        private void buttonOsvježiPodatkeProizvod_Click(object sender, EventArgs e)
        {
            PopuniListu();
        }

        private void IzmijeniProizvod_Click(object sender, EventArgs e)
        {
            if (listViewProizvod.SelectedItems.Count > 0)
            {
                FormIzmijeniProizvod formIzmijeniProizvod = new FormIzmijeniProizvod(Convert.ToInt32(listViewProizvod.SelectedItems[0].Text.ToString()));
                formIzmijeniProizvod.Show();
            }
            else
            {
                MessageBox.Show("Morate selektovati neki proizvod da bi bila moguća njegova izmjena.");
            }

        }

        private void textBoxProizvodId_Leave(object sender, EventArgs e)
        {
            if (textBoxProizvodId.Text == "")
                textBoxProizvodId.Text = "Id proizvoda";

            textBoxProizvodId.ForeColor = Color.Silver;
        }

        private void textBoxProizvodId_Enter(object sender, EventArgs e)
        {

            if (textBoxProizvodId.Text == "Id proizvoda")
                textBoxProizvodId.Text = "";

            textBoxProizvodId.ForeColor = Color.Black;
        }

        private void textBoxNaziv_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNaziv.Text == "")
                buttonPretragaNaziv.Enabled = false;
            if (textBoxNaziv.Text != "")
                buttonPretragaNaziv.Enabled = true;
        }

        private void textBoxNaziv_Leave(object sender, EventArgs e)
        {
            if (textBoxNaziv.Text == "")
                textBoxNaziv.Text = "Naziv";

            textBoxNaziv.ForeColor = Color.Silver;
        }

        private void textBoxNaziv_Enter(object sender, EventArgs e)
        {
            if (textBoxNaziv.Text == "Naziv")
                textBoxNaziv.Text = "";

            textBoxNaziv.ForeColor = Color.Black;
        }

        private void buttonPretragaNaziv_Click(object sender, EventArgs e)
        {
            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "PRETRAŽI_PROIZVODE_PO_NAZIVU";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Naziv", textBoxNaziv.Text);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            DataTable dtProizvod = new DataTable();
            while (!sqlDataReader.IsClosed)
            {
                dtProizvod.Load(sqlDataReader);
            }
            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();

            listViewProizvod.Items.Clear();
            listViewProizvod.Refresh();

            ListViewItem lvi;

            if (dtProizvod.Rows.Count != 0)
            {
                foreach (DataRow red in dtProizvod.Rows)
                {
                    lvi = new ListViewItem();
                    lvi.Checked = false;
                    if (red["ProizvodID"].ToString() == "")
                        lvi.Text = "";
                    else
                        lvi.Text = red["ProizvodID"].ToString();
                    if (red["Naziv"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Naziv"].ToString());
                    if (red["Cijena"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Cijena"].ToString().Trim());

                    if (red["PdvStopa"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["PdvStopa"].ToString().Trim());
                    listViewProizvod.Items.Add(lvi);
                }
            }
        }
    }
            }
