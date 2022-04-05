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
    public partial class FormIzmijeniMjesto : Form
    {
        int id;

        public FormIzmijeniMjesto(int MjestoId)
        {
            InitializeComponent();
            textBoxMjestoId.Enabled = false;
            id = MjestoId;
            textBoxMjestoId.Text = MjestoId.ToString();
            PopuniPolja(MjestoId);
        }
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-58VR9SD;Initial Catalog=Narudžba;Integrated Security=True");
        ConnectionClass cc = new ConnectionClass();
        private void PopuniPolja(int id)
        {
           // ConnectionClass cc = new ConnectionClass();
            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "UČITAJ_MJESTA_PO_ID";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@MjestoId", id);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtMjesto = new DataTable();
            while (sqlDataReader.Read())
            {

                textBoxNaziv.Text = sqlDataReader.GetValue(1).ToString();

            }

            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();
        }



        private void buttonIzmijeniMjesto_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBoxNaziv.Text))
                {
                    SqlConnection conn = cc.conn;
                    conn.Open();
                    SqlCommand sqlCommand;
                    String sql = "IZMIJENI_MJESTO";
                    sqlCommand = new SqlCommand(sql, conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@MjestoId", id);
                    sqlCommand.Parameters.AddWithValue("@Naziv", textBoxNaziv.Text);

                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                    conn.Close();
                    this.Close();
                    MessageBox.Show("Uspješno ste izmijenili podatke o mjestu.");
                }
                else
                {
                    MessageBox.Show("Morate popuniti sve podatke da bi bila moguća njihova izmjena.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxNaziv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}


        