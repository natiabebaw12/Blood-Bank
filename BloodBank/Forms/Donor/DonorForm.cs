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
            combo_donnerABOGroup.SelectedIndex = 0;
            combo_donnerRH.SelectedIndex = 0;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
