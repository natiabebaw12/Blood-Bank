using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank.Forms.Receiver
{
    public partial class ReceiverForm : Form
    {
        private string hospitalName, doctor, history, requiredBloodUnit, hospitalPhoneNo, patientRegdNo;
        private int noRequiredUnit;
        private string fName, lName, sex, DOB, aboGroup, RH, phoneNo, email, address, date;
        float weight;

        Patient patient = new Patient();
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            getFromForm();
            if (btn_submit.Text == "Submit")
            {
                //invok this method to add to db
                patient.addPatient(patient);
            }
            if (btn_submit.Text == "Update")
            {
                //invok this method to add to db
               patient.update(patient, int.Parse(lbl_patientId.Text));
            }
        }

        

        #region GET VALUE FROM THE FORM
        public void getFromForm()
        {

            fName = txt_patientFName.Text;
            lName = txt_patientLName.Text;
            //check which radio is selected
            if (radio_patientMale.Checked == true)
            {
                sex = "Male";
            }
            else if (radio_patientFemale.Checked == true)
            {
                sex = "Female";
            }

            DOB = date_patientDOB.Value.ToString("dd MMM yyyy");
            aboGroup = combo_patientAboGroup.Text;
            RH = combo_patientRh.Text;
            phoneNo = txt_patientPhoneNo.Text;
            email = txt_patientemail.Text;
            address = txt_address.Text;
            date = date_patientDate.Value.ToString("dd MMM yyyy");

            weight = float.Parse(txt_patientWeight.Text);
            hospitalName = txt_hospitalName.Text;
            patientRegdNo = txt_patientRegdNo.Text;
            doctor = txt_doctor.Text;
            //check which radio is selected
            if (radio_patientYes.Checked == true)
            {
                history = "Yes";
            }
            else if (radio_patientNo.Checked == true)
            {
                history = "No";
            }
            requiredBloodUnit = combo_bloodRequired.Text;
            noRequiredUnit = Convert.ToInt32(num_requiredUnit.Value);
            hospitalPhoneNo = txt_hospitalPhoneNo.Text;

            patient.FName = fName;
            patient.LName = lName;
            patient.Sex = sex;
            patient.DOB1 = DOB;
            patient.AboGroup = aboGroup;
            patient.RH1 = RH;
            patient.PhoneNo = phoneNo;
            patient.Email = email;
            patient.Address = address;
            patient.Date = date;
            patient.Weight = weight;
            patient.HospitalName = hospitalName;
            patient.PatientRegdNo = patientRegdNo;
            patient.Doctor = doctor;
            patient.History = history;
            patient.RequiredBloodUnit = requiredBloodUnit;
            patient.NoRequiredUnit = noRequiredUnit;
            patient.HospitalPhoneNo = hospitalPhoneNo;
        }
        #endregion
        #region SET THE FORM
        public void setForm(int patient_id, string fName,string lName,string sex,string DOB,float weight,
string aboGroup,string RH,string hospitalName,string hospitalPhone,string patientRegdNo,string doctor,
string history,string reqBlood,int noReqBlood,string phoneNo,string email,string address,string date
)
        {
            lbl_patientId.Text = patient_id.ToString();
            txt_patientFName.Text = fName;
            txt_patientLName.Text = lName;
            if (sex == "Male")
            {
                radio_patientMale.Checked = true;
            }
            if (sex == "Female")
            {
                radio_patientFemale.Checked = true;
            }
            date_patientDOB.Text = DOB;
            combo_patientAboGroup.Text = aboGroup;
            combo_patientRh.Text = RH;
            txt_patientWeight.Text = weight.ToString();
            txt_patientPhoneNo.Text = phoneNo;
            txt_patientemail.Text = email;
            txt_address.Text = address;
            txt_hospitalName.Text = hospitalName;
            txt_patientRegdNo.Text = patientRegdNo;
            txt_doctor.Text = doctor;
            if (history == "Yes")
            {
                radio_patientYes.Checked = true;
            }
            if (history == "No")
            {
                radio_patientNo.Checked = true;
            }
            txt_hospitalPhoneNo.Text = hospitalPhone;
            combo_bloodRequired.Text = reqBlood;
            num_requiredUnit.Value = noReqBlood;
            date_patientDate.Text = date;
            //change the button text from 'submit' to 'update'
            btn_submit.Text = "Update";
            //pass this form to display on the panel with their data set
            /* Form activeForm = null;
            Form copyForm = null;
           
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = this;
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            dash.get_panelAddForm().Controls.Add(this);
            dash.get_panelAddForm().Tag = this;
            this.BringToFront();
            this.Show();
            copyForm = this; */
            Dashboard.OpenChildForm(this);
        }
        #endregion
        #region RESET THE FORM
        private void reset()
        {
            lbl_patientId.Text = "-";
            txt_patientFName.Clear();
            txt_patientLName.Clear();
            radio_patientFemale.Checked = false;
            radio_patientMale.Checked = false;
            date_patientDOB.ResetText();
            txt_patientWeight.Clear();
            combo_patientAboGroup.SelectedIndex = 0;
            combo_patientRh.SelectedIndex = 0;
            txt_hospitalName.Clear();
            txt_patientRegdNo.Clear();
            txt_doctor.Clear();
            radio_patientYes.Checked = false;
            radio_patientNo.Checked = false;
            combo_bloodRequired.SelectedIndex = 0;
            num_requiredUnit.Value = 0;
            txt_patientPhoneNo.Clear();
            txt_patientemail.Clear();
            txt_hospitalPhoneNo.Clear();
            txt_address.Clear();
            date_patientDate.ResetText();
        }
        #endregion
        public ReceiverForm()
        {
            InitializeComponent();
        ///default choose for combo_box
            combo_bloodRequired.SelectedIndex = 0;
            combo_patientAboGroup.SelectedIndex = 0;
            combo_patientRh.SelectedIndex = 0;
            date_patientDOB.Value = DateTime.Now;
            date_patientDate.Value = DateTime.Now;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void combo_patientAboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aboGroupSelected = combo_patientAboGroup.Text;
            //check the selected value and then change CheckBox_RH value dynamically
            if (aboGroupSelected == "A")
            {
                combo_patientRh.Items.Clear();
                combo_patientRh.Items.Add("A+");
                combo_patientRh.Items.Add("A-");
            }
            if (aboGroupSelected == "B")
            {
                combo_patientRh.Items.Clear();
                combo_patientRh.Items.Add("B+");
                combo_patientRh.Items.Add("B-");
            }
            if (aboGroupSelected == "AB")
            {
                combo_patientRh.Items.Clear();
                combo_patientRh.Items.Add("AB+");
                combo_patientRh.Items.Add("AB-");
            }
            if (aboGroupSelected == "O")
            {
                combo_patientRh.Items.Clear();
                combo_patientRh.Items.Add("O+");
                combo_patientRh.Items.Add("O-");
            }
            combo_patientRh.SelectedIndex = 0;
        }
    }
}
