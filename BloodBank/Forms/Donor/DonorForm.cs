using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BloodBank;

namespace BloodBank
{
    
    public partial class DonnerForm : Form
    {
        private string fName, lName, sex, DOB, aboGroup, RH, phoneNo, email, address, date, donation_date, occupation;
        private float weight;
        //pass the values to donor set method
        Donor donorOb = new Donor();

        #region GET VALUE FROM THE FORM
        public void getFromForm()
        {

            fName = txt_donorFName.Text;
            lName = txt_donorLName.Text;
            //check which radio is selected
            if (radio_donorMale.Checked == true)
            {
                sex = "Male";
            }
            else if (radio_donorFemale.Checked == true)
            {
                sex = "Female";
            }

            DOB = date_donorDOB.Value.ToString("dd MMM yyyy");
            aboGroup = combo_donorAboGroup.Text;
            RH = combo_donnerRH.Text;
            phoneNo = txt_donorPhoneNo.Text;
            email = txt_donorEmail.Text;
            address = textBox_donorAddress.Text;
            date = cal_donorLastTime.SelectionStart.ToString("dd MMM yyyy");

            weight = float.Parse(txt_donorWeight.Text);

            donorOb.FName = fName;
            donorOb.LName = lName;
            donorOb.Sex = sex;
            donorOb.DOB1 = DOB;
            donorOb.AboGroup = aboGroup;
            donorOb.RH1 = RH;
            donorOb.PhoneNo = phoneNo;
            donorOb.Email = email;
            donorOb.Address = address;
            donorOb.Date = date;
            donorOb.Donation_date = date_donorDate.Value.ToString("dd MMM yyyy");
            donorOb.Occupation = occupation;
            donorOb.Weight = weight;
        }
        #endregion

        #region SET THE FORM
        public void setForm(int donor_id, string fName, string lName, string sex, string DOB, string aboGroup, string RH,
            float weight, string phoneNo, string email, string address, string occupation,string date, string donationDate)
        {
            lbl_donorId.Text = donor_id.ToString();
            txt_donorFName.Text = fName;
            txt_donorLName.Text = lName;
            if (sex == "Male")
            {
                radio_donorMale.Checked = true;
            }
            if (sex == "Female")
            {
                radio_donorFemale.Checked = true;
            }
            date_donorDOB.Text = DOB;
            combo_donorAboGroup.Text = aboGroup;
            combo_donnerRH.Text = RH;
            txt_donorWeight.Text = weight.ToString();
            txt_donorPhoneNo.Text = phoneNo;
            txt_donorEmail.Text = email;
            textBox_donorAddress.Text = address;
            if (checkBox_donorOccEmp.Text == occupation)
            {
                checkBox_donorOccEmp.Checked = true;
            }
            if (checkBox_donorOccGov.Text == occupation)
            {
                checkBox_donorOccGov.Checked = true;
            }
            if (checkBox_donorOccMonk.Text == occupation)
            {
                checkBox_donorOccMonk.Checked = true;
            }
            if (checkBox_donorOccOther.Text == occupation)
            {
                checkBox_donorOccOther.Checked = true;
            }
            if (checkBox_donorOccMonk.Text == occupation)
            {
                checkBox_donorOccMonk.Checked = true;
            }
            if (checkBox_donorOccStudent.Text == occupation)
            {
                checkBox_donorOccStudent.Checked = true;
            }
            cal_donorLastTime.SetDate(DateTime.Parse(date));
            date_donorDate.Text = donationDate;
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
        //function to reset the form or to make it empty
        #region reset the form
        private void reset()
        {
            lbl_donorId.Text = "-";
            txt_donorFName.Clear();
            txt_donorLName.Clear();
            radio_donorMale.Checked = false;
            radio_donorFemale.Checked = false;
            date_donorDOB.ResetText();
            combo_donorAboGroup.SelectedIndex = 0;
            combo_donnerRH.SelectedIndex = 0;
            txt_donorPhoneNo.Clear();
            txt_donorWeight.Clear();
            txt_donorEmail.Clear();
            textBox_donorAddress.Clear();
            checkBox_donorOccEmp.Checked = false;
            checkBox_donorOccGov.Checked = false;
            checkBox_donorOccMonk.Checked = false;
            checkBox_donorOccOther.Checked = false;
            checkBox_donorOccStudent.Checked = false;
            cal_donorLastTime.SetDate(DateTime.Now);
        }
        #endregion


        public DonnerForm()
        {
            InitializeComponent();
            combo_donorAboGroup.SelectedIndex = 0;
            combo_donnerRH.SelectedIndex = 0;
            date_donorDOB.Value = DateTime.Now;
            date_donorDate.Value = DateTime.Now;
        }

        private void checkBox_donorOccOther_CheckedChanged(object sender, EventArgs e)
        {
            occupation = "Other";
            groupBox5.Enabled = false;
        }

        private void btn_checkBoxReset_Click(object sender, EventArgs e)
        {
            //return checkBox to default
            checkBox_donorOccOther.Checked = false;
            checkBox_donorOccMonk.Checked = false;
            checkBox_donorOccStudent.Checked = false;
            checkBox_donorOccEmp.Checked = false;
            checkBox_donorOccGov.Checked = false;

            groupBox5.Enabled = true;
        }

        private void checkBox_donorOccMonk_CheckedChanged(object sender, EventArgs e)
        {
            occupation = "Priesi, Monk";
            groupBox5.Enabled = false;
        }

        private void combo_donnerRH_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void combo_donorAboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {   
            string aboGroupSelected = combo_donorAboGroup.Text;
            //check the selected value and then change CheckBox_RH value dynamically
            if (aboGroupSelected == "A")
            {
                combo_donnerRH.Items.Clear();
                combo_donnerRH.Items.Add("A+");
                combo_donnerRH.Items.Add("A-");
            }
            if (aboGroupSelected == "B")
            {
                combo_donnerRH.Items.Clear();
                combo_donnerRH.Items.Add("B+");
                combo_donnerRH.Items.Add("B-");
            }
            if (aboGroupSelected == "AB")
            {
                combo_donnerRH.Items.Clear();
                combo_donnerRH.Items.Add("AB+");
                combo_donnerRH.Items.Add("AB-");
            }
            if (aboGroupSelected == "O")
            {
                combo_donnerRH.Items.Clear();
                combo_donnerRH.Items.Add("O+");
                combo_donnerRH.Items.Add("O-");
            }
            combo_donnerRH.SelectedIndex = 0;
        }

        private void checkBox_donorOccEmp_CheckedChanged(object sender, EventArgs e)
        {
            occupation = "Company, employee";
            groupBox5.Enabled = false;
        }

        private void checkBox_donorOccGov_CheckedChanged(object sender, EventArgs e)
        {
            occupation = "Gov. official, solider, police, state enterprise";
            groupBox5.Enabled = false;
        }

        private void checkBox_donorOccStudent_CheckedChanged(object sender, EventArgs e)
        {
            occupation = "Student";
            groupBox5.Enabled = false;
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {
            
        }

       
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            getFromForm();
            if (btn_submit.Text == "Submit")
            {
                //invok this method to add to db
                donorOb.addDonner(donorOb);
            }
            if (btn_submit.Text == "Update")
            {
                //invok this method to add to db
                donorOb.update(donorOb, int.Parse(lbl_donorId.Text));
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            reset();
        }

       
    }
}
