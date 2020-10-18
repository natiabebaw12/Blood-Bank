using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank.Forms.Donner
{
    public partial class DonnerForm : Form
    {
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

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
