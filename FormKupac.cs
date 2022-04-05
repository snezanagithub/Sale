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
    public partial class FormKupac : Form
    {
        public FormKupac()
        {
            InitializeComponent();
        }
        
        ConnectionClass cc = new ConnectionClass();
       

        private void FormKupac_Load(object sender, EventArgs e)
        {
            PopuniListu();
            buttonPretražiKupca.Enabled = false;
          


        }

        public void PopuniListu()
        {
            
            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "UČITAJ_KUPCE";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtKupac = new DataTable();
            while (!sqlDataReader.IsClosed)
            {
                dtKupac.Load(sqlDataReader);
            }
            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();

            listViewKupac.Items.Clear();
            listViewKupac.Refresh();

            ListViewItem lvi;
            if (dtKupac.Rows.Count != 0)
            {
                foreach (DataRow red in dtKupac.Rows)
                {
                    lvi = new ListViewItem();
                    lvi.Checked = false;
                    if (red["KupacID"].ToString() == "")
                        lvi.Text = "";
                    else
                        lvi.Text = red["KupacID"].ToString();

                    if (red["MjestoID"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["MjestoID"].ToString());

                    if (red["Ime"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Ime"].ToString());

                    if (red["Prezime"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Prezime"].ToString().Trim());

                    if (red["Adresa"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Adresa"].ToString().Trim());
                    if (red["JMB"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["JMB"].ToString().Trim());

                    if (red["Broj_telefona"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Broj_telefona"].ToString().Trim());
                    listViewKupac.Items.Add(lvi);
                }
            }
        }

        private void buttonObrišiKupca_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewKupac.SelectedItems.Count > 0)
                {
                    string KupacId = listViewKupac.SelectedItems[0].Text;

                    SqlConnection conn = cc.conn;
                    conn.Open();
                    String sql = "OBRIŠI_KUPCA";
                    SqlCommand sqlCommand = new SqlCommand(sql, conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@KupacID", KupacId);
                    sqlCommand.ExecuteNonQuery();


                    sqlCommand.Dispose();
                    conn.Close();

                    PopuniListu();
                    MessageBox.Show("Uspješno ste obrisali kupca sa " +
                      "KupacId  " + KupacId);
                }
                else
                {
                    MessageBox.Show("Morate selektovati id kupca da bi bilo moguće njegovo brisanje.");
                } }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPretražiKupca_Click(object sender, EventArgs e)
        {
           
            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "PRETRAŽI_KUPCE";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@KupacId", textBoxKupacId.Text);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            DataTable dtKupac = new DataTable();
            while (!sqlDataReader.IsClosed)
            {
                dtKupac.Load(sqlDataReader);
            }
            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();

            listViewKupac.Items.Clear();
            listViewKupac.Refresh();

            ListViewItem lvi;

            if (dtKupac.Rows.Count != 0)
            {
                foreach (DataRow red in dtKupac.Rows)
                { 
                    lvi = new ListViewItem();
                lvi.Checked = false;
                if (red["KupacID"].ToString() == "")
                    lvi.Text = "";
                else
                    lvi.Text = red["KupacID"].ToString();

                if (red["MjestoID"].ToString() == "")
                    lvi.SubItems.Add("");
                else
                    lvi.SubItems.Add(red["MjestoID"].ToString());

                if (red["Ime"].ToString() == "")
                    lvi.SubItems.Add("");
                else
                    lvi.SubItems.Add(red["Ime"].ToString());

                if (red["Prezime"].ToString() == "")
                    lvi.SubItems.Add("");
                else
                    lvi.SubItems.Add(red["Prezime"].ToString().Trim());

                if (red["Adresa"].ToString() == "")
                    lvi.SubItems.Add("");
                else
                    lvi.SubItems.Add(red["Adresa"].ToString().Trim());
                if (red["JMB"].ToString() == "")
                    lvi.SubItems.Add("");
                else
                    lvi.SubItems.Add(red["JMB"].ToString().Trim());

                if (red["Broj_telefona"].ToString() == "")
                    lvi.SubItems.Add("");
                else
                    lvi.SubItems.Add(red["Broj_telefona"].ToString().Trim());
                listViewKupac.Items.Add(lvi);
            }

        } }

        private void textBoxKupacId_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKupacId.Text == "")
                buttonPretražiKupca.Enabled = false;
            if (textBoxKupacId.Text != "")
                buttonPretražiKupca.Enabled = true;
        }
       
       

        private void buttonOsvježiPodatkeKupca_Click(object sender, EventArgs e)
        {
            PopuniListu();
        }

        private void IzmijeniKupca_Click(object sender, EventArgs e)
        {
            if (listViewKupac.SelectedItems.Count > 0)
            {
                FormIzmijeniKupca formIzmijeniKupca = new FormIzmijeniKupca(Convert.ToInt32(listViewKupac.SelectedItems[0].Text.ToString()));
                formIzmijeniKupca.Show();
            }
            else
            {
                MessageBox.Show("Morate selektovati nekog kupca da bi bila moguća njegova izmjena.");
            }
        }

        private void textBoxKupacId_Leave(object sender, EventArgs e)
        {
            if (textBoxKupacId.Text == "")
                textBoxKupacId.Text = "Id kupca";

            textBoxKupacId.ForeColor = Color.Silver;
        }

        private void textBoxKupacId_Enter(object sender, EventArgs e)
        {
            if (textBoxKupacId.Text == "Id kupca")
                textBoxKupacId.Text = "";

            textBoxKupacId.ForeColor = Color.Black;
        }

        private void textBoxImePrezime_TextChanged(object sender, EventArgs e)
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
            String sql = "PRETRAŽI_KUPCE_IME_PREZIME";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Ime", textBoxImePrezime.Text);
            sqlCommand.Parameters.AddWithValue("@Prezime", textBoxImePrezime.Text);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            DataTable dtKupac = new DataTable();
            while (!sqlDataReader.IsClosed)
            {
                dtKupac.Load(sqlDataReader);
            }
            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();

            listViewKupac.Items.Clear();
            listViewKupac.Refresh();

            ListViewItem lvi;

            if (dtKupac.Rows.Count != 0)
            {
                foreach (DataRow red in dtKupac.Rows)
                {
                    lvi = new ListViewItem();
                    lvi.Checked = false;
                    if (red["KupacID"].ToString() == "")
                        lvi.Text = "";
                    else
                        lvi.Text = red["KupacID"].ToString();

                    if (red["MjestoID"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["MjestoID"].ToString());

                    if (red["Ime"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Ime"].ToString());

                    if (red["Prezime"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Prezime"].ToString().Trim());

                    if (red["Adresa"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Adresa"].ToString().Trim());
                    if (red["JMB"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["JMB"].ToString().Trim());

                    if (red["Broj_telefona"].ToString() == "")
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add(red["Broj_telefona"].ToString().Trim());
                    listViewKupac.Items.Add(lvi);
                }

            }
        }

    }
}
