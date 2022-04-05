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
    public partial class FormDodavanjeTipaPlaćanja : Form
    {
        public FormDodavanjeTipaPlaćanja()
        {
            InitializeComponent();
           // textBoxTipPlaćanjaID.Enabled = false;
        }
        private int Id_tip(int idtip)
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
        }


        private void buttonUnesiNoviTipPlaćanja_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-58VR9SD;Initial Catalog=Narudžba;Integrated Security=True");
            if ( !string.IsNullOrWhiteSpace(textBoxNazivId.Text))
            {
                ConnectionClass cc = new ConnectionClass();
                SqlConnection conn = cc.conn;
                conn.Open();
                String sql = "INSERT_TIPPLAĆANJA";
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
               //  sqlCommand.Parameters.AddWithValue("@Tip_plaćanjaID", textBoxTipPlaćanjaID.Text);
                sqlCommand.Parameters.AddWithValue("@Naziv", textBoxNazivId.Text);
                /*int brojj = Id_tip(Convert.ToInt32(textBoxTipPlaćanjaID.Text));
                if (brojj > 0)
                {
                    MessageBox.Show("Već postoji ovaj tip plaćanja.");
                }
                else
                {*/
                    sqlCommand.ExecuteNonQuery();
                   
                    this.Hide();
                    MessageBox.Show("Uspješno ste prijavili novi tip plaćanja narudžbe.");
               // }
                conn.Close();
                sqlCommand.Dispose();
            }
            else
            {
                MessageBox.Show("Potrebno je da popunite sve podatke.");
            }
                //MessageBox.Show("Uspješno ste prijavili novi tip plaćanja narudžbe.");
                //conn.Close();


            }

        private void textBoxNazivId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
    }

