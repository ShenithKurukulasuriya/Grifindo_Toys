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

    public partial class Salary : Layout
    {
        public decimal basePay;
        public decimal Nopay;

        private readonly string conString = "Data Source=DESKTOP-LJ5HQHT\\SQLEXPRESS01;Initial Catalog=Payroll;Integrated Security=True;";

        public Salary()
        {
            InitializeComponent();
            this.BindGridSalary();
        }


        private string GetEmployeeName(int empId)
        {
            string employeeName = "";

            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SELECT Name FROM Employee WHERE Emp_ID = @Emp_ID", connection);
                cmd.Parameters.AddWithValue("@Emp_ID", empId);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // Retrieve the name from the database
                    employeeName = reader.GetString(0); // Assuming Name is stored as string in the database
                }

                reader.Close();
            }

            return employeeName;
        }


        private void btnCalBasePay_Click(object sender, EventArgs e)
        {

            int Emp_ID = int.Parse(txtEmpIDE.Text);

            decimal absentdays = decimal.Parse(txtAbDays.Text);
            decimal overtimehours = decimal.Parse(txtOTH.Text);

            SqlConnection connection = new SqlConnection(conString);

            using (SqlConnection sqlConnection = connection)
            {

                SqlCommand cmd = new SqlCommand("SELECT Month_sal, Allowances, OT_rate FROM Employee WHERE Emp_ID = @Emp_ID", connection);
                cmd.Parameters.AddWithValue("@Emp_ID", Emp_ID);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                int monthlysalary = 0;
                int allowances = 0;
                decimal overtimerate = 0;

                if (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                        monthlysalary = reader.GetInt32(0);
                    if (!reader.IsDBNull(1))
                        allowances = reader.GetInt32(1);
                    if (!reader.IsDBNull(2))
                        overtimerate = reader.GetDecimal(2);
                }

                reader.Close();
                connection.Close();

                basePay = monthlysalary + allowances * (overtimerate * overtimehours);

                txtBasePay.Text = basePay.ToString();
            }
        }


        private void btnCalNoPay_Click(object sender, EventArgs e)
        {
            int Emp_ID = int.Parse(txtEmpIDE.Text);

            decimal absentdays = decimal.Parse(txtAbDays.Text);

            SqlConnection connection = new SqlConnection(conString);

            using (SqlConnection sqlConnection = connection)
            {
                SqlCommand cmd = new SqlCommand("SELECT Month_sal FROM Employee WHERE Emp_ID = @Emp_ID", connection);
                cmd.Parameters.AddWithValue("@Emp_ID", Emp_ID);



                sqlConnection.Open();

                int monthlysalary = (int)cmd.ExecuteScalar();

                cmd.Parameters.Clear();
                SqlCommand cmdSettings = new SqlCommand("SELECT Data_range FROM Settings", connection);
                int daterange = (int)cmdSettings.ExecuteScalar();
                connection.Close();

                Nopay = monthlysalary / daterange * absentdays;

                txtNoPay.Text = Nopay.ToString();
            }
        }

        private void btnCalGrossPay_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(conString);

            using (SqlConnection sqlConnection = connection)
            {
                connection.Open();



                SqlCommand cmdSettings = new SqlCommand("SELECT tax_rate FROM Settings", connection);
                decimal governmentTax = (decimal)cmdSettings.ExecuteScalar();

                connection.Close();
                decimal grossPay = (basePay - (Nopay + (basePay * governmentTax)));
                txtGrossPay.Text = grossPay.ToString();
            }





            int Emp_ID = int.Parse(txtEmpIDE.Text);
            int absentdays = int.Parse(txtAbDays.Text);
            int overtimehours = int.Parse(txtOTH.Text);
            string month = comboBox1.SelectedItem.ToString(); // Assuming comboBox1 contains months
            decimal basePayS = decimal.Parse(txtBasePay.Text);
            decimal NopayS = decimal.Parse(txtNoPay.Text);
            decimal grossPayS = decimal.Parse(txtGrossPay.Text);

            string employeeName = GetEmployeeName(Emp_ID);

            using (SqlConnection connections = new SqlConnection(conString))
            {
                connections.Open();

                // Insert data into Salary table
                SqlCommand insertCommand = new SqlCommand("INSERT INTO Salary (Emp_ID,Name , Month, Base_pay, No_pay, Gross_pay, Absent_days, OT_hours) VALUES (@Emp_ID, @Name , @Month, @Base_pay, @No_pay, @Gross_pay, @Absent_days, @OT_hours)", connections);
                insertCommand.Parameters.AddWithValue("@Emp_ID", Emp_ID);
                insertCommand.Parameters.AddWithValue("@Name", employeeName);
                insertCommand.Parameters.AddWithValue("@Month", month);
                insertCommand.Parameters.AddWithValue("@Base_pay", basePayS);
                insertCommand.Parameters.AddWithValue("@No_pay", NopayS);
                insertCommand.Parameters.AddWithValue("@Gross_pay", grossPayS);
                insertCommand.Parameters.AddWithValue("@Absent_days", absentdays);
                insertCommand.Parameters.AddWithValue("@OT_hours", overtimehours);
                insertCommand.ExecuteNonQuery();
            }


            BindGridSalary();


        }


        public void BindGridSalary()
        {
          
            using (SqlConnection connS = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT*FROM Salary", connS))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sdas = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dts = new DataTable())
                        {
                            sdas.Fill(dts);
                            dgvdatasal.DataSource = dts;
                        }
                    }
                }
            }
        }



        private void btnSalSearch_Click(object sender, EventArgs e)
        {
            try
            {
                

                string query = "SELECT * FROM Salary WHERE Emp_ID = @EmployeeID AND Month = @Month";

                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    adapter.SelectCommand.Parameters.AddWithValue("@EmployeeID", int.Parse(txtSalSearch.Text));
                    adapter.SelectCommand.Parameters.AddWithValue("@Month", comboBoxMonthSearch.SelectedItem.ToString());

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvdatasal.DataSource = dt;
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message);
            }
        }
    }
}
