using BloodBank.Forms.Receiver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank.Forms.Request
{
    public partial class RequestTable : Form
    {
        Patient patient = new Patient();

        #region GET DATA FROM GRID
        public void getFromGrid()
        {
            int patent_id = Convert.ToInt32(grid_patient.SelectedRows[0].Cells[0].Value);
            string fName = grid_patient.SelectedRows[0].Cells[1].Value.ToString();
            string lName = grid_patient.SelectedRows[0].Cells[2].Value.ToString();
            string sex = grid_patient.SelectedRows[0].Cells[3].Value.ToString();
            string DOB = grid_patient.SelectedRows[0].Cells[4].Value.ToString();
            float weight = float.Parse(grid_patient.SelectedRows[0].Cells[5].Value.ToString());
            string aboGroup = grid_patient.SelectedRows[0].Cells[6].Value.ToString();
            string RH = grid_patient.SelectedRows[0].Cells[7].Value.ToString();
            string hospitalName = grid_patient.SelectedRows[0].Cells[8].Value.ToString();
            string hospitalPhone = grid_patient.SelectedRows[0].Cells[9].Value.ToString();
            string patientRegdNo = grid_patient.SelectedRows[0].Cells[10].Value.ToString();
            string doctor = grid_patient.SelectedRows[0].Cells[11].Value.ToString();
            string history = grid_patient.SelectedRows[0].Cells[12].Value.ToString();
            string reqBlood = grid_patient.SelectedRows[0].Cells[13].Value.ToString();
            int noReqBlood = Convert.ToInt32(grid_patient.SelectedRows[0].Cells[14].Value);
            string phoneNo = grid_patient.SelectedRows[0].Cells[15].Value.ToString();
            string email = grid_patient.SelectedRows[0].Cells[16].Value.ToString();
            string address = grid_patient.SelectedRows[0].Cells[17].Value.ToString();
            string date = grid_patient.SelectedRows[0].Cells[18].Value.ToString();

            ReceiverForm pa = new ReceiverForm();
                 pa.setForm(patent_id, fName, lName,sex,DOB,weight,aboGroup,RH,hospitalName,
hospitalPhone,patientRegdNo,doctor,history,reqBlood,noReqBlood,phoneNo,email,address,date

);

        }
        #endregion
        public RequestTable()
        {
            InitializeComponent();
        }

        private void RequestTable_Load(object sender, EventArgs e)
        {
            grid_patient.DataSource = patient.retrieve().Tables[0];
        }

        private void btn_deleteDonor_Click(object sender, EventArgs e)
        {
            int patient_id = Convert.ToInt32(grid_patient.SelectedRows[0].Cells[0].Value);
            patient.delete(patient_id);
            grid_patient.DataSource = patient.retrieve().Tables[0];
        }

        private void btn_updateDonor_Click(object sender, EventArgs e)
        {
            getFromGrid();
        }
    }
}
