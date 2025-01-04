using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Toys
{
    public partial class Layout : Form
    {

        private Main_Screen mainScreenForm;
        private CRUD_employee crudEmployeeForm;
        private Salary salaryForm;
        private Add_Employee addEmployeeForm;
        private Settings settingsForm;

        public Layout()
        {
            InitializeComponent();
        }


        //navigation panel button for open home page
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (mainScreenForm == null || mainScreenForm.IsDisposed)
            {
                mainScreenForm = new Main_Screen();
                mainScreenForm.FormClosed += (s, args) => mainScreenForm = null; // Ensure form reference is cleared when closed
            }
            mainScreenForm.Show();
            mainScreenForm.BringToFront();
        }


        //navigation panel button for employee page
        private void btnEMpControl_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (crudEmployeeForm == null || crudEmployeeForm.IsDisposed)
            {
                crudEmployeeForm = new CRUD_employee();
            }
            crudEmployeeForm.Show();
            crudEmployeeForm.BringToFront();
        }

        //navigation panel button for open salary page
        private void btngotosal_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (salaryForm == null || salaryForm.IsDisposed)
            {
                salaryForm = new Salary();
            }
            salaryForm.Show();
            salaryForm.BringToFront();
        }


        //navigation panel button for open employee add page
        private void btnAddPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (addEmployeeForm == null || addEmployeeForm.IsDisposed)
            {
                addEmployeeForm = new Add_Employee();
            }
            addEmployeeForm.Show();
            addEmployeeForm.BringToFront();
        }

        //navigation panel button for open settings page
        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (settingsForm == null || settingsForm.IsDisposed)
            {
                settingsForm = new Settings();
            }
            settingsForm.Show();
            settingsForm.BringToFront();

        }


        //navigation panel button for back function
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Page gotologintpage = new  Login_Page();
            gotologintpage.Show();
        }
    }
}
