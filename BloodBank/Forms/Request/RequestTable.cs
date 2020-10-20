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
        public RequestTable()
        {
            InitializeComponent();
        }

        private void RequestTable_Load(object sender, EventArgs e)
        {
            grid_patient.DataSource = patient.retrieve().Tables[0];
        }
    }
}
