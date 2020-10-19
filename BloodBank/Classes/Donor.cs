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
        private DataSet table;
        private string occupation;
        DonorTable grid = new DonorTable();
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

        
        public DataSet retrieve()
        {
            //string connectionString = ""; //Set your MySQL connection string here.
            string sql = "SELECT * FROM blood_bank.donor;"; // set query to fetch data "Select * from  tabelname"; 
            
            adapter = new MySqlDataAdapter(sql, DBConnection.get_conn());
                
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    return ds;
                
            
        }

    }
}
