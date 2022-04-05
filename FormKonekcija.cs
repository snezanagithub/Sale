using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Narudžba
{
    public partial class FormKonekcija : Form
    {
        public FormKonekcija()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-58VR9SD;Initial Catalog=Narudžba;Integrated Security=True";

        private void buttonTest_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
                con.Open();
            if(con.State == System.Data.ConnectionState.Open)
            {
                string q = "Insert into Test(Id,Ime)values ('"+txtId.Text.ToString()+"','"+ txtIme.Text+"')";
                 SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Konekcija je uspješna.");
            }
                
 
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
