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
    public partial class FormNarudžba : Form
    {
        public FormNarudžba()
        {
            InitializeComponent();
        }
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-58VR9SD;Initial Catalog=Narudžba;Integrated Security=True");
        ConnectionClass cc = new ConnectionClass();
    
        private void FormNarudžba_Load(object sender, EventArgs e)
        {
            PopuniListu();
            buttonPretražiNarudžbe.Enabled = false;
        }
        public void PopuniListu()
        {
            
            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "UČITAJ_NARUDŽBE";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtNarudžba = new DataTable();
            while (!sqlDataReader.IsClosed)
            {
                dtNarudžba.Load(sqlDataReader);
            }
            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();

            listViewNarudžba.Items.Clear();
            listViewNarudžba.Refresh();

            ListViewItem lvi;
            if (dtNarudžba.Rows.Count != 0)
            {
                foreach (DataRow red in dtNarudžba.Rows)
                {
                    lvi = new ListViewItem();
                    lvi.Checked = false;
                    if (red["NarudžbaID"].ToString() == "")
                        lvi.Text = "";
                    else
                        lvi.Text = red["NarudžbaID"].ToString();

                    if (red["Tip_plaćanjaID"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Tip_plaćanjaID"].ToString());

                    if (red["RadnikID"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["RadnikID"].ToString());

                    if (red["KupacID"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["KupacID"].ToString().Trim());
                    if (red["Datum_nastanka"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(DateTime.Parse(red["Datum_nastanka"].
                            ToString()).ToString("dd.MM.yyyy"));



                    if (red["Status"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Status"].ToString().Trim());

                    if (red["IznosBezPdv"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["IznosBezPdv"].ToString().Trim());


                    if (red["Pdv"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Pdv"].ToString().Trim());

                    if (red["IznosSaPdv"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["IznosSaPdv"].ToString().Trim());

                    listViewNarudžba.Items.Add(lvi);
                    conn.Close();
                }
            }
        }

        private void buttonObrišiNarudžbu_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewNarudžba.SelectedItems.Count > 0)
                {
                    string NarudžbaId = listViewNarudžba.SelectedItems[0].Text;
                    
                    SqlConnection conn = cc.conn;
                    conn.Open();
                    String sql = "OBRIŠI_NARUDŽBU";
                    SqlCommand sqlCommand = new SqlCommand(sql, conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@NarudžbaID", NarudžbaId);
                    sqlCommand.ExecuteNonQuery();


                    sqlCommand.Dispose();
                    conn.Close();

                    PopuniListu();
                    MessageBox.Show("Uspješno ste obrisali narudžbu sa " +
                      "NarudžbaID " + NarudžbaId);
                }
                else
                {
                    MessageBox.Show("Morate selektovati neku narudžbu, ako želite da je obrišete.");
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPretražiNarudžbe_Click(object sender, EventArgs e)
        {
           
            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "PRETRAŽI_NARUDŽBE";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@NarudžbaId", textBoxNarudžbaID.Text);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            DataTable dtNarudžba = new DataTable();
            while (!sqlDataReader.IsClosed)
            {
                dtNarudžba.Load(sqlDataReader);
            }
            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();

            listViewNarudžba.Items.Clear();
            listViewNarudžba.Refresh();

            ListViewItem lvi;

            if (dtNarudžba.Rows.Count != 0)
            {
                foreach (DataRow red in dtNarudžba.Rows)
                {
                    lvi = new ListViewItem();
                    lvi.Checked = false;
                    if (red["NarudžbaID"].ToString() == "")
                        lvi.Text = "";
                    else
                        lvi.Text = red["NarudžbaID"].ToString();

                    if (red["Tip_plaćanjaID"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Tip_plaćanjaID"].ToString());

                    if (red["RadnikID"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["RadnikID"].ToString());

                    if (red["KupacID"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["KupacID"].ToString().Trim());

                    if (red["Datum_nastanka"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(DateTime.Parse(red["Datum_nastanka"].
                            ToString()).ToString("dd.MM.yyyy"));


                    if (red["Status"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Status"].ToString().Trim());

                    if (red["IznosBezPdv"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["IznosBezPdv"].ToString().Trim());


                    if (red["Pdv"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Pdv"].ToString().Trim());

                    if (red["IznosSaPdv"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["IznosSaPdv"].ToString().Trim());

                    listViewNarudžba.Items.Add(lvi);

                }
            }
        }

        private void textBoxNarudžbaID_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNarudžbaID.Text == "")
                buttonPretražiNarudžbe.Enabled = false;
            if (textBoxNarudžbaID.Text != "")
                buttonPretražiNarudžbe.Enabled = true;
        }

        private void textBoxNarudžbaID_Enter(object sender, EventArgs e)
        {
            if (textBoxNarudžbaID.Text == "Id narudžbe")
                textBoxNarudžbaID.Text = "";

            textBoxNarudžbaID.ForeColor = Color.Black;
        }

        private void textBoxNarudžbaID_Leave(object sender, EventArgs e)
        {
            if (textBoxNarudžbaID.Text == "")
                textBoxNarudžbaID.Text = "Id narudžbe";

            textBoxNarudžbaID.ForeColor = Color.Silver;
        }

         
        private void buttonOsvježiPodatke_Click(object sender, EventArgs e)
        {
            PopuniListu();
        }

        private void IzmijeniNarudžbu_Click_1(object sender, EventArgs e)
        {
            if (listViewNarudžba.SelectedItems.Count > 0)
            {
                FormIzmijeniNarudžbu formIzmijeniNarudžbu = new FormIzmijeniNarudžbu(Convert.ToInt32(listViewNarudžba.SelectedItems[0].Text.ToString()));
                formIzmijeniNarudžbu.Show();
            }
            else
            {
                MessageBox.Show("Morate selektovati neku narudžbu da bi bila moguća njena izmjena.");
            }
        }

        private void textBoxPretragaDatum_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPretragaDatum.Text == "")
                buttonPretragaDatum.Enabled = false;
            if (textBoxPretragaDatum.Text != "")
                buttonPretragaDatum.Enabled = true;
        }

       

        private void textBoxPretragaDatum_Leave(object sender, EventArgs e)
        {
            if (textBoxPretragaDatum.Text == "")
                textBoxPretragaDatum.Text = "Datum nastanka";

            textBoxPretragaDatum.ForeColor = Color.Silver;
        }

        private void textBoxPretragaDatum_Enter(object sender, EventArgs e)
        {
            if (textBoxPretragaDatum.Text == "Datum nastanka")
                textBoxPretragaDatum.Text = "";

            textBoxPretragaDatum.ForeColor = Color.Black;
        }

        private void buttonPretragaDatum_Click(object sender, EventArgs e)
        {
            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "PRETRAŽI_NARUDŽBU_PO_DATUMU";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Datum_nastanka", DateTime.Parse(textBoxPretragaDatum.Text));
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            DataTable dtNarudžba = new DataTable();
            while (!sqlDataReader.IsClosed)
            {
                dtNarudžba.Load(sqlDataReader);
            }
            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();

            listViewNarudžba.Items.Clear();
            listViewNarudžba.Refresh();

            ListViewItem lvi;

            if (dtNarudžba.Rows.Count != 0)
            {
                foreach (DataRow red in dtNarudžba.Rows)
                {
                    lvi = new ListViewItem();
                    lvi.Checked = false;
                    if (red["NarudžbaID"].ToString() == "")
                        lvi.Text = "";
                    else
                        lvi.Text = red["NarudžbaID"].ToString();
                    if (red["Tip_plaćanjaID"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Tip_plaćanjaID"].ToString());

                    if (red["RadnikID"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["RadnikID"].ToString());

                    if (red["KupacID"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["KupacID"].ToString().Trim());

                    if (red["Datum_nastanka"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(DateTime.Parse(red["Datum_nastanka"].
                            ToString()).ToString("dd.MM.yyyy"));


                    if (red["Status"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Status"].ToString().Trim());

                    if (red["IznosBezPdv"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["IznosBezPdv"].ToString().Trim());


                    if (red["Pdv"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Pdv"].ToString().Trim());
                    if (red["IznosSaPdv"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["IznosSaPdv"].ToString().Trim());

                    listViewNarudžba.Items.Add(lvi);

                }
            }
        }


    }
}
