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
        public ReceiverForm()
        {
            InitializeComponent();
        ///default choose for combo_box
            combo_bloodRequired.SelectedIndex = 0;
            combo_receiverABOGroup.SelectedIndex = 0;
            combo_receiverRH.SelectedIndex = 0;
        }
    }
}
