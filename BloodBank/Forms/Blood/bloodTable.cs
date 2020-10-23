using BloodBank;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank.Forms
{
    public partial class bloodTable : Form
    {
        Blood bl = new Blood();
        public bloodTable()
        {
            InitializeComponent();
        }

        private void bloodTable_Load(object sender, EventArgs e)
        {
            grid_blood.DataSource = bl.retrieve().Tables[0];
        }
    }
}
