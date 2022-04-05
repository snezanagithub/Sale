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
    public partial class FormRegistracija : Form
    {
        public FormRegistracija()
        {
            InitializeComponent();
            textBoxŠifra.PasswordChar = '*';
        }
        // SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-58VR9SD;Initial Catalog=Narudžba;Integrated Security=True");
        ConnectionClass cc = new ConnectionClass();
       


        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegistrujSe_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = cc.conn;
            conn.Open();
            SqlCommand sqlCommand1 = new SqlCommand();
            SqlCommand sqlCommand2 = new SqlCommand();
            string Korisničko_ime = "", Šifra = "";

            
            string sql1 = "SELECT Korisničko_ime,Šifra,Ime,Prezime,Email from KORISNIK WHERE Korisničko_ime = "+
                "'" + textBoxKorisničkoIme.Text + "'";
            string sql = "INSERT_KORISNIK";
            sqlCommand1 = new SqlCommand(sql, conn);
            sqlCommand2 = new SqlCommand(sql1, conn);
            sqlCommand1.CommandType = CommandType.StoredProcedure;
            if (!string.IsNullOrWhiteSpace(textBoxKorisničkoIme.Text) && !string.IsNullOrWhiteSpace(textBoxŠifra.Text)
                && !string.IsNullOrWhiteSpace(textBoxIme.Text) && !string.IsNullOrWhiteSpace(textBoxPrezime.Text) 
                && !string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                try
                {
                    SqlDataReader sqlDataReader =  sqlCommand2.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        Korisničko_ime = sqlDataReader.GetValue(0).ToString();
                        Šifra = sqlDataReader.GetValue(1).ToString();

                    }
                    sqlDataReader.Close();
                    sqlCommand2.Dispose();
                    if (Korisničko_ime != textBoxKorisničkoIme.Text && Šifra != textBoxŠifra.Text)
                    {
                        sqlCommand1.Parameters.AddWithValue("@Korisničko_ime", textBoxKorisničkoIme.Text);
                        sqlCommand1.Parameters.AddWithValue("@Šifra", textBoxŠifra.Text);
                        sqlCommand1.Parameters.AddWithValue("@Ime", textBoxIme.Text);
                        sqlCommand1.Parameters.AddWithValue("@Prezime", textBoxPrezime.Text);
                        sqlCommand1.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                        sqlCommand1.ExecuteNonQuery();
                        sqlCommand1.Dispose();
                        MessageBox.Show("Uspješno ste se registrovali.");
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Navedeno korisničko je već u upotrebi.Unesite neko drugo korisničko ime.");
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } }
            else
                MessageBox.Show("Potrebno je da unesete sve podatke.");

            conn.Close();
        }

        private void textBoxPrezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void textBoxIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}



