using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Narudžba
{
    
    public partial class FormIzmijeniKupca : Form
    {
       
        int id;
        public FormIzmijeniKupca(int KupacID)
        {
            InitializeComponent();
            Mjesto();
            textBoxKupacId.Enabled = false;
            id = KupacID;
            textBoxKupacId.Text = KupacID.ToString();
            PopuniPolja(KupacID);
            
        }
       
        ConnectionClass cc = new ConnectionClass();
        private void PopuniPolja(int id)
        {
            
            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "UČITAJ_KUPCA_PO_ID";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@KupacID", id);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtN = new DataTable();
            while (sqlDataReader.Read())
            {
                comboBoxIzmjena.SelectedValue = sqlDataReader.GetValue(1).ToString();
                textBoxIme.Text = sqlDataReader.GetValue(2).ToString();
                textBoxPrezime.Text = sqlDataReader.GetValue(3).ToString();
                textBoxAdresa.Text = sqlDataReader.GetValue(4).ToString();
                textBoxJMB.Text = sqlDataReader.GetValue(5).ToString();
                textBoxBrojTelefonaKupca.Text = sqlDataReader.GetValue(6).ToString();

            }

            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();
        }

        private void buttonIzmijeniKupca_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(comboBoxIzmjena.Text) && !string.IsNullOrWhiteSpace(textBoxIme.Text)
               && !string.IsNullOrWhiteSpace(textBoxPrezime.Text) && !string.IsNullOrWhiteSpace(textBoxAdresa.Text) && !string.IsNullOrWhiteSpace(textBoxJMB.Text)
               && !string.IsNullOrWhiteSpace(textBoxBrojTelefonaKupca.Text))
                {
                    SqlConnection conn = cc.conn;
                    conn.Open();
                    SqlCommand sqlCommand;
                    String sql = "IZMIJENI_KUPCA";
                    sqlCommand = new SqlCommand(sql, conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@KupacID", id);
                    sqlCommand.Parameters.AddWithValue("@MjestoID", Convert.ToInt32(comboBoxIzmjena.SelectedValue.ToString()));
                    sqlCommand.Parameters.AddWithValue("@Ime", textBoxIme.Text);
                    sqlCommand.Parameters.AddWithValue("@Prezime", textBoxPrezime.Text);
                    sqlCommand.Parameters.AddWithValue("@Adresa", textBoxAdresa.Text);
                    sqlCommand.Parameters.AddWithValue("@JMB", textBoxJMB.Text);
                    sqlCommand.Parameters.AddWithValue("@Broj_telefona", textBoxBrojTelefonaKupca.Text);

                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                    conn.Close();
                    this.Close();
                    MessageBox.Show("Uspješno ste izmijenili podatke o kupcu."); }
                else
                {
                    MessageBox.Show("Morate popuniti sve podatke da bi bila moguća izmjena.");
                    }
                } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        
    }

      /*  private void FormIzmijeniKupca_Load(object sender, EventArgs e)
        {
            ConnectionClass cc = new ConnectionClass();
            SqlConnection conn = cc.conn;
            conn.Open();
            DataTable dataTable = new DataTable("Naziv");
            SqlCommand sqlCommand = new SqlCommand("SELECT MjestoID,Naziv from MJESTO", conn);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);
            comboBoxIzmjena.DisplayMember = "Naziv";
            comboBoxIzmjena.ValueMember = "MjestoId";

            comboBoxIzmjena.DataSource = dataTable;
        
            sqlCommand.Dispose();
            sqlDataReader.Close();
            conn.Close();
        }*/

        private void comboBoxIzmjena_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxIzmjena.SelectedItem != null)
            {
                DataRowView drv = comboBoxIzmjena.SelectedItem as DataRowView;
                Debug.WriteLine("Items:" + drv.Row["Naziv"].ToString());
                Debug.WriteLine("Values:" + drv.Row["MjestoId"]);
                Debug.WriteLine("Values:" + Convert.ToInt32(comboBoxIzmjena.SelectedValue.ToString()));
            }
        }
        public void Mjesto()
        {
            try
            {
                ConnectionClass cc = new ConnectionClass();
                SqlConnection conn = cc.conn;
                string query = "SELECT MjestoId,Naziv from Mjesto";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "MJESTA");
                comboBoxIzmjena.DisplayMember = "Naziv";
                comboBoxIzmjena.ValueMember = "MjestoId";
                comboBoxIzmjena.DataSource = ds.Tables["MJESTA"];
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Greska!");
            }




        }

        private void textBoxIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void textBoxPrezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void textBoxJMB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 43)
            {
                e.Handled = true;
            }
        }

        private void textBoxBrojTelefonaKupca_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+') && (e.KeyChar != ' '))

            {
                e.Handled = true;
            }
        }
    }
}

    

    

