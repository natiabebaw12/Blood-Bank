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
        private string fName, lName, sex, DOB, aboGroup, RH, phoneNo, email, address, date, occupation;
        private float weight;
        //pass the values to donor set method
        Donor donorOb = new Donor();

        private void checkBox_donorOccOther_CheckedChanged(object sender, EventArgs e)
        {
            occupation = "Other";
            groupBox5.Enabled = false;
        }

        private void btn_checkBoxReset_Click(object sender, EventArgs e)
        {
            groupBox5.Enabled = true;
        }

        private void checkBox_donorOccMonk_CheckedChanged(object sender, EventArgs e)
        {
            occupation = "Priesi, Monk";
            groupBox5.Enabled = false;
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

        public DonnerForm()
        {
            InitializeComponent();
            combo_donorAboGroup.SelectedIndex = 0;
            combo_donnerRH.SelectedIndex = 0;
            date_donorDOB.Value = DateTime.Now;
        }
        //function to reset the form or to make it empty
        #region
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

        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            fName = txt_donorFName.Text;
            lName = txt_donorLName.Text;
            //check which radio is selected
            if(radio_donorMale.Checked == true)
            {
                sex = "Male";
            }else if(radio_donorFemale.Checked == true)
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
            donorOb.Occupation = occupation;
            donorOb.Weight = weight;

            //invok this method to add to db
            donorOb.addDonner(donorOb);
    }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
