using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narudžba
{
    class ConnectionClass
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-58VR9SD;Initial Catalog=Narudžba;Integrated Security=True");

        public void otvoriKonekciju()
        {
            conn.Open();
        }
        public void zatvoriKonekciju()
        {
            conn.Close();
        }


    }
}
