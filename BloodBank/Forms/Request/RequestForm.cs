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
