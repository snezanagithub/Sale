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
    public partial class FormDodavanjeStavkiNarudžbe : Form
    {
        public FormDodavanjeStavkiNarudžbe()
        {
            InitializeComponent();
           // textBoxNarudžbaProizvodID.Enabled = false;
        }
        private int Id_stavki(int id)
        {
            int broj = 0;
            ConnectionClass cc = new ConnectionClass();

            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "SELECT COUNT(*) FROM NARUDŽBA_PROIZVOD WHERE NarudžbaId=" + id;
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



        private void buttonUnesiStavkuNarudžbe_Click(object sender, EventArgs e)
        {
            if ( !string.IsNullOrWhiteSpace(comboBoxNarudžbaID.Text) 
                && !string.IsNullOrWhiteSpace(comboBoxProizvodID.Text)
               && !string.IsNullOrWhiteSpace(textBoxCijena.Text)
               && !string.IsNullOrWhiteSpace(textBoxKoličina.Text))
            {
                ConnectionClass cc = new ConnectionClass();
                SqlConnection conn = cc.conn;
                conn.Open();
                String sql = "INSERT_STAVKENARUDŽBE";
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
               // sqlCommand.Parameters.AddWithValue("@Narudžba_ProizvodId",textBoxNarudžbaProizvodID.Text);
                sqlCommand.Parameters.AddWithValue("@NarudžbaId", comboBoxNarudžbaID.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@ProizvodID", comboBoxProizvodID.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@Količina", textBoxKoličina.Text);
                sqlCommand.Parameters.AddWithValue("@Cijena", decimal.Parse(textBoxCijena.Text));
              /*  int broj = Id_stavki(Convert.ToInt32(textBoxNarudžbaProizvodID.Text));
                if (broj > 0)
                {
                    MessageBox.Show("Stavka narudžbe sa ovim id-jem već postoji.");
                }
                else
                {*/

                    sqlCommand.ExecuteNonQuery();

                    this.Hide();

                    MessageBox.Show("Uspješno ste prijavili novu stavku narudžbe.");
                
                conn.Close();
                sqlCommand.Dispose();
            }

          else
            {
                MessageBox.Show("Potrebno je popuniti sve podatke");
            }
        }

        private void FormDodavanjeStavkiNarudžbe_Load(object sender, EventArgs e)
        {
            ConnectionClass cc = new ConnectionClass();
            SqlConnection conn = cc.conn;
            conn.Open();
            DataTable dataTable1 = new DataTable("Naziv");
            //SqlCommand sqlCommand1 = new SqlCommand("SELECT ProizvodID,(Naziv + '  ' + Cijena) AS Ispis from Proizvod", conn);
           SqlCommand sqlCommand1 = new SqlCommand("SELECT ProizvodID,Naziv from Proizvod", conn);
            SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
            dataTable1.Load(sqlDataReader1);
           // comboBoxProizvodID.DisplayMember = "Ispis";
           comboBoxProizvodID.DisplayMember = "Naziv";

            comboBoxProizvodID.ValueMember = "ProizvodID";
            comboBoxProizvodID.DataSource = dataTable1;
            comboBoxProizvodID.Text = "";
            sqlCommand1.Dispose();
            sqlDataReader1.Close();
            



             DataTable dataTable2 = new DataTable("NarudžbaID");
             SqlCommand sqlCommand2 = new SqlCommand("SELECT NarudžbaID from NARUDŽBA", conn);
             SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();
             dataTable2.Load(sqlDataReader2);
             comboBoxNarudžbaID.DisplayMember = "NarudžbaID";

             comboBoxNarudžbaID.ValueMember = "NarudžbaID";

             comboBoxNarudžbaID.DataSource = dataTable2;
             comboBoxNarudžbaID.Text = "";
             sqlCommand2.Dispose();
             sqlDataReader2.Close();
            conn.Close();
        }

        private void textBoxKoličina_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 43)
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
    }
}