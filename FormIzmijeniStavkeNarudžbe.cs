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
    public partial class FormIzmijeniStavkeNarudžbe : Form
    {
        int id;
        public FormIzmijeniStavkeNarudžbe(int NarudžbaProizvodID)
        {
            InitializeComponent();
            Narudžba();
            Proizvod();
            textBoxNarudžbaProizvodID.Enabled = false;
            comboBoxNarudžbaID.Enabled = false;
             id = NarudžbaProizvodID;
            textBoxNarudžbaProizvodID.Text = NarudžbaProizvodID.ToString();
            PopuniPolja(NarudžbaProizvodID);
        }
        
        ConnectionClass cc = new ConnectionClass();
       
        private void PopuniPolja(int id)
        {
            
            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "UČITAJ_STAVKE_NARUDŽBE_PO_ID";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Narudžba_ProizvodId", id);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
          /*  int selectedIndex = comboBox.SelectedIndex;
            comboBox1.SelectedItem.ToString();
            int selectedValue = (int)comboBox1.Items[selectedIndex];*/
            while (sqlDataReader.Read())
            {
                // textBoxNarudžbaProizvodID.Text = sqlDataReader.GetValue(0).ToString();
                comboBoxNarudžbaID.SelectedValue = sqlDataReader.GetValue(1).ToString();
                comboBoxProizvodID.SelectedValue = sqlDataReader.GetValue(2).ToString();
                textBoxKoličina.Text = sqlDataReader.GetValue(3).ToString();
                textBoxCijena.Text = sqlDataReader.GetValue(4).ToString();
                
            }

            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();
        }

        private void buttonIzmijeniStavkeNarudžbe_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(comboBoxNarudžbaID.Text)
                && !string.IsNullOrWhiteSpace(comboBoxProizvodID.Text)
               && !string.IsNullOrWhiteSpace(textBoxCijena.Text)
               && !string.IsNullOrWhiteSpace(textBoxKoličina.Text))
                { 
                    SqlConnection conn = cc.conn;
                conn.Open();
                SqlCommand sqlCommand;
                String sql = "IZMIJENI_STAVKE_NARUDŽBE";
                sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Narudžba_ProizvodId", id);

                sqlCommand.Parameters.AddWithValue("@NarudžbaId", Convert.ToInt32(comboBoxNarudžbaID.SelectedValue.ToString()));
                sqlCommand.Parameters.AddWithValue("@ProizvodID", Convert.ToInt32(comboBoxProizvodID.SelectedValue.ToString()));
                sqlCommand.Parameters.AddWithValue("@Količina", textBoxKoličina.Text);
                sqlCommand.Parameters.AddWithValue("@Cijena", decimal.Parse(textBoxCijena.Text));
                
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                conn.Close();
                this.Close();
                MessageBox.Show("Uspješno ste izmijenili podatke o stavkama narudžbe.");
                 

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
        public void Proizvod()
        {
            try
            {
                ConnectionClass cc = new ConnectionClass();
                SqlConnection conn = cc.conn;
                string query = "SELECT ProizvodID, Naziv from Proizvod";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "PROIZVOD");
                comboBoxProizvodID.DisplayMember = "Naziv";
                comboBoxProizvodID.ValueMember = "ProizvodID";
                comboBoxProizvodID.DataSource = ds.Tables["PROIZVOD"];
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Greska!");
            }
        }

        /*  private void FormIzmijeniStavkeNarudžbe_Load(object sender, EventArgs e)
          {
              ConnectionClass cc = new ConnectionClass();
              SqlConnection conn = cc.conn;
              conn.Open();
              DataTable dataTable1 = new DataTable("Naziv");
              SqlCommand sqlCommand1 = new SqlCommand("SELECT ProizvodID,Naziv from Proizvod", conn);
              SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
              dataTable1.Load(sqlDataReader1);
              comboBoxProizvodID.DisplayMember = "Naziv";
              comboBoxProizvodID.ValueMember = "ProizvodID";
              comboBoxProizvodID.DataSource = dataTable1;
             // comboBoxProizvodID.Text = "";
              sqlCommand1.Dispose();
              sqlDataReader1.Close();

              DataTable dataTable2 = new DataTable("NarudžbaID");
              SqlCommand sqlCommand2 = new SqlCommand("SELECT NarudžbaID from NARUDŽBA", conn);
              SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();
              dataTable2.Load(sqlDataReader2);
              comboBoxNarudžbaID.DisplayMember = "NarudžbaID";

              comboBoxNarudžbaID.ValueMember = "NarudžbaID";

              comboBoxNarudžbaID.DataSource = dataTable2;
             // comboBoxNarudžbaID.Text = "";
              sqlCommand2.Dispose();
              sqlDataReader2.Close();
              conn.Close();
          }*/
        public void Narudžba()
        {
            try
            {
                ConnectionClass cc = new ConnectionClass();
                SqlConnection conn = cc.conn;
                string query = "SELECT NarudžbaID from NARUDŽBA";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "NARUDŽBA");
                comboBoxNarudžbaID.DisplayMember = "NarudžbaID";
                comboBoxNarudžbaID.ValueMember = "NarudžbaID";
                comboBoxNarudžbaID.DataSource = ds.Tables["NARUDŽBA"];
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Greska!");
            }
        }


            private void comboBoxNarudžbaID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNarudžbaID.SelectedItem != null)
            {
                DataRowView drv = comboBoxNarudžbaID.SelectedItem as DataRowView;
               Debug.WriteLine("Items:" + drv.Row["NarudžbaID"].ToString());
                Debug.WriteLine("Values:" + drv.Row["NarudžbaID"]);
                Debug.WriteLine("Values:" + Convert.ToInt32(comboBoxNarudžbaID.SelectedValue.ToString()));
            }
        }

        private void comboBoxProizvodID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProizvodID.SelectedItem != null)
            {
                DataRowView drv = comboBoxProizvodID.SelectedItem as DataRowView;
                Debug.WriteLine("Items:" + drv.Row["Naziv"].ToString());
                Debug.WriteLine("Values:" + drv.Row["ProizvodID"]);
                Debug.WriteLine("Values:" + Convert.ToInt32(comboBoxProizvodID.SelectedValue.ToString()));
            }
        }

        private void textBoxKoličina_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch)&& ch !=8 && ch !=43)
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




