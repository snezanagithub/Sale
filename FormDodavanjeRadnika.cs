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
    public partial class FormDodavanjeRadnika : Form
    {
        public FormDodavanjeRadnika()
        {
            InitializeComponent();
          //  textBoxRadnikID.Enabled = false;
        }
        private int Id_radnika(int idradnika)
        {
            int broj_radnika = 0;
            ConnectionClass cc = new ConnectionClass();

            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "SELECT COUNT(*) FROM RADNIK WHERE RadnikID =" + idradnika;
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            SqlDataReader sql11 = sqlCommand.ExecuteReader();
            while (sql11.Read())
            {
                broj_radnika = Convert.ToInt32(sql11.GetValue(0).ToString());
            }
            conn.Close();
            sql11.Close();
            sqlCommand.Dispose();
            return broj_radnika;
        }

        private void textBoxImeRadnika_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
     
/*private void textBoxPrezimeRadnika_KeyPress(object sender, KeyPressEventArgs e)

        {

            // allows only letters

            if (!char.IsLetter(e.KeyChar))

            {

                e.Handled = true;

            }

        }*/

        private void buttonDodajRadnika_Click(object sender, EventArgs e)
        {

            if ( !string.IsNullOrWhiteSpace(comboBoxDodajRadnika.Text)
                && !string.IsNullOrWhiteSpace(textBoxImeRadnika.Text) && !string.IsNullOrWhiteSpace(textBoxPrezimeRadnika.Text)
                && !string.IsNullOrWhiteSpace(textBoxBrojTelefonaRadnika.Text) && !string.IsNullOrWhiteSpace(textBoxEmailRadnika.Text)
                && !string.IsNullOrWhiteSpace(textBoxAdresaRadnika.Text) && !string.IsNullOrWhiteSpace(dateTimePickerDatumRođenjaRadnika.Text)
                && !string.IsNullOrWhiteSpace(dateTimePickerDatumZaposlenjaRadnika.Text))
            {
                ConnectionClass cc = new ConnectionClass();
                SqlConnection conn = cc.conn;
                conn.Open();
                String sql = "INSERT_RADNIK";
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
               // sqlCommand.Parameters.AddWithValue("@RadnikId", textBoxRadnikID.Text);
                sqlCommand.Parameters.AddWithValue("@MjestoId", comboBoxDodajRadnika.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@Ime", textBoxImeRadnika.Text);
                sqlCommand.Parameters.AddWithValue("@Prezime", textBoxPrezimeRadnika.Text);
                sqlCommand.Parameters.AddWithValue("@Br_telefona", textBoxBrojTelefonaRadnika.Text);
                sqlCommand.Parameters.AddWithValue("@Email", textBoxEmailRadnika.Text);
                sqlCommand.Parameters.AddWithValue("@Adresa", textBoxAdresaRadnika.Text);
                sqlCommand.Parameters.AddWithValue("@Datum_rođenja", Convert.ToDateTime(dateTimePickerDatumZaposlenjaRadnika.Text));
                sqlCommand.Parameters.AddWithValue("@Datum_zaposlenja", Convert.ToDateTime(dateTimePickerDatumRođenjaRadnika.Text));
               // int broj_radnika = Id_radnika(Convert.ToInt32(textBoxRadnikID.Text));
               /* if (broj_radnika > 0)
                {
                    MessageBox.Show("Radnik sa ovim i-dijem već postoji.");
                }
                else
                {*/
                    sqlCommand.ExecuteNonQuery();
                    this.Hide();
                    MessageBox.Show("Uspješno ste prijavili novog radnika.");
               // }
                conn.Close();
                sqlCommand.Dispose();
            }


            else
            {
                MessageBox.Show("Potrebno je unijeti sve podatke !!!");
            }
        }




            private void FormDodavanjeRadnika_Load_1(object sender, EventArgs e)
            {
                ConnectionClass cc = new ConnectionClass();
                SqlConnection conn = cc.conn;
                conn.Open();
                DataTable dataTable = new DataTable("Naziv");
                SqlCommand sqlCommand = new SqlCommand("SELECT MjestoID,Naziv from MJESTO", conn);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                dataTable.Load(sqlDataReader);
                comboBoxDodajRadnika.DisplayMember = "Naziv";
                comboBoxDodajRadnika.ValueMember = "MjestoId";

                comboBoxDodajRadnika.DataSource = dataTable;
                comboBoxDodajRadnika.Text = "";
                sqlCommand.Dispose();
                sqlDataReader.Close();
                conn.Close();
            }

        private void textBoxPrezimeRadnika_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void textBoxBrojTelefonaRadnika_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!Char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+') && (e.KeyChar!= ' '))

            {
                e.Handled = true;
            }
        }

      

      
    }
    } 
        
