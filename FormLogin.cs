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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            textBoxŠifra.PasswordChar = '*';
             //public static string Ime = " ";
    }
        // SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-58VR9SD;Initial Catalog=Narudžba;Integrated Security=True");
       ConnectionClass cc = new ConnectionClass();
     
       public static string Ime = " ";

        private void buttonLogin_Click(object sender, EventArgs e)
        {
           //ConnectionClass cc = new ConnectionClass();

            SqlConnection conn = cc.conn;
            String KorisničkoIme = " ", Šifra = " ";
           conn.Open();

            String sql = "SELECT KORISNIČKO_IME, " +
                "                ŠIFRA," +
                "                IME " +
                "           FROM KORISNIK " +
                "       WHERE KORISNIČKO_IME = '" +
                                textBoxKorisničkoIme.Text + "'"; ;
            SqlCommand sqlCommand = new SqlCommand(sql,conn);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                KorisničkoIme = sqlDataReader.GetValue(0).ToString();
                Šifra = sqlDataReader.GetValue(1).ToString();
                Ime = sqlDataReader.GetValue(2).ToString();
            }


            if (Šifra == textBoxŠifra.Text && KorisničkoIme == textBoxKorisničkoIme.Text)
            {

                FormPočetna frm = new FormPočetna();
                frm.Show();
                this.Hide();
            }
            else if (KorisničkoIme != textBoxKorisničkoIme.Text)
            {
                MessageBox.Show("Unijeli ste pogrešno korisničko ime!");
                textBoxKorisničkoIme.Clear();
            }
            else if (Šifra != textBoxŠifra.Text)
                MessageBox.Show("Unijeli ste pogrešnu lozinku!");
          /*  else
            {
                MessageBox.Show("Pogrešno korisničko " +
                                            "ime ili lozinka!");
            }*/

            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();
             
        }

        private void buttonIzađi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRegistrujSe_Click_1(object sender, EventArgs e)
        {
            FormRegistracija frmRegistracija = new FormRegistracija();
            frmRegistracija.Show();
        }
    }
}
