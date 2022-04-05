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
    public partial class FormMjesto : Form
    {
        public FormMjesto()
        {
            InitializeComponent();
        }
        // SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-58VR9SD;Initial Catalog=Narudžba;Integrated Security=True");
        ConnectionClass cc = new ConnectionClass();

        private void FormMjesto_Load(object sender, EventArgs e)
        {
            PopuniListu();
            buttonPretraži.Enabled = false;
        }

        public void PopuniListu()
        {

            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "UČITAJ_MJESTO";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtMjesto = new DataTable();
            while (!sqlDataReader.IsClosed)
            {
                dtMjesto.Load(sqlDataReader);
            }
            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();

            listViewMjesto.Items.Clear();
            listViewMjesto.Refresh();

            ListViewItem lvi;
            if (dtMjesto.Rows.Count != 0)
            {
                foreach (DataRow red in dtMjesto.Rows)
                {
                    lvi = new ListViewItem();
                    lvi.Checked = false;
                    if (red["MjestoID"].ToString() == "")
                        lvi.Text = "";
                    else
                        lvi.Text = red["MjestoID"].ToString();

                    if (red["Naziv"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Naziv"].ToString());
                    listViewMjesto.Items.Add(lvi);

                }
            }
        }

        private void textBoxMjesto_Enter(object sender, EventArgs e)
        {
            if (textBoxMjesto.Text == "Id mjesta")
                textBoxMjesto.Text = "";

            textBoxMjesto.ForeColor = Color.Black;
        }

        private void textBoxMjesto_Leave(object sender, EventArgs e)
        {
            if (textBoxMjesto.Text == "")
                textBoxMjesto.Text = "Id mjesta";

            textBoxMjesto.ForeColor = Color.Silver;
        }





        private void buttonPretraži_Click_1(object sender, EventArgs e)
        {

            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "PRETRAŽI_MJESTO";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@MjestoID", textBoxMjesto.Text);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtMjesto = new DataTable();
            while (!sqlDataReader.IsClosed)
            {
                dtMjesto.Load(sqlDataReader);
            }
            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();

            listViewMjesto.Items.Clear();
            listViewMjesto.Refresh();

            ListViewItem lvi;
            if (dtMjesto.Rows.Count != 0)
            {
                foreach (DataRow red in dtMjesto.Rows)
                {
                    lvi = new ListViewItem();
                    lvi.Checked = false;
                    if (red["MjestoID"].ToString() == "")
                        lvi.Text = "";
                    else
                        lvi.Text = red["MjestoID"].ToString();

                    if (red["Naziv"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Naziv"].ToString());
                    listViewMjesto.Items.Add(lvi);
                }
            }
        }
        private void IzmijeniMjesto_Click(object sender, EventArgs e)
        {
            if (listViewMjesto.SelectedItems.Count > 0)
            {
                FormIzmijeniMjesto formIzmijeniMjesto = new FormIzmijeniMjesto(Convert.ToInt32(listViewMjesto.SelectedItems[0].Text));
                formIzmijeniMjesto.Show();
            }
            else
            {
                MessageBox.Show("Morate selektovati neko mjesto da bi bila moguća njegova izmjena.");
            }

        }

        private void buttonObrišiMjesto_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (listViewMjesto.SelectedItems.Count > 0)
                {
                    string MjestoID = listViewMjesto.SelectedItems[0].Text;


                    SqlConnection conn = cc.conn;
                    conn.Open();
                    String sql = "OBRIŠI_MJESTO ";
                    SqlCommand sqlCommand = new SqlCommand(sql, conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@MjestoID", MjestoID);
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                    conn.Close();
                    PopuniListu();
                    MessageBox.Show("Uspješno ste obrisali mjesto sa " +
                      "MjestoId " + MjestoID);
                }
                else
                {
                    MessageBox.Show("Morate selektovati mjesto koje želite da obrišete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxMjesto_TextChanged_1(object sender, EventArgs e)
        {
            if (textBoxMjesto.Text == "")
                buttonPretraži.Enabled = false;
            if (textBoxMjesto.Text != "")
                buttonPretraži.Enabled = true;
        }

        private void buttonOsvježiPodatke_Click_1(object sender, EventArgs e)
        {
            PopuniListu();
        }

        private void textBoxNazivMjesta_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNazivMjesta.Text == "")
                buttonPretragaNaziv.Enabled = false;
            if (textBoxNazivMjesta.Text != "")
                buttonPretragaNaziv.Enabled = true;
        }

        private void textBoxNazivMjesta_Leave(object sender, EventArgs e)
        {
            if (textBoxNazivMjesta.Text == "")
                textBoxNazivMjesta.Text = "Naziv";

            textBoxNazivMjesta.ForeColor = Color.Silver;
        }

        private void textBoxNazivMjesta_Enter(object sender, EventArgs e)
        {
            if (textBoxNazivMjesta.Text == "Naziv")
                textBoxNazivMjesta.Text = "";

            textBoxNazivMjesta.ForeColor = Color.Black;
        }

        private void buttonPretragaNaziv_Click(object sender, EventArgs e)
        {
            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "PRETRAŽI_MJESTA_PO_NAZIVU";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Naziv", textBoxNazivMjesta.Text);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtMjesto = new DataTable();
            while (!sqlDataReader.IsClosed)
            {
                dtMjesto.Load(sqlDataReader);
            }
            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();

            listViewMjesto.Items.Clear();
            listViewMjesto.Refresh();

            ListViewItem lvi;
            if (dtMjesto.Rows.Count != 0)
            {
                foreach (DataRow red in dtMjesto.Rows)
                {
                    lvi = new ListViewItem();
                    lvi.Checked = false;
                    if (red["MjestoID"].ToString() == "")
                        lvi.Text = "";
                    else
                        lvi.Text = red["MjestoID"].ToString();

                    if (red["Naziv"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Naziv"].ToString());
                    listViewMjesto.Items.Add(lvi);
                }
            }
        }
    }
}









