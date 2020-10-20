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
    }
}
