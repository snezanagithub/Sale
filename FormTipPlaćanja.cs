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
    public partial class FormTipPlaćanja : Form
    {
        public FormTipPlaćanja()
        {
            InitializeComponent();
        }
        // SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-58VR9SD;Initial Catalog=Narudžba;Integrated Security=True");
        ConnectionClass cc = new ConnectionClass();
      

        private void FormTipPlaćanja_Load(object sender, EventArgs e)
        {
            PopuniListu();
            buttonPretražiTipovePlaćanja.Enabled = false;
        }
        public void PopuniListu()
        {
           
            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "UČITAJ_TIP_PLAĆANJA";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtTipPlaćanja = new DataTable();
            while (!sqlDataReader.IsClosed)
            {
                dtTipPlaćanja.Load(sqlDataReader);
            }
            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();

            listViewTipPlaćanja.Items.Clear();
            listViewTipPlaćanja.Refresh();

            ListViewItem lvi;
            if (dtTipPlaćanja.Rows.Count != 0)
            {
                foreach (DataRow red in dtTipPlaćanja.Rows)
                {
                    lvi = new ListViewItem();
                    lvi.Checked = false;
                    if (red["Tip_plaćanjaID"].ToString() == "")
                        lvi.Text = "";
                    else
                        lvi.Text = red["Tip_plaćanjaID"].ToString();
                    if (red["Naziv"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Naziv"].ToString());
                    listViewTipPlaćanja.Items.Add(lvi);

                }
            }
        }

        private void textBoxTipPlaćanjaID_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTipPlaćanjaID.Text == "")
                buttonPretražiTipovePlaćanja.Enabled = false;
            if (textBoxTipPlaćanjaID.Text != "")
                buttonPretražiTipovePlaćanja.Enabled = true;
        }
        private void textBoxTipPlaćanjaID_Enter(object sender, EventArgs e)
        {
            if (textBoxTipPlaćanjaID.Text == "Tip_plaćanjaID")
                textBoxTipPlaćanjaID.Text = "";

            textBoxTipPlaćanjaID.ForeColor = Color.Black;
        }

        private void textBoxTipPlaćanjaID_Leave(object sender, EventArgs e)
        {
            if (textBoxTipPlaćanjaID.Text == "")
                textBoxTipPlaćanjaID.Text = "Tip_plaćanjaID";

            textBoxTipPlaćanjaID.ForeColor = Color.Silver;
        }

        private void buttonPretražiTipovePlaćanja_Click(object sender, EventArgs e)
        {
           
            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "PRETRAŽI_TIP_PLAĆANJA";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Tip_plaćanja", textBoxTipPlaćanjaID.Text);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtTipPlaćanja = new DataTable();
            while (!sqlDataReader.IsClosed)
            {
                dtTipPlaćanja.Load(sqlDataReader);
            }
            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();

            listViewTipPlaćanja.Items.Clear();
            listViewTipPlaćanja.Refresh();

            ListViewItem lvi;
            if (dtTipPlaćanja.Rows.Count != 0)
            {
                foreach (DataRow red in dtTipPlaćanja.Rows)
                {
                    lvi = new ListViewItem();
                    lvi.Checked = false;
                    if (red["Tip_plaćanjaID"].ToString() == "")
                        lvi.Text = "";
                    else
                        lvi.Text = red["Tip_plaćanjaID"].ToString();
                    if (red["Naziv"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Naziv"].ToString());
                    listViewTipPlaćanja.Items.Add(lvi);


                }
            }
        }

        private void IzmijeniTipPlaćanja_Click(object sender, EventArgs e)
        {
            if (listViewTipPlaćanja.SelectedItems.Count > 0)
            {
                FormIzmijeniTipPlaćanja formIzmijeniTipPlaćanja = new FormIzmijeniTipPlaćanja(Convert.ToInt32(listViewTipPlaćanja.SelectedItems[0].Text));
                formIzmijeniTipPlaćanja.Show(); }
            else
            {
                MessageBox.Show("Morate selektovati neki tip da bi ga mogli izmijeniti.");
            }
        }

        private void buttonObrišiTipPlaćanja_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewTipPlaćanja.SelectedItems.Count > 0)
                {
                    string Tip_plaćanjaID = listViewTipPlaćanja.SelectedItems[0].Text;

                    SqlConnection conn = cc.conn;
                    conn.Open();
                    String sql = "OBRIŠI_TIP_PLAĆANJA ";
                    SqlCommand sqlCommand = new SqlCommand(sql, conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Tip_plaćanjaID", Tip_plaćanjaID);
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                    conn.Close();
                    PopuniListu();
                    MessageBox.Show("Uspješno ste obrisali tip plaćanja sa " +
                      "Tip_plaćanjaID" + Tip_plaćanjaID);
                }
                else
                {
                    MessageBox.Show("Morate selektovati tip plaćanja koji želite da obrišete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonOsvježiPodatkeTip_Click(object sender, EventArgs e)
        {
            PopuniListu();
        }

       
    }
}