using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BloodBank.Classes
{
    class DBConnection
    {
        private static string MyConnection = null;
        public static MySqlConnection Conn() {
            MySqlConnection MyConn = null;
            try
            {
                //This is my connection string i have assigned the database file address path  
                MyConnection = "datasource=localhost;port=3307;username=root;password=nati brown";
                MyConn = new MySqlConnection(MyConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return MyConn;
        }
    }
}
