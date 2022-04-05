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
    public partial class FormIzmijeniTipPlaćanja : Form
    {
        int id;

       /* private int Id_tip(int idtip)
        {
            int broj = 0;
            ConnectionClass cc = new ConnectionClass();

            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "SELECT COUNT(*) FROM TIP_PLAĆANJA WHERE Tip_plaćanjaID =" + idtip;
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            SqlDataReader sqldr = sqlCommand.ExecuteReader();
            while (sqldr.Read())
            {
                broj = Convert.ToInt32(sqldr.GetValue(0).ToString());
            }
            conn.Close();
            sqldr.Close();
            sqlCommand.Dispose();
            return broj;
        }*/


        public FormIzmijeniTipPlaćanja(int Tip_plaćanjaID)
        {
            InitializeComponent();
            textBoxTipPlaćanjaID.Enabled = false;
            id = Tip_plaćanjaID;
            textBoxTipPlaćanjaID.Text = Tip_plaćanjaID.ToString();
            PopuniPolja(Tip_plaćanjaID);
        }
        // SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-58VR9SD;Initial Catalog=Narudžba;Integrated Security=True");
        ConnectionClass cc = new ConnectionClass();

        private void PopuniPolja(int id)
        {
            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "UČITAJ_TIP_PLAĆANJA_PO_ID";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Tip_plaćanjaID", id);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtTip_plaćanja = new DataTable();
            while (sqlDataReader.Read())
            {

                textBoxNaziv.Text = sqlDataReader.GetValue(1).ToString();
            }

            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();
        }




        private void buttonIzmijeniTipPlaćanja_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBoxNaziv.Text))
                {
                    SqlConnection conn = cc.conn;
                    conn.Open();
                    SqlCommand sqlCommand;
                    String sql = "IZMIJENI_TIP_PLAĆANJA";
                    sqlCommand = new SqlCommand(sql, conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Tip_plaćanjaID", id);
                    sqlCommand.Parameters.AddWithValue("@NAZIV", textBoxNaziv.Text);
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                    conn.Close();
                    this.Close();
                    MessageBox.Show("Uspješno ste izmijenili tip plaćanja.");
                }
                else
                {
                    MessageBox.Show("Morate popuniti sve podatke, da bi bila moguća njihova izmjena.");
                } }

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
    




        
    

