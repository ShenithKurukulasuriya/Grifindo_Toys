using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Toys
{
    public partial class Settings : Layout
    {

        private readonly string conString = "Data Source=DESKTOP-LJ5HQHT\\SQLEXPRESS01;Initial Catalog=Payroll;Integrated Security=True;";

        public Settings()
        {
            InitializeComponent();
            this.BindGrid();
        }

        private void btnUpdateS_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                decimal taxrate = decimal.Parse(txtTaxRateS.Text) / 100;

                // Use parameterized query to avoid SQL injection and handle date formatting
                string query = "update Settings set Data_range = @DataRange, Sal_begin = @SalBegin, Sal_end = @SalEnd, No_leaves_ap = @NoLeaves, tax_rate = @TaxRate where ID = @ID";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@DataRange", txtDateRangeS.Text);
                command.Parameters.AddWithValue("@SalBegin", dateTimePicker1.Value);
                command.Parameters.AddWithValue("@SalEnd", dateTimePicker2.Value);
                command.Parameters.AddWithValue("@NoLeaves", txtNoOfLeavesS.Text);
                command.Parameters.AddWithValue("@TaxRate", taxrate);
                command.Parameters.AddWithValue("@ID", txtIDS.Text);

                command.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Successfully updated");

                BindGrid();
            }
        }

        public void BindGrid()
        {

            using (SqlConnection conn = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT*FROM Settings", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView12.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void cleardata()
        {
            txtIDS.Text = "";
            txtDateRangeS.Text = "";
            txtNoOfLeavesS.Text = "";
            txtTaxRateS.Text = "";

        }



        private void btnCancelS_Click(object sender, EventArgs e)
        {
            cleardata();
        }


        private void dataGridView12_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView12.SelectedRows.Count >= 0)
                {
                    txtIDS.Text = dataGridView12.SelectedRows[0].Cells[0].Value.ToString();
                    txtDateRangeS.Text = dataGridView12.SelectedRows[0].Cells[1].Value.ToString();
                    dateTimePicker1.Text = dataGridView12.SelectedRows[0].Cells[2].Value.ToString();
                    dateTimePicker2.Text = dataGridView12.SelectedRows[0].Cells[3].Value.ToString();
                    txtNoOfLeavesS.Text = dataGridView12.SelectedRows[0].Cells[4].Value.ToString();
                    txtTaxRateS.Text = dataGridView12.SelectedRows[0].Cells[5].Value.ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid selection please double click on a row ");
            }
        }


    }
}
