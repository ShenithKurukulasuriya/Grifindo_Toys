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
    public partial class Main_Screen : Layout
    {
        public Main_Screen()
        {
            InitializeComponent();
        }

        private void btnEmployeeControl_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_employee gotonextpage = new CRUD_employee();
            gotonextpage.Show();


        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings gotosetting = new Settings();
            gotosetting.Show();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            this.Hide();
            Salary gotosalary = new Salary();
            gotosalary.Show();
        }


        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Employee gotoaddemployee = new Add_Employee();
            gotoaddemployee.Show();
        }
    }
}
