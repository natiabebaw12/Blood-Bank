using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank.Classes
{
    class Blood
    {
        private MySqlCommand cmd;
        private MySqlDataAdapter adapter;

        //SELECT no_of_donation FROM blood_bank.blood_detail  where abo_group = "A";
       
        public string donationNo()
        {
            string a = "A";
            //string connectionString = ""; //Set your MySQL connection string here.
            string sql = "SELECT no_of_donation FROM blood_bank.blood_detail where abo_group = '"+a+"';"; // set query to fetch data "Select * from  tabelname"; 

            adapter = new MySqlDataAdapter(sql, DBConnection.get_conn());

            return adapter.ToString();
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds.ToString();
        }
       /* #endregion
        #region UPDATE THE DATABASE
        public void update(string abo_group)
        {
            string sql = "UPDATE blood_bank.blood_detail SET no_of_donation='" +  +"',no_of_requisition='" +  + "' WHERE abo_group = '" + abo_group + "';";
            cmd = new MySqlCommand(sql, DBConnection.get_conn());

            try
            {
                DBConnection.get_conn().Open();
                adapter = new MySqlDataAdapter(cmd);

                adapter.UpdateCommand = DBConnection.get_conn().CreateCommand();
                adapter.UpdateCommand.CommandText = sql;

                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    if (MessageBox.Show("Successfully Updated!") == DialogResult.OK)
                    {
                        //Dashboard db = new Dashboard();
                        // db.btn_donorView.Click;
                    }
                }
                DBConnection.get_conn().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DBConnection.get_conn().Close();
            }
        }
        #endregion
    */

        #region RETRIEVE DATA FROM DB
        public DataSet retrieve()
        {
            MessageBox.Show(donationNo());
            //string connectionString = ""; //Set your MySQL connection string here.
            string sql = "SELECT * FROM blood_bank.blood_detail;"; // set query to fetch data "Select * from  tabelname"; 

            adapter = new MySqlDataAdapter(sql, DBConnection.get_conn());

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }
        #endregion
    }
}

