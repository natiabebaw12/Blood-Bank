
using BloodBank;
using BloodBank.Forms.Receiver;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        #region CustomizeDesign Method
        private void CustomizeDesign()
        {   
            //hide the side menu initially
            panelSideSubMenu1.Visible = false;
            panelSideSubMenu2.Visible = false;
        }
        #endregion
        #region HideMenu 
        private void HideMenu() //method to hide the submenu when it called
        {
            if (panelSideSubMenu1.Visible == true)
            {
                panelSideSubMenu1.Visible = false;
            }
            if (panelSideSubMenu2.Visible == true)
            {
                panelSideSubMenu2.Visible = false;
            }
            
        }
        #endregion
        #region SubMenu
        private void SubMenu(Panel subMenu)
        {
            //check whether the subpanel is visible or not
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        #endregion

        private void btn_Donner_Click(object sender, EventArgs e)
        {
            SubMenu(panelSideSubMenu1);//pass the sub panel when clicked
            //if this is opend close the others
            panelSideSubMenu2.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DonnerForm()); //pass the form to display on the child panel
            //...
            //Hide when clicked
            //...
            HideMenu();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DonorTable());

            //...
            //Hide when clicked
            //...
            HideMenu();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            //...
            //Hide when clicked
            //...
            HideMenu();
        }

        private static Form activeForm = null;
        private static Form copyForm = null;
        #region OpenChildForm
        public static void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelAddForm.Controls.Add(childForm);
            panelAddForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            copyForm = childForm;
        }
        #endregion

        #region CloseChildForm or Home
        private void CloseChildForm(Form childForm)
        {
            childForm.Hide();
        }
        #endregion
        private void btn_receiver_Click(object sender, EventArgs e)
        {
            SubMenu(panelSideSubMenu2);//pass the sub panel when clicked
            //if this is opend close the others
            panelSideSubMenu1.Visible = false;
        }

        private void btn_blood_Click(object sender, EventArgs e)
        {
            
            //if this is opend close the others
            panelSideSubMenu1.Visible = false;
            panelSideSubMenu2.Visible = false;
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReceiverForm()); //pass the form to display on the child panel
            //...
            //Hide when clicked
            //...
            HideMenu();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            //...
            //Hide when clicked
            //...
            HideMenu();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            //...
            //Hide when clicked
            //...
            HideMenu();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            //...
            //Hide when clicked
            //...
            HideMenu();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            //...
            //Hide when clicked
            //...
            HideMenu();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            //...
            //Hide when clicked
            //...
            HideMenu();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CloseChildForm(copyForm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {   
            OpenChildForm(new DonorTable());//pass donor_table to display it on dashboard
            //...
            //Hide when clicked
            //...
            HideMenu();
        }


    }
}
