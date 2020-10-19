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
        public DonorTable()
        {
            InitializeComponent();
        }

        private void dataGrid_donor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DonorTable_Load(object sender, EventArgs e)
        {
            Donor d = new Donor();
            dataGrid_donor.DataSource =  d.retrieve().Tables[0];
        }
    }
}
