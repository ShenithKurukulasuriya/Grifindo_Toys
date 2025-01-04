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
using System.Xml.Linq;





namespace Grifindo_Toys
{
    public partial class CRUD_employee : Layout
    {
        //Sql connection string
        private readonly string conString = "Data Source=DESKTOP-LJ5HQHT\\SQLEXPRESS01;Initial Catalog=Payroll;Integrated Security=True;";

        public CRUD_employee()
        {
            InitializeComponent();
            this.BindGrid();


        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            //open the employee insert form
            this.Close();
            Add_Employee gotoemppage = new Add_Employee();

            
            gotoemppage.Show();
        }
        public void BindGrid()
        {
            // retrive the sql database employee table data
            string connect = (conString);
            using (SqlConnection conn = new SqlConnection(connect))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT*FROM Employee", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
        }





        private void btnCancelU_Click(object sender, EventArgs e)
        {
            ClearFieldsr();
        }

        //clear all the textboxes
        private void ClearFieldsr()
        {
            txtEmployeeIDU.Text = "";
            txtNameU.Text = "";
            txtPhoneNumberU.Text = "";
            txtEmailU.Text = "";
            txtStreetU.Text = "";
            txtCityU.Text = "";
            txtDistrictU.Text = "";
            txtCountryU.Text = "";
            txtPostalCodeU.Text = "";
            txtAllowancesU.Text = "";
            txtMonthlySalaryU.Text = "";
            txtOverTimeRateU.Text = "";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {


            try
            {
                
                // search an employee based on their employee id or name
                string query = "SELECT * FROM Employee WHERE Name LIKE @Name OR Emp_ID = @EmployeeID";

                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    adapter.SelectCommand.Parameters.AddWithValue("@Name", "%" + txtSearch.Text + "%");
                    adapter.SelectCommand.Parameters.AddWithValue("@EmployeeID", int.Parse(txtSearch.Text));

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }



        //get the data from the database when user click on a record and pass the data into a textbox
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count >= 0)
                {
                    txtEmployeeIDU.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    txtNameU.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    txtEmailU.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    txtStreetU.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    txtCityU.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    txtDistrictU.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    txtCountryU.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                    txtPostalCodeU.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                    txtPhoneNumberU.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                    txtMonthlySalaryU.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                    txtOverTimeRateU.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                    txtAllowancesU.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                    dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid selection please double click on a row ");
            }
        }


        //Delete an existing record
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int selectedEmpId = Convert.ToInt32(selectedRow.Cells["Emp_ID"].Value);
                string connectr = (conString);
                using (SqlConnection conr = new SqlConnection(connectr))
                {
                    conr.Open();

                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Employee WHERE Emp_ID = @Emp_ID", conr))
                    {
                        cmd.Parameters.AddWithValue("@Emp_ID", selectedEmpId);

                        try
                        {
                            int rowsAffected = cmd.ExecuteNonQuery();
                            conr.Close();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record deleted successfully");

                                BindGrid();
                            }
                            else
                            {
                                MessageBox.Show("Couldnt delete the record");
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("SQL Error:" + ex.Message);
                        }
                    }
                }
            }
        }


        //Update an existing record
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlCommand command = new SqlCommand(
                    "UPDATE Employee SET " +
                    "Name = @Name, " +
                    "Date_Column = @Date_Column, " +
                    "Email = @Email, " +
                    "Street = @Street, " +
                    "City = @City, " +
                    "Province = @Province, " +
                    "Country = @Country, " +
                    "Postal_Code = @Postal_Code, " +
                    "Contact = @Contact, " +
                    "Month_sal = @Month_sal, " +
                    "OT_rate = @OT_rate, " +
                    "Allowances = @Allowances " +
                    "WHERE Emp_ID = @Emp_ID", con);

                decimal overtimeRatePercentage = decimal.Parse(txtOverTimeRateU.Text) / 100;


                // Add parameters with values
                command.Parameters.AddWithValue("@Name", txtNameU.Text);
                command.Parameters.AddWithValue("@Date_Column", dateTimePicker1.Value);
                command.Parameters.AddWithValue("@Email", txtEmailU.Text);
                command.Parameters.AddWithValue("@Street", txtStreetU.Text);
                command.Parameters.AddWithValue("@City", txtCityU.Text);
                command.Parameters.AddWithValue("@Province", txtDistrictU.Text);
                command.Parameters.AddWithValue("@Country", txtCountryU.Text);
                command.Parameters.AddWithValue("@Postal_Code", txtPostalCodeU.Text);
                command.Parameters.AddWithValue("@Contact", txtPhoneNumberU.Text);
                command.Parameters.AddWithValue("@Month_sal", int.Parse(txtMonthlySalaryU.Text));
                command.Parameters.AddWithValue("@Allowances", int.Parse(txtAllowancesU.Text));
                command.Parameters.AddWithValue("@OT_rate", overtimeRatePercentage);

                command.Parameters.AddWithValue("@Emp_ID", int.Parse(txtEmployeeIDU.Text));

                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully updated");

                BindGrid();
            }
        }


    }
}
