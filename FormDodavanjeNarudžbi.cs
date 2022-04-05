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
    public partial class FormDodavanjeNarudžbi : Form
    {
        public FormDodavanjeNarudžbi()
        {
            InitializeComponent();
            // textBoxNarudžbaId.Enabled = false;
            textBoxIznosBezPdv.Enabled = false;
            textBoxPdv.Enabled = false;
            textBoxIznosSaPdv.Enabled = false;
        }
        private int Id_narudžbe(int id)
        {
            int broj = 0;
            ConnectionClass cc = new ConnectionClass();

            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "SELECT COUNT(*) FROM NARUDŽBA WHERE NarudžbaId=" + id;
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



        private void buttonUnesiNarudžbu_Click(object sender, EventArgs e)
        {
            if ( !string.IsNullOrWhiteSpace(comboBoxTipPlaćanja.Text) 
                && !string.IsNullOrWhiteSpace(comboBoxRadnik.Text)
                && !string.IsNullOrWhiteSpace(comboBoxKupac.Text) && !string.IsNullOrWhiteSpace(dateTimePickerDatumNastanka.Text)
                && !string.IsNullOrWhiteSpace(textBoxStatus.Text)
                && !string.IsNullOrWhiteSpace(textBoxIznosBezPdv.Text) 
                && !string.IsNullOrWhiteSpace(textBoxPdv.Text) && !string.IsNullOrWhiteSpace(textBoxIznosSaPdv.Text))
            {
                ConnectionClass cc = new ConnectionClass();
                SqlConnection conn = cc.conn;
                conn.Open();
                String sql = "INSERT_NARUDŽBA";
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
               // sqlCommand.Parameters.AddWithValue("@NarudžbaId", textBoxNarudžbaId.Text);
                sqlCommand.Parameters.AddWithValue("@Tip_plaćanjaId", comboBoxTipPlaćanja.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@RadnikId", comboBoxRadnik.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@KupacId", comboBoxKupac.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@Datum_nastanka", Convert.ToDateTime(dateTimePickerDatumNastanka.Text));
                sqlCommand.Parameters.AddWithValue("@Status", textBoxStatus.Text);
                sqlCommand.Parameters.AddWithValue("@IznosBezPdv", decimal.Parse(textBoxIznosBezPdv.Text));
                sqlCommand.Parameters.AddWithValue("@Pdv", decimal.Parse(textBoxPdv.Text));
                sqlCommand.Parameters.AddWithValue("@IznosSaPdv", decimal.Parse(textBoxIznosSaPdv.Text));
               /* int broj = Id_narudžbe(Convert.ToInt32(textBoxNarudžbaId.Text));
                if (broj > 0)
                {
                    MessageBox.Show("Narudžba sa ovim id-jem već postoji.");
                }
                else
                {*/

                    sqlCommand.ExecuteNonQuery();

                    this.Hide();

                    MessageBox.Show("Uspješno ste prijavili novu narudžbu.");
               // }
                conn.Close();
                sqlCommand.Dispose();



            }

            else
            {
                MessageBox.Show("Potrebno je popuniti sve podatke");
            }
        }

        private void FormDodavanjeNarudžbi_Load(object sender, EventArgs e)
        {
            ConnectionClass cc = new ConnectionClass();
            SqlConnection conn = cc.conn;
            conn.Open();
            DataTable dataTable1 = new DataTable("Naziv");
            SqlCommand sqlCommand1 = new SqlCommand("SELECT Tip_plaćanjaID,Naziv from TIP_PLAĆANJA", conn);
            SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
            dataTable1.Load(sqlDataReader1);
            comboBoxTipPlaćanja.DisplayMember = "Naziv";
            comboBoxTipPlaćanja.ValueMember = "Tip_plaćanjaID";
            comboBoxTipPlaćanja.DataSource = dataTable1;
            comboBoxTipPlaćanja.Text = "";
            sqlCommand1.Dispose();
            sqlDataReader1.Close();
          


            
            DataTable dataTable2 = new DataTable("Ime");
            SqlCommand sqlCommand2 = new SqlCommand("SELECT RadnikID,(Ime + '  '+ Prezime) AS Kolone  from RADNIK", conn);
            SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();
            dataTable2.Load(sqlDataReader2);
            comboBoxRadnik.DisplayMember = "Kolone";
            
            comboBoxRadnik.ValueMember = "RadnikID";

            comboBoxRadnik.DataSource = dataTable2;
            comboBoxRadnik.Text = "";
            sqlCommand2.Dispose();
            sqlDataReader2.Close();

            /* DataTable dataTable3 = new DataTable("Prezime");
             SqlCommand sqlCommand3 = new SqlCommand("SELECT RadnikID,Prezime from RADNIK", conn);
             SqlDataReader sqlDataReader3 = sqlCommand3.ExecuteReader();
             dataTable3.Load(sqlDataReader3);
             comboBoxRadnik.DisplayMember = "Prezime";

             comboBoxRadnik.ValueMember = "RadnikID";

             comboBoxRadnik.DataSource = dataTable3;
             comboBoxRadnik.Text = "";
             sqlCommand3.Dispose();
             sqlDataReader3.Close();*/
            DataTable dataTable3 = new DataTable("Ime");
            SqlCommand sqlCommand3 = new SqlCommand("SELECT KupacId, (Ime + ' ' + Prezime) AS ImeIPrezime from KUPAC", conn);
            SqlDataReader sqlDataReader3 = sqlCommand3.ExecuteReader();
            dataTable3.Load(sqlDataReader3);
            comboBoxKupac.DisplayMember = "ImeIPrezime";

            comboBoxKupac.ValueMember = "KupacId";

            comboBoxKupac.DataSource = dataTable3;
            comboBoxKupac.Text = "";
            sqlCommand3.Dispose();
            sqlDataReader3.Close();

            conn.Close();
        }

        private void textBoxStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}         