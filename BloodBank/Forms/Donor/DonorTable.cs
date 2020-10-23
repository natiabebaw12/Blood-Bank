using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{

    public partial class DonorTable : Form
    {

        Donor dn = new Donor();
        public DonorTable()
        {
            InitializeComponent();
        }

        private void dataGrid_donor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DonorTable_Load(object sender, EventArgs e)
        {
            dataGrid_donor.DataSource = dn.retrieve().Tables[0];
        }

        private void btn_updateDonor_Click(object sender, EventArgs e)
        {
            getFromGrid();

        }
        #region GET DATA FROM GRID
        public void getFromGrid()
        {
            int donor_id = Convert.ToInt32(dataGrid_donor.SelectedRows[0].Cells[0].Value);
            string fName = dataGrid_donor.SelectedRows[0].Cells[1].Value.ToString();
            string lName = dataGrid_donor.SelectedRows[0].Cells[2].Value.ToString();
            string sex = dataGrid_donor.SelectedRows[0].Cells[3].Value.ToString();
            string DOB = dataGrid_donor.SelectedRows[0].Cells[4].Value.ToString();
            string aboGroup = dataGrid_donor.SelectedRows[0].Cells[5].Value.ToString();
            string RH = dataGrid_donor.SelectedRows[0].Cells[6].Value.ToString();
            float weight = float.Parse(dataGrid_donor.SelectedRows[0].Cells[7].Value.ToString());
            string phoneNo = dataGrid_donor.SelectedRows[0].Cells[8].Value.ToString();
            string email = dataGrid_donor.SelectedRows[0].Cells[9].Value.ToString();
            string address = dataGrid_donor.SelectedRows[0].Cells[10].Value.ToString();
            string occupation = dataGrid_donor.SelectedRows[0].Cells[11].Value.ToString();
            string date = dataGrid_donor.SelectedRows[0].Cells[12].Value.ToString();

            DonnerForm df = new DonnerForm();
            df.setForm(donor_id, fName, lName, sex, DOB, aboGroup, RH,
                     weight, phoneNo, email, address, occupation, date);

        }
        #endregion

        private void btn_deleteDonor_Click(object sender, EventArgs e)
        {
            int donor_id = Convert.ToInt32(dataGrid_donor.SelectedRows[0].Cells[0].Value);
            dn.delete(donor_id);
            dataGrid_donor.DataSource = dn.retrieve().Tables[0];
        }

        public void afterUpdate()
        {   
            dataGrid_donor.DataSource = dn.retrieve().Tables[0];
        }

        private void dataGrid_donor_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txt_searchDonor_TextChanged(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter;
            DataSet ds = new DataSet();
            #region OUTER LOOP
            if (txt_searchDonor.Text != "")//checks if the text box is or not empty
            {
                
                string search_value = txt_searchDonor.Text;//get user entered text
                #region ID INNER LOOP
                if (search_value.All(char.IsDigit))//CHECKS IF THE ENTERD TEXT IS A DIGIT OR NOT
                {
                    foreach (DataGridViewRow a in dataGrid_donor.Rows)//loop through row 
                    {
                        if (Convert.ToInt32(a.Cells[0].Value) == Convert.ToInt32(search_value))//check if the first coloum or id is equal
                        {
                            //string connectionString = ""; //Set your MySQL connection string here.
                            string sql = "SELECT * FROM `blood_bank`.`donor` WHERE donor_id = '" + search_value + "';"; // set query to fetch data "Select * from  tabelname"; 

                            adapter = new MySqlDataAdapter(sql, DBConnection.get_conn());
                            adapter.Fill(ds);
                            dataGrid_donor.DataSource = ds.Tables[0];//show only the searched id data
                        }
                    }
                }
                #endregion
                #region STRIG INNER LOOP
                else //IF IT'S A STRING
                {
                    foreach (DataGridViewRow a in dataGrid_donor.Rows)//loop through row 
                    {
                      if (a.Cells[5].Value != null) { 
                        if (a.Cells[5].Value.ToString() == search_value.ToUpper())//check if the fifth coloum or abo_groups is equal
                            {
                            //string connectionString = ""; //Set your MySQL connection string here.
                            string sql = "SELECT * FROM `blood_bank`.`donor` WHERE abo_group = '" + search_value.ToUpper() + "';"; // set query to fetch data "Select * from  tabelname"; 

                            adapter = new MySqlDataAdapter(sql, DBConnection.get_conn());

                            adapter.Fill(ds);
                            dataGrid_donor.DataSource = ds.Tables[0];//show only the searched abo_groups data
                        }
                      }
                    }
                }
                #endregion
            }
            #endregion
            else//if the search box is empty show all data
            {
                dataGrid_donor.DataSource = dn.retrieve().Tables[0];
            }
        }
    }
}
