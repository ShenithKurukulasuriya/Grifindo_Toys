namespace Grifindo_Toys
{
    partial class CRUD_employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD_employee));
            btnAdd = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            txtEmployeeIDU = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPhoneNumberU = new TextBox();
            label4 = new Label();
            txtEmailU = new TextBox();
            label5 = new Label();
            txtStreetU = new TextBox();
            label6 = new Label();
            txtCityU = new TextBox();
            label7 = new Label();
            txtDistrictU = new TextBox();
            label15 = new Label();
            txtCountryU = new TextBox();
            label8 = new Label();
            txtPostalCodeU = new TextBox();
            label16 = new Label();
            txtAllowancesU = new TextBox();
            label9 = new Label();
            label10 = new Label();
            txtOverTimeRateU = new TextBox();
            label11 = new Label();
            label12 = new Label();
            btnCancelU = new Button();
            button2 = new Button();
            txtNameU = new TextBox();
            btnRefresh = new Button();
            txtMonthlySalaryU = new TextBox();
            label13 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 192, 255);
            btnAdd.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnAdd.Location = new Point(931, 107);
            btnAdd.Margin = new Padding(6, 3, 6, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 34);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(255, 192, 255);
            btnSearch.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnSearch.Location = new Point(793, 107);
            btnSearch.Margin = new Padding(6, 3, 6, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(128, 34);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(452, 106);
            txtSearch.Margin = new Padding(6, 3, 6, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(311, 32);
            txtSearch.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(436, 151);
            dataGridView1.Margin = new Padding(6, 3, 6, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(890, 265);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 255);
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(668, 82);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(70, 27);
            button1.TabIndex = 4;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(431, 337);
            label1.Name = "label1";
            label1.Size = new Size(231, 30);
            label1.TabIndex = 37;
            label1.Text = "Update An Employee";
            // 
            // txtEmployeeIDU
            // 
            txtEmployeeIDU.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtEmployeeIDU.Location = new Point(632, 528);
            txtEmployeeIDU.Margin = new Padding(6, 3, 6, 3);
            txtEmployeeIDU.Multiline = true;
            txtEmployeeIDU.Name = "txtEmployeeIDU";
            txtEmployeeIDU.Size = new Size(213, 36);
            txtEmployeeIDU.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(282, 410);
            label2.Name = "label2";
            label2.Size = new Size(110, 21);
            label2.TabIndex = 39;
            label2.Text = "Employee ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label3.Location = new Point(495, 579);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 23);
            label3.TabIndex = 41;
            label3.Text = "Name:";
            // 
            // txtPhoneNumberU
            // 
            txtPhoneNumberU.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtPhoneNumberU.Location = new Point(632, 638);
            txtPhoneNumberU.Margin = new Padding(6, 3, 6, 3);
            txtPhoneNumberU.Multiline = true;
            txtPhoneNumberU.Name = "txtPhoneNumberU";
            txtPhoneNumberU.Size = new Size(213, 36);
            txtPhoneNumberU.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label4.Location = new Point(392, 638);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(161, 23);
            label4.TabIndex = 43;
            label4.Text = "Phone Number:";
            // 
            // txtEmailU
            // 
            txtEmailU.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtEmailU.Location = new Point(632, 692);
            txtEmailU.Margin = new Padding(6, 3, 6, 3);
            txtEmailU.Multiline = true;
            txtEmailU.Name = "txtEmailU";
            txtEmailU.Size = new Size(213, 36);
            txtEmailU.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label5.Location = new Point(507, 703);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(68, 23);
            label5.TabIndex = 45;
            label5.Text = "Email:";
            // 
            // txtStreetU
            // 
            txtStreetU.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtStreetU.Location = new Point(632, 771);
            txtStreetU.Margin = new Padding(6, 3, 6, 3);
            txtStreetU.Multiline = true;
            txtStreetU.Name = "txtStreetU";
            txtStreetU.Size = new Size(213, 36);
            txtStreetU.TabIndex = 48;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label6.Location = new Point(490, 770);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(76, 23);
            label6.TabIndex = 47;
            label6.Text = "Street :";
            // 
            // txtCityU
            // 
            txtCityU.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtCityU.Location = new Point(1082, 549);
            txtCityU.Margin = new Padding(6, 3, 6, 3);
            txtCityU.Multiline = true;
            txtCityU.Name = "txtCityU";
            txtCityU.Size = new Size(143, 36);
            txtCityU.TabIndex = 50;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label7.Location = new Point(968, 554);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(61, 23);
            label7.TabIndex = 49;
            label7.Text = "City :";
            // 
            // txtDistrictU
            // 
            txtDistrictU.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtDistrictU.Location = new Point(1082, 690);
            txtDistrictU.Margin = new Padding(6, 3, 6, 3);
            txtDistrictU.Multiline = true;
            txtDistrictU.Name = "txtDistrictU";
            txtDistrictU.Size = new Size(143, 36);
            txtDistrictU.TabIndex = 62;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label15.Location = new Point(924, 690);
            label15.Margin = new Padding(6, 0, 6, 0);
            label15.Name = "label15";
            label15.Size = new Size(86, 23);
            label15.TabIndex = 61;
            label15.Text = "District :";
            // 
            // txtCountryU
            // 
            txtCountryU.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtCountryU.Location = new Point(1082, 608);
            txtCountryU.Margin = new Padding(6, 3, 6, 3);
            txtCountryU.Multiline = true;
            txtCountryU.Name = "txtCountryU";
            txtCountryU.Size = new Size(143, 36);
            txtCountryU.TabIndex = 64;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label8.Location = new Point(918, 619);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(99, 23);
            label8.TabIndex = 63;
            label8.Text = "Country :";
            // 
            // txtPostalCodeU
            // 
            txtPostalCodeU.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtPostalCodeU.Location = new Point(1464, 620);
            txtPostalCodeU.Margin = new Padding(6, 3, 6, 3);
            txtPostalCodeU.Multiline = true;
            txtPostalCodeU.Name = "txtPostalCodeU";
            txtPostalCodeU.Size = new Size(159, 36);
            txtPostalCodeU.TabIndex = 66;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label16.Location = new Point(1297, 619);
            label16.Margin = new Padding(6, 0, 6, 0);
            label16.Name = "label16";
            label16.Size = new Size(140, 23);
            label16.TabIndex = 65;
            label16.Text = "Postal Code :";
            // 
            // txtAllowancesU
            // 
            txtAllowancesU.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtAllowancesU.Location = new Point(1082, 760);
            txtAllowancesU.Margin = new Padding(6, 3, 6, 3);
            txtAllowancesU.Multiline = true;
            txtAllowancesU.Name = "txtAllowancesU";
            txtAllowancesU.Size = new Size(143, 36);
            txtAllowancesU.TabIndex = 68;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label9.Location = new Point(1380, 554);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(65, 23);
            label9.TabIndex = 67;
            label9.Text = "DOB :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label10.Location = new Point(1260, 762);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(165, 23);
            label10.TabIndex = 69;
            label10.Text = "Monthly Salary :";
            // 
            // txtOverTimeRateU
            // 
            txtOverTimeRateU.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtOverTimeRateU.Location = new Point(1464, 690);
            txtOverTimeRateU.Margin = new Padding(6, 3, 6, 3);
            txtOverTimeRateU.Multiline = true;
            txtOverTimeRateU.Name = "txtOverTimeRateU";
            txtOverTimeRateU.Size = new Size(143, 36);
            txtOverTimeRateU.TabIndex = 72;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label11.Location = new Point(1255, 690);
            label11.Margin = new Padding(6, 0, 6, 0);
            label11.Name = "label11";
            label11.Size = new Size(170, 23);
            label11.TabIndex = 71;
            label11.Text = "Over Time Rate :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label12.Location = new Point(881, 762);
            label12.Margin = new Padding(6, 0, 6, 0);
            label12.Name = "label12";
            label12.Size = new Size(136, 23);
            label12.TabIndex = 73;
            label12.Text = "Allowences :";
            // 
            // btnCancelU
            // 
            btnCancelU.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            btnCancelU.Location = new Point(1137, 826);
            btnCancelU.Margin = new Padding(6, 3, 6, 3);
            btnCancelU.Name = "btnCancelU";
            btnCancelU.Size = new Size(144, 56);
            btnCancelU.TabIndex = 76;
            btnCancelU.Text = "Cancel";
            btnCancelU.UseVisualStyleBackColor = true;
            btnCancelU.Click += btnCancelU_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(519, 638);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(92, 43);
            button2.TabIndex = 75;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtNameU
            // 
            txtNameU.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtNameU.Location = new Point(632, 580);
            txtNameU.Margin = new Padding(6, 3, 6, 3);
            txtNameU.Multiline = true;
            txtNameU.Name = "txtNameU";
            txtNameU.Size = new Size(213, 36);
            txtNameU.TabIndex = 77;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(192, 255, 192);
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(1297, 113);
            btnRefresh.Margin = new Padding(6, 4, 6, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(29, 30);
            btnRefresh.TabIndex = 78;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtMonthlySalaryU
            // 
            txtMonthlySalaryU.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtMonthlySalaryU.Location = new Point(1464, 760);
            txtMonthlySalaryU.Margin = new Padding(6, 3, 6, 3);
            txtMonthlySalaryU.Multiline = true;
            txtMonthlySalaryU.Name = "txtMonthlySalaryU";
            txtMonthlySalaryU.Size = new Size(159, 36);
            txtMonthlySalaryU.TabIndex = 70;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label13.Location = new Point(500, 527);
            label13.Margin = new Padding(6, 0, 6, 0);
            label13.Name = "label13";
            label13.Size = new Size(78, 23);
            label13.TabIndex = 79;
            label13.Text = "Emp ID";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 192, 255);
            btnDelete.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnDelete.Location = new Point(1050, 107);
            btnDelete.Margin = new Padding(6, 3, 6, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 36);
            btnDelete.TabIndex = 80;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            btnUpdate.Location = new Point(890, 826);
            btnUpdate.Margin = new Padding(6, 3, 6, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(144, 56);
            btnUpdate.TabIndex = 81;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            dateTimePicker1.Location = new Point(1468, 553);
            dateTimePicker1.Margin = new Padding(4, 4, 4, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(346, 32);
            dateTimePicker1.TabIndex = 82;
            // 
            // CRUD_employee
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1860, 930);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(label13);
            Controls.Add(btnRefresh);
            Controls.Add(txtNameU);
            Controls.Add(btnCancelU);
            Controls.Add(label12);
            Controls.Add(txtOverTimeRateU);
            Controls.Add(label11);
            Controls.Add(txtMonthlySalaryU);
            Controls.Add(label10);
            Controls.Add(txtAllowancesU);
            Controls.Add(label9);
            Controls.Add(txtPostalCodeU);
            Controls.Add(label16);
            Controls.Add(txtCountryU);
            Controls.Add(label8);
            Controls.Add(txtDistrictU);
            Controls.Add(label15);
            Controls.Add(txtCityU);
            Controls.Add(label7);
            Controls.Add(txtStreetU);
            Controls.Add(label6);
            Controls.Add(txtEmailU);
            Controls.Add(label5);
            Controls.Add(txtPhoneNumberU);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtEmployeeIDU);
            Controls.Add(dataGridView1);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.Sizable;
            Margin = new Padding(6, 3, 6, 3);
            Name = "CRUD_employee";
            Text = "CRUD_employee";
            Controls.SetChildIndex(btnAdd, 0);
            Controls.SetChildIndex(btnSearch, 0);
            Controls.SetChildIndex(txtSearch, 0);
            Controls.SetChildIndex(dataGridView1, 0);
            Controls.SetChildIndex(txtEmployeeIDU, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(txtPhoneNumberU, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(txtEmailU, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(txtStreetU, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(txtCityU, 0);
            Controls.SetChildIndex(label15, 0);
            Controls.SetChildIndex(txtDistrictU, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(txtCountryU, 0);
            Controls.SetChildIndex(label16, 0);
            Controls.SetChildIndex(txtPostalCodeU, 0);
            Controls.SetChildIndex(label9, 0);
            Controls.SetChildIndex(txtAllowancesU, 0);
            Controls.SetChildIndex(label10, 0);
            Controls.SetChildIndex(txtMonthlySalaryU, 0);
            Controls.SetChildIndex(label11, 0);
            Controls.SetChildIndex(txtOverTimeRateU, 0);
            Controls.SetChildIndex(label12, 0);
            Controls.SetChildIndex(btnCancelU, 0);
            Controls.SetChildIndex(txtNameU, 0);
            Controls.SetChildIndex(btnRefresh, 0);
            Controls.SetChildIndex(label13, 0);
            Controls.SetChildIndex(btnDelete, 0);
            Controls.SetChildIndex(btnUpdate, 0);
            Controls.SetChildIndex(dateTimePicker1, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private TextBox txtEmployeeIDU;
        private Label label2;
        private Label label3;
        private TextBox txtPhoneNumberU;
        private Label label4;
        private TextBox txtEmailU;
        private Label label5;
        private TextBox txtStreetU;
        private Label label6;
        private TextBox txtCityU;
        private Label label7;
        private TextBox txtDistrictU;
        private Label label15;
        private TextBox txtCountryU;
        private Label label8;
        private TextBox txtPostalCodeU;
        private Label label16;
        private TextBox txtAllowancesU;
        private Label label9;
        private Label label10;
        private TextBox txtOverTimeRateU;
        private Label label11;
        private Label label12;
        private Button btnCancelU;
        private Button button2;
        private TextBox txtNameU;
        private Button btnRefresh;
        private TextBox txtMonthlySalaryU;
        private Label label13;
        private Button btnDelete;
        private Button btnUpdate;
        private DateTimePicker dateTimePicker1;
    }
}