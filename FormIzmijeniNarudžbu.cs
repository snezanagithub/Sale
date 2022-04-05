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
    public partial class FormIzmijeniNarudžbu : Form
    {
        int id;
        public FormIzmijeniNarudžbu(int NarudžbaID)
        {
            InitializeComponent();
            TipPlaćanja();
            Kupac();
            Radnik();
            id = NarudžbaID;
            textBoxNarudžbaID.Enabled = false;
            textBoxNarudžbaID.Text = NarudžbaID.ToString();
            PopuniPolja(NarudžbaID);
            textBoxIznosBezPdv.Enabled = false;
            textBoxPdv.Enabled = false;
            textBoxIznosSaPdv.Enabled = false;
        }
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-58VR9SD;Initial Catalog=Narudžba;Integrated Security=True");
        ConnectionClass cc = new ConnectionClass();
       
        private void PopuniPolja(int id)
        {
           
            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "UČITAJ_NARUDŽBU_PO_ID";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@NarudžbaID", id);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                comboBoxTipPlaćanja.SelectedValue = sqlDataReader.GetValue(1).ToString();
                comboBoxRadnikID.SelectedValue = sqlDataReader.GetValue(2).ToString();
                comboBoxKupacID.SelectedValue = sqlDataReader.GetValue(3).ToString();
                dateTimePickerDatumNastanka.Text = sqlDataReader.GetValue(4).ToString();
                textBoxStatus.Text = sqlDataReader.GetValue(5).ToString();
                textBoxIznosBezPdv.Text = sqlDataReader.GetValue(6).ToString();
                textBoxPdv.Text = sqlDataReader.GetValue(7).ToString();
                textBoxIznosSaPdv.Text = sqlDataReader.GetValue(8).ToString();
            }

            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();
        }

        private void buttonIzmijeniNarudžbu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(comboBoxTipPlaćanja.Text)
               && !string.IsNullOrWhiteSpace(comboBoxRadnikID.Text)
               && !string.IsNullOrWhiteSpace(comboBoxKupacID.Text) && !string.IsNullOrWhiteSpace(dateTimePickerDatumNastanka.Text)
               && !string.IsNullOrWhiteSpace(textBoxStatus.Text)
               && !string.IsNullOrWhiteSpace(textBoxIznosBezPdv.Text)
               && !string.IsNullOrWhiteSpace(textBoxPdv.Text) && !string.IsNullOrWhiteSpace(textBoxIznosSaPdv.Text))
                {

                    SqlConnection conn = cc.conn;
                    conn.Open();
                    SqlCommand sqlCommand;
                    String sql = "IZMIJENI_NARUDŽBU";
                    sqlCommand = new SqlCommand(sql, conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@NarudžbaID", id);

                    sqlCommand.Parameters.AddWithValue("@Tip_plaćanjaID", Convert.ToInt32(comboBoxTipPlaćanja.SelectedValue.ToString()));
                    sqlCommand.Parameters.AddWithValue("@RadnikID", Convert.ToInt32(comboBoxRadnikID.SelectedValue.ToString()));
                    sqlCommand.Parameters.AddWithValue("@KupacID", Convert.ToInt32(comboBoxKupacID.SelectedValue.ToString()));
                    sqlCommand.Parameters.AddWithValue("@Datum_nastanka", Convert.ToDateTime(dateTimePickerDatumNastanka.Text));
                    sqlCommand.Parameters.AddWithValue("@Status", textBoxStatus.Text);
                    sqlCommand.Parameters.AddWithValue("@IznosBezPdv", decimal.Parse(textBoxIznosBezPdv.Text));
                    sqlCommand.Parameters.AddWithValue("@Pdv", decimal.Parse(textBoxPdv.Text));
                    sqlCommand.Parameters.AddWithValue("@IznosSaPdv", decimal.Parse(textBoxIznosSaPdv.Text));
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                    conn.Close();
                    this.Close();
                    MessageBox.Show("Uspješno ste izmijenili podatke o narudžbi.");
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

        /*   private void FormIzmijeniNarudžbu_Load(object sender, EventArgs e)
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
               SqlCommand sqlCommand2 = new SqlCommand("SELECT RadnikID,Ime from RADNIK", conn);
               SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();
               dataTable2.Load(sqlDataReader2);
               comboBoxRadnikID.DisplayMember = "Ime";

               comboBoxRadnikID.ValueMember = "RadnikID";

               comboBoxRadnikID.DataSource = dataTable2;
              // comboBoxRadnikID.Text = "";
               sqlCommand2.Dispose();
               sqlDataReader2.Close();
               DataTable dataTable3 = new DataTable("Ime");
               SqlCommand sqlCommand3 = new SqlCommand("SELECT KupacId,Ime from KUPAC", conn);
               SqlDataReader sqlDataReader3 = sqlCommand3.ExecuteReader();
               dataTable3.Load(sqlDataReader3);
               comboBoxKupacID.DisplayMember = "Ime";

               comboBoxKupacID.ValueMember = "KupacId";

               comboBoxKupacID.DataSource = dataTable3;
              // comboBoxKupacID.Text = "";
               sqlCommand3.Dispose();
               sqlDataReader3.Close();

               conn.Close();

           }*/
        public void Kupac()
        {
            try
            {
                ConnectionClass cc = new ConnectionClass();
                SqlConnection conn = cc.conn;
                string query = "SELECT KupacID,Ime from KUPAC";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "KUPAC");
                comboBoxKupacID.DisplayMember = "Ime";
                comboBoxKupacID.ValueMember = "KupacID";
                comboBoxKupacID.DataSource = ds.Tables["KUPAC"];
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Greska!");
            }
        }



        public void Radnik()
        {
            try
            {
                ConnectionClass cc = new ConnectionClass();
                SqlConnection conn = cc.conn;
                string query = "SELECT RadnikID,Ime from RADNIK";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "RADNIK");
                comboBoxRadnikID.DisplayMember = "Ime";
                comboBoxRadnikID.ValueMember = "RadnikID";
                comboBoxRadnikID.DataSource = ds.Tables["RADNIK"];
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Greska!");
            }
        }


       public void TipPlaćanja()
        {
            try
            {
                ConnectionClass cc = new ConnectionClass();
                SqlConnection conn = cc.conn;
                string query = "SELECT Tip_plaćanjaID,Naziv from TIP_PLAĆANJA";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "TIP_PLAĆANJA");
                comboBoxTipPlaćanja.DisplayMember = "Naziv";
                comboBoxTipPlaćanja.ValueMember = "Tip_plaćanjaID";
                comboBoxTipPlaćanja.DataSource = ds.Tables["TIP_PLAĆANJA"];
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Greska!");
            }

        }

        private void comboBoxTipPlaćanja_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipPlaćanja.SelectedItem != null)
            {
                DataRowView drv = comboBoxTipPlaćanja.SelectedItem as DataRowView;
                Debug.WriteLine("Items:" + drv.Row["Naziv"].ToString());
                Debug.WriteLine("Values:" + drv.Row["Tip_PlaćanjaID"]);
                Debug.WriteLine("Values:" + Convert.ToInt32(comboBoxTipPlaćanja.SelectedValue.ToString()));
            }
        }

        private void comboBoxRadnikID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRadnikID.SelectedItem != null)
            {
                DataRowView drv = comboBoxRadnikID.SelectedItem as DataRowView;
                Debug.WriteLine("Items:" + drv.Row["Ime"].ToString());
                Debug.WriteLine("Values:" + drv.Row["RadnikID"]);
                Debug.WriteLine("Values:" + Convert.ToInt32(comboBoxRadnikID.SelectedValue.ToString()));
            }
        }

        private void comboBoxKupacID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxKupacID.SelectedItem != null)
            {
                DataRowView drv = comboBoxKupacID.SelectedItem as DataRowView;
                Debug.WriteLine("Items:" + drv.Row["Ime"].ToString());
                Debug.WriteLine("Values:" + drv.Row["KupacID"]);
                Debug.WriteLine("Values:" + Convert.ToInt32(comboBoxKupacID.SelectedValue.ToString()));
            }
        }

        private void textBoxStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }

   
    }

