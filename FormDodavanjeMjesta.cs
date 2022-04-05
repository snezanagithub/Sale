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
    public partial class FormDodavanjeMjesta : Form
    {
        public FormDodavanjeMjesta()
        {
            InitializeComponent();
            // textBoxMjestoId.Enabled = false;
           
        }
        private int Id_mjesta(int id)
        {
            int broj = 0;
            ConnectionClass cc = new ConnectionClass();

            SqlConnection conn = cc.conn;
            conn.Open();
            String sql = "SELECT COUNT(*) FROM MJESTO WHERE MjestoId=" + id;
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


        private void buttonPrijaviNovoMjesto_Click(object sender, EventArgs e)
        {
            if ( !string.IsNullOrWhiteSpace(textBoxNazivMjesta.Text))
            {
                ConnectionClass cc = new ConnectionClass();
                SqlConnection conn = cc.conn;
                conn.Open();
                String sql = "INSERT_MJESTO";
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
               // sqlCommand.Parameters.AddWithValue("@MjestoID", Convert.ToInt32(textBoxMjestoId.Text));
                sqlCommand.Parameters.AddWithValue("@Naziv", textBoxNazivMjesta.Text);
               /* int broj = Id_mjesta(Convert.ToInt32(textBoxMjestoId.Text));
                if (broj > 0)
                {
                    MessageBox.Show("Mjesto sa ovim id-jem već postoji.");
                }
                else
                {*/

                    sqlCommand.ExecuteNonQuery();

                    this.Hide();

                    MessageBox.Show("Uspješno ste prijavili novo mjesto.");
               // }
                conn.Close();
                sqlCommand.Dispose();



            }

            else
            {
                MessageBox.Show("Potrebno je popuniti sve podatke");
            }
        }

      private void textBoxNazivMjesta_KeyPress(object sender,KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}

       

