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
    public partial class FormIzmijeniProizvod : Form
    {
        int id;

        public FormIzmijeniProizvod(int ProizvodID)
        {
            InitializeComponent();
            textBoxProizvodId.Enabled = false;
            id = ProizvodID;
            textBoxProizvodId.Text = ProizvodID.ToString();
            PopuniPolja(ProizvodID);
        }

        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-58VR9SD;Initial Catalog=Narudžba;Integrated Security=True");
        ConnectionClass cc = new ConnectionClass();
     
        private void PopuniPolja(int id)
        {
            
            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "UČITAJ_PROIZVOD_PO_ID";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@ProizvodID", id);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                textBoxNaziv.Text = sqlDataReader.GetValue(1).ToString();
                textBoxCijena.Text = sqlDataReader.GetValue(2).ToString();
                textBoxPdvStopa.Text = sqlDataReader.GetValue(3).ToString();
            }

            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();
        }

        private void buttonIzmijeniProizvod_Click(object sender, EventArgs e)
        {

            try
            {
                if ( !string.IsNullOrWhiteSpace(textBoxNaziv.Text)
                && !string.IsNullOrWhiteSpace(textBoxCijena.Text) && !string.IsNullOrWhiteSpace(textBoxPdvStopa.Text))
                {

                    SqlConnection conn = cc.conn;
                    conn.Open();
                    SqlCommand sqlCommand;
                    String sql = "IZMIJENI_PROIZVOD";
                    sqlCommand = new SqlCommand(sql, conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ProizvodID", id);

                    sqlCommand.Parameters.AddWithValue("@Naziv", textBoxNaziv.Text);
                    sqlCommand.Parameters.AddWithValue("@Cijena", decimal.Parse(textBoxCijena.Text));
                    sqlCommand.Parameters.AddWithValue("@PdvStopa", decimal.Parse(textBoxPdvStopa.Text));


                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                    conn.Close();
                    this.Close();
                    MessageBox.Show("Uspješno ste izmijenili podatke o proizvodu");
                }
                else
                {
                    MessageBox.Show("Morate popuniti sve podatke da bi bila moguća izmjena.");
                } }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            }

        private void textBoxPdvStopa_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void textBoxCijena_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void textBoxNaziv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
        }
