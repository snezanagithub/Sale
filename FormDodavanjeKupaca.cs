using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Narudžba
{
    public partial class FormDodavanjeKupaca : Form
    {
        public FormDodavanjeKupaca()
        {
            InitializeComponent();
         //   textBoxKupacId.Enabled = false;
        }
        private int Id_kupca(int id)
        {
            int broj = 0;
            ConnectionClass cc = new ConnectionClass();

            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "SELECT COUNT(*) FROM KUPAC WHERE KupacId=" + id;
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            SqlDataReader sql1 = sqlCommand.ExecuteReader();
            while (sql1.Read())
            {
                broj = Convert.ToInt32(sql1.GetValue(0).ToString());
            }
            conn.Close();
            sql1.Close();
            sqlCommand.Dispose();
            return broj;
        }
     

        private void buttonUnesiKupca_Click(object sender, EventArgs e)
        {
            if ( !string.IsNullOrWhiteSpace(comboBoxDodaj.Text) && !string.IsNullOrWhiteSpace(textBoxIme.Text)
                && !string.IsNullOrWhiteSpace(textBoxPrezime.Text) && !string.IsNullOrWhiteSpace(textBoxAdresa.Text) && !string.IsNullOrWhiteSpace(textBoxJMB.Text)
                && !string.IsNullOrWhiteSpace(textBoxBrojTelefona.Text))
            {
                ConnectionClass cc = new ConnectionClass();
                SqlConnection conn = cc.conn;
                conn.Open();
               
                String sql = "INSERT_KUPAC";
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
               
              //  sqlCommand.Parameters.AddWithValue("@KupacId", textBoxKupacId.Text);
                sqlCommand.Parameters.AddWithValue("@MjestoId", comboBoxDodaj.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@Ime", textBoxIme.Text);
                sqlCommand.Parameters.AddWithValue("@Prezime", textBoxPrezime.Text);
                sqlCommand.Parameters.AddWithValue("@Adresa", textBoxAdresa.Text);
                sqlCommand.Parameters.AddWithValue("@JMB", textBoxJMB.Text);
                sqlCommand.Parameters.AddWithValue("@Broj_telefona", textBoxBrojTelefona.Text);
                /*int broj = Id_kupca(Convert.ToInt32(textBoxKupacId.Text));
                if (broj > 0)
                {
                    MessageBox.Show("Kupac sa ovim id-jem već postoji.");
                }
                else {*/
                    
                    sqlCommand.ExecuteNonQuery();
                    
                    this.Hide();
                 
                    MessageBox.Show("Uspješno ste prijavili novog kupca.");
               // }
                conn.Close();
                sqlCommand.Dispose();



            }
              
            else
            {
                MessageBox.Show("Potrebno je popuniti sve podatke");
            }
        }

       

        private void FormDodavanjeKupaca_Load_1(object sender, EventArgs e)
        {
            ConnectionClass cc = new ConnectionClass();
            SqlConnection conn = cc.conn;
            conn.Open();
            DataTable dataTable = new DataTable("Naziv");
            SqlCommand sqlCommand = new SqlCommand("SELECT MjestoID,Naziv from MJESTO", conn);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);
            comboBoxDodaj.DisplayMember = "Naziv";
            comboBoxDodaj.ValueMember = "MjestoId";

            comboBoxDodaj.DataSource = dataTable;
            comboBoxDodaj.Text = "";
            sqlCommand.Dispose();
            sqlDataReader.Close();
            conn.Close();
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

        private void textBoxBrojTelefona_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+') && (e.KeyChar != ' '))

            {
                e.Handled = true;
            }
        }
    }
}



