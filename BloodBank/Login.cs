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
    public partial class Login : Form
    {
        private string username;
        private string password;
        public Login()
        {
            InitializeComponent();
        }


        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            username = text_userName.Text;
            password = text_password.Text;

            if(username == "microlink" && password == "pass123")
            {
                this.Hide();
                Dashboard board = new Dashboard();
                board.Show();
            }
            else if(username == "" && password == "")
            {
                MessageBox.Show("Please, Enter username and password!");
            }else
            {
                MessageBox.Show("username or password is incorrect!");
            }
        }
    }
}
