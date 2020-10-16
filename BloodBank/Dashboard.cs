using BloodBank.Forms.Donner;
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
            panelSideSubMenu3.Visible = false;
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
            if (panelSideSubMenu3.Visible == true)
            {
                panelSideSubMenu3.Visible = false;
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
            panelSideSubMenu3.Visible = false;
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

        private Form activeForm = null;
        #region OpenChildForm
        private void OpenChildForm(Form childForm)
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
        }
        #endregion

        private void btn_receiver_Click(object sender, EventArgs e)
        {
            SubMenu(panelSideSubMenu2);//pass the sub panel when clicked
            //if this is opend close the others
            panelSideSubMenu1.Visible = false;
            panelSideSubMenu3.Visible = false;
        }

        private void btn_blood_Click(object sender, EventArgs e)
        {
            SubMenu(panelSideSubMenu3);//pass the sub panel when clicked
            //if this is opend close the others
            panelSideSubMenu1.Visible = false;
            panelSideSubMenu2.Visible = false;
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
          
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
    }
}
