using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Grifindo_Toys
{
    public partial class Add_Employee : Layout
    {
        //Sql connection string
        private readonly string conString = "Data Source=DESKTOP-LJ5HQHT\\SQLEXPRESS01;Initial Catalog=Payroll;Integrated Security=True;";


        public Add_Employee()
        {
            InitializeComponent();
        }


        //Add data to the sql database
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);

            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Employee (Emp_ID, Name, Date_Column, Email, Street, City, Province, Country, Postal_Code, Contact, Month_Sal, OT_rate, Allowances) VALUES (@Emp_ID, @Name, @Date_Column, @Email, @Street, @City, @Province, @Country, @Postal_Code, @Contact, @Month_Sal, @OT_rate, @Allowances)", con);

            decimal overtimeRatePercentage = decimal.Parse(txtOverTimeRate.Text) / 100;

            cmd.Parameters.AddWithValue("@Emp_ID", int.Parse(txtEmployeeID.Text));
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Date_Column", dateTimePickerDOB.Value);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Street", txtStreet.Text);
            cmd.Parameters.AddWithValue("@City", txtCity.Text);
            cmd.Parameters.AddWithValue("@Province", txtDistrict.Text);
            cmd.Parameters.AddWithValue("@Country", txtCountry.Text);
            cmd.Parameters.AddWithValue("@Postal_Code", txtPostalCode.Text);
            cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
            cmd.Parameters.AddWithValue("@Month_Sal", int.Parse(txtMonthlySalary.Text));
            cmd.Parameters.AddWithValue("@OT_rate", overtimeRatePercentage);
            cmd.Parameters.AddWithValue("@Allowances", int.Parse(txtAllowences.Text));





            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Data saved successfully!");
            }
            else
            {
                MessageBox.Show("Failed to save data!");
            }

            //close the data add form and return to the previous page
            this.Close();

            CRUD_employee crudform = new CRUD_employee();
            crudform.Show();
        }

        //clear all the textboxes
        private void ClearFields()
        {
            txtEmployeeID.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtStreet.Text = "";
            txtCity.Text = "";
            txtDistrict.Text = "";
            txtCountry.Text = "";
            txtPostalCode.Text = "";
            txtContact.Text = "";
            txtMonthlySalary.Text = "";
            txtOverTimeRate.Text = "";
            txtAllowences.Text = "";
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

 
    }
}
