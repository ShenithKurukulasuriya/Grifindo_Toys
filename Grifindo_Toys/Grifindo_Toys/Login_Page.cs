using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Toys
{
    public partial class Login_Page : Form
    {
        private string Username = "Shenith";
        private string Password = "2001";
        public Login_Page()
        {
            InitializeComponent();
        }
        
        private void Login_Page_Load(object sender, EventArgs e)
        {
            
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            label4.BackColor = Color.FromArgb(100, 0, 0, 0);
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username ==Username && password == Password)
            {
                MessageBox.Show("Login successfull");

                Main_Screen gotomainscreen = new Main_Screen();
                gotomainscreen.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}
