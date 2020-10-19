using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BloodBank;

namespace BloodBank
{
    //Donor class contains donor's attributes
    //Donor class inherit all properties and method from Person class according to their visiblity
    class Donor : Person 
    {
        private MySqlCommand cmd;
        private MySqlDataAdapter adapter;
        private DataTable dt = new DataTable();
        private string occupation;
        DonorTable tb = new DonorTable();
        //set and get method to set values and to return the value of defind variables
        public string Occupation { 
            get => occupation; 
            set => occupation = value;
        }


        //method to insert values to database
        #region INSERT DONOR
        public void addDonner(Donor ob)
        {
            //SQL STMT
            string sql = "INSERT INTO blood_bank.donor(first_name, last_name,sex, dob, abo_group, rh, weight, phone_no,email, address, occupation, last_time_donation) VALUES('"+ob.FName+"', '"+ob.LName+"', '"+ob.Sex+"', '"+ob.DOB1+"', '"+ob.AboGroup+"', '"+ob.RH1+"', '"+ob.Weight+"', '"+ob.PhoneNo+"', '"+ob.Email+"', '"+ob.Address+"', '"+ob.occupation+"', '"+ob.Date+"')";
            //This is command class which will handle the query and connection object.  
            cmd = new MySqlCommand(sql, DBConnection.get_conn());
            //open con and exec insert
            try
            {
                DBConnection.get_conn().Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Successfully Inserted!");
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

        //add to gridview
        private void populate(string id)
        {
            tb.dataGrid_donor.Rows.Add(id);
        }
        //retrieve from database
        public void retrieve()
        {
            tb.dataGrid_donor.Rows.Clear();
            //SqlDbType stmt
            string sql = "SELECT * FROM blood_bank.donor";
            cmd = new MySqlCommand(sql, DBConnection.get_conn());

            //open dbconnection and fill grid
           
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                tb.dataGrid_donor.DataSource = dt;
                //loop through dt
                //foreach(DataRow row in dt.Rows)
                //{
                //    populate(row[0].ToString());
                //}
                DBConnection.get_conn().Close();
                //clear DT
                dt.Clear();
            
        }

    }
}
