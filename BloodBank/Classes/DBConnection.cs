using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BloodBank
{
    class DBConnection
    {
        private static string MyConnection = null;
        private static MySqlConnection MyConn = null;
        public static void Conn() {
            try
            {
                //This is my connection string i have assigned the database file address path  
                MyConnection = "datasource=127.0.0.1;port=3306;username=root;password=nati brown";
                MyConn = new MySqlConnection(MyConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static MySqlConnection get_conn()
        {
            return MyConn;
        }
    }
}
