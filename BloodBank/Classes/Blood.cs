using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    class Blood
    {
        private MySqlCommand cmd;
        private MySqlDataAdapter adapter;

       
     
        #region UPDATE THE DATABASE
        public void update(int id, int flag)
        {
            string sql = "";
            if (flag == 1)
            {
                sql = "UPDATE blood_bank.blood_detail  SET no_of_donation = no_of_donation +1 WHERE idblood_detail = '" + id + "';";
            }else if (flag == 0)
            {
                sql = "UPDATE blood_bank.blood_detail  SET no_of_donation = no_of_donation -1 WHERE idblood_detail = '" + id + "';";
            }
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
    

        #region RETRIEVE DATA FROM DB
        public DataSet retrieve()
        {
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

