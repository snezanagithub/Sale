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
    public partial class FormIzmjenaRadnika : Form
    {
        int id;

        public FormIzmjenaRadnika(int RadnikID)
        {
            InitializeComponent();
            Mjesto();
            id = RadnikID;
            textBoxRadnikId.Enabled = false;
            textBoxRadnikId.Text = RadnikID.ToString();
            PopuniPolja(RadnikID);

        }


        // SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-58VR9SD;Initial Catalog=Narudžba;Integrated Security=True");
        ConnectionClass cc = new ConnectionClass();

        private void PopuniPolja(int id)
        {

            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "UČITAJ_RADNIKA_PO_ID ";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@RadnikID", id);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            // string selectedIndex = comboBoxIzmjena.SelectedIndex;
            //comboBoxIzmjena.SelectedItem.ToString();
            //string selectedValue = (int)comboBoxIzmjena.Items[selectedIndex];
             DataTable dtN = new DataTable();
            while (sqlDataReader.Read())
            {
                //  int selectedIndex = comboBoxIzmjena.SelectedIndex;
                // comboBoxIzmjena.SelectedItem.ToString();
                // int selectedValue = (int)comboBoxIzmjena.Items[selectedIndex];
                comboBoxIzmjena.SelectedValue = sqlDataReader.GetValue(1).ToString();
                textBoxIme.Text = sqlDataReader.GetValue(2).ToString();
                textBoxPrezime.Text = sqlDataReader.GetValue(3).ToString();
                textBoxBrojTelefona.Text = sqlDataReader.GetValue(4).ToString();
                textBoxEmail.Text = sqlDataReader.GetValue(5).ToString();
                textBoxAdresaRadnika.Text = sqlDataReader.GetValue(6).ToString();
                dateTimePickerDatumRođenja.Value = DateTime.Parse(sqlDataReader.GetValue(7).ToString());
                dateTimePickerDatumZaposlenja.Value = DateTime.Parse(sqlDataReader.GetValue(8).ToString());
            }

            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();
        }

        private void buttonIzmijeniRadnika_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(comboBoxIzmjena.Text)
                   && !string.IsNullOrWhiteSpace(textBoxIme.Text) && !string.IsNullOrWhiteSpace(textBoxPrezime.Text)
                   && !string.IsNullOrWhiteSpace(textBoxBrojTelefona.Text) && !string.IsNullOrWhiteSpace(textBoxEmail.Text)
                   && !string.IsNullOrWhiteSpace(textBoxAdresaRadnika.Text) && !string.IsNullOrWhiteSpace(dateTimePickerDatumRođenja.Text)
                   && !string.IsNullOrWhiteSpace(dateTimePickerDatumZaposlenja.Text))
                {
                    SqlConnection conn = cc.conn;
                    conn.Open();
                    SqlCommand sqlCommand;
                    String sql = "IZMIJENI_RADNIKA";
                    sqlCommand = new SqlCommand(sql, conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@RadnikID", id);
                    sqlCommand.Parameters.AddWithValue("@MjestoID", Convert.ToInt32(comboBoxIzmjena.SelectedValue.ToString()));
                    sqlCommand.Parameters.AddWithValue("@Ime", textBoxIme.Text);
                    sqlCommand.Parameters.AddWithValue("@Prezime", textBoxPrezime.Text);
                    sqlCommand.Parameters.AddWithValue("@Br_telefona", textBoxBrojTelefona.Text);
                    sqlCommand.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                    sqlCommand.Parameters.AddWithValue("@Adresa", textBoxAdresaRadnika.Text);
                    sqlCommand.Parameters.AddWithValue("@Datum_rođenja", Convert.ToDateTime(dateTimePickerDatumRođenja.Text));
                    sqlCommand.Parameters.AddWithValue("@Datum_zaposlenja", Convert.ToDateTime(dateTimePickerDatumZaposlenja.Text));
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                    conn.Close();
                    this.Close();
                    MessageBox.Show("Uspješno ste izmijenili podatke o radniku.");
                }
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

        /* private void FormIzmjenaRadnika_Load(object sender, EventArgs e)
           {

                 ConnectionClass cc = new ConnectionClass();
                 SqlConnection conn = cc.conn;
                 conn.Open();
                 DataTable dataTable = new DataTable("Naziv");
                 SqlCommand sqlCommand = new SqlCommand("SELECT MjestoID,Naziv from MJESTO ", conn);
                 SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                 dataTable.Load(sqlDataReader);
                 comboBoxIzmjena.DisplayMember = "Naziv";
                 comboBoxIzmjena.ValueMember = "MjestoId";

                 comboBoxIzmjena.DataSource = dataTable;

               //   int bb;

           //comboBoxIzmjena.SelectedValue = ("SELECT Mjesto.Naziv from Radnik join mjesto on mjesto.mjestoid = radnik.mjestoid where Radnik.mjestoId = '"+ listViewRadnik.SelectedItems[0].SubItems[1].Text + "'" );
             //  comboBoxIzmjena.SelectedValue = 3;

                 sqlCommand.Dispose();
                 sqlDataReader.Close();
                 conn.Close();


           }*/

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

        private void textBoxBrojTelefona_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+') && (e.KeyChar != ' '))

            {
                e.Handled = true;
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
    }
}





                