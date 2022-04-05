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
    public partial class FormDodavanjeProizvoda : Form
    {
        public FormDodavanjeProizvoda()
        {
            InitializeComponent();
           // textBoxProizvodId.Enabled = false;
        }
        private int id_proizvoda(int idproizvoda)
        {
            int brojproizvoda = 0;
            ConnectionClass cc = new ConnectionClass();

            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "SELECT COUNT(*) FROM PROIZVOD WHERE ProizvodID =" + idproizvoda;
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            SqlDataReader sql11 = sqlCommand.ExecuteReader();
            while (sql11.Read())
            {
                brojproizvoda = Convert.ToInt32(sql11.GetValue(0).ToString());
            }
            conn.Close();
            sql11.Close();
            sqlCommand.Dispose();
            return brojproizvoda;
        }

        private void buttonUnesiProizvod_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-58VR9SD;Initial Catalog=Narudžba;Integrated Security=True");
            if ( !string.IsNullOrWhiteSpace(textBoxNaziv.Text) 
                && !string.IsNullOrWhiteSpace(textBoxCijena.Text) && !string.IsNullOrWhiteSpace(textBoxPdvStopa.Text))
            {
                ConnectionClass cc = new ConnectionClass();
                SqlConnection conn = cc.conn;
                conn.Open();
                String sql = "INSERT_PROIZVOD";
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
               // sqlCommand.Parameters.AddWithValue("@ProizvodId", textBoxProizvodId.Text);
                sqlCommand.Parameters.AddWithValue("@Naziv", textBoxNaziv.Text);
                sqlCommand.Parameters.AddWithValue("@Cijena", decimal.Parse(textBoxCijena.Text));
                 sqlCommand.Parameters.AddWithValue("@PdvStopa", decimal.Parse(textBoxPdvStopa.Text));
                /*int brojproizvoda = id_proizvoda(Convert.ToInt32(textBoxProizvodId.Text));
                if (brojproizvoda > 0)
                {
                    MessageBox.Show("Već postoji proizvod sa ovim id-jem.");
                }
                else
                {*/
                    sqlCommand.ExecuteNonQuery();
                    // sqlCommand.Dispose();
                    this.Hide();
                    MessageBox.Show("Uspješno ste prijavili novi proizvod.");
                
                conn.Close();
                sqlCommand.Dispose(); }
            else
            {
                MessageBox.Show("Potrebno je da popunite sve podatke.");
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

        private void textBoxPdvStopa_KeyPress(object sender, KeyPressEventArgs e)
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
