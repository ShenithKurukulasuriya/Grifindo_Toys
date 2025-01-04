namespace Grifindo_Toys
{
    partial class Salary
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
            label1 = new Label();
            label2 = new Label();
            txtAbDays = new TextBox();
            txtOTH = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtBasePay = new TextBox();
            txtGrossPay = new TextBox();
            label5 = new Label();
            txtNoPay = new TextBox();
            label6 = new Label();
            label7 = new Label();
            btnCalBasePay = new Button();
            btnCalGrossPay = new Button();
            btnCalNoPay = new Button();
            comboBox1 = new ComboBox();
            txtEmpIDE = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtSalSearch = new TextBox();
            comboBoxMonthSearch = new ComboBox();
            btnSalSearch = new Button();
            dgvdatasal = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvdatasal).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(671, 93);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(239, 34);
            label1.TabIndex = 0;
            label1.Text = "Calculate Salary";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(409, 164);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(138, 23);
            label2.TabIndex = 1;
            label2.Text = "Absent Days:";
            // 
            // txtAbDays
            // 
            txtAbDays.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtAbDays.Location = new Point(582, 168);
            txtAbDays.Margin = new Padding(4, 2, 4, 2);
            txtAbDays.Name = "txtAbDays";
            txtAbDays.Size = new Size(140, 32);
            txtAbDays.TabIndex = 2;
            // 
            // txtOTH
            // 
            txtOTH.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtOTH.Location = new Point(939, 171);
            txtOTH.Margin = new Padding(4, 2, 4, 2);
            txtOTH.Name = "txtOTH";
            txtOTH.Size = new Size(140, 32);
            txtOTH.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(752, 167);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(158, 23);
            label3.TabIndex = 3;
            label3.Text = "Overtimr Hours:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(420, 291);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 23);
            label4.TabIndex = 5;
            label4.Text = "Base Pay:";
            // 
            // txtBasePay
            // 
            txtBasePay.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtBasePay.Location = new Point(585, 293);
            txtBasePay.Margin = new Padding(4, 2, 4, 2);
            txtBasePay.Name = "txtBasePay";
            txtBasePay.Size = new Size(179, 32);
            txtBasePay.TabIndex = 6;
            // 
            // txtGrossPay
            // 
            txtGrossPay.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtGrossPay.Location = new Point(585, 413);
            txtGrossPay.Margin = new Padding(4, 2, 4, 2);
            txtGrossPay.Name = "txtGrossPay";
            txtGrossPay.Size = new Size(179, 32);
            txtGrossPay.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(410, 411);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(110, 23);
            label5.TabIndex = 7;
            label5.Text = "Gross Pay:";
            // 
            // txtNoPay
            // 
            txtNoPay.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtNoPay.Location = new Point(585, 354);
            txtNoPay.Margin = new Padding(4, 2, 4, 2);
            txtNoPay.Name = "txtNoPay";
            txtNoPay.Size = new Size(179, 32);
            txtNoPay.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(410, 351);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(151, 23);
            label6.TabIndex = 9;
            label6.Text = "No Pay Value:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(834, 222);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(76, 23);
            label7.TabIndex = 11;
            label7.Text = "Month:";
            // 
            // btnCalBasePay
            // 
            btnCalBasePay.BackColor = Color.FromArgb(255, 255, 192);
            btnCalBasePay.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalBasePay.Location = new Point(816, 286);
            btnCalBasePay.Margin = new Padding(4, 2, 4, 2);
            btnCalBasePay.Name = "btnCalBasePay";
            btnCalBasePay.Size = new Size(244, 42);
            btnCalBasePay.TabIndex = 13;
            btnCalBasePay.Text = "Calculate Base Pay";
            btnCalBasePay.UseVisualStyleBackColor = false;
            btnCalBasePay.Click += btnCalBasePay_Click;
            // 
            // btnCalGrossPay
            // 
            btnCalGrossPay.BackColor = Color.FromArgb(255, 255, 192);
            btnCalGrossPay.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalGrossPay.Location = new Point(816, 402);
            btnCalGrossPay.Margin = new Padding(4, 2, 4, 2);
            btnCalGrossPay.Name = "btnCalGrossPay";
            btnCalGrossPay.Size = new Size(244, 42);
            btnCalGrossPay.TabIndex = 14;
            btnCalGrossPay.Text = "Calculate Gross Pay";
            btnCalGrossPay.UseVisualStyleBackColor = false;
            btnCalGrossPay.Click += btnCalGrossPay_Click;
            // 
            // btnCalNoPay
            // 
            btnCalNoPay.BackColor = Color.FromArgb(255, 255, 192);
            btnCalNoPay.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalNoPay.Location = new Point(816, 344);
            btnCalNoPay.Margin = new Padding(4, 2, 4, 2);
            btnCalNoPay.Name = "btnCalNoPay";
            btnCalNoPay.Size = new Size(265, 42);
            btnCalNoPay.TabIndex = 15;
            btnCalNoPay.Text = "Calculate No pay Value";
            btnCalNoPay.UseVisualStyleBackColor = false;
            btnCalNoPay.Click += btnCalNoPay_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            comboBox1.Location = new Point(939, 220);
            comboBox1.Margin = new Padding(4, 2, 4, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 31);
            comboBox1.TabIndex = 16;
            // 
            // txtEmpIDE
            // 
            txtEmpIDE.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtEmpIDE.Location = new Point(582, 220);
            txtEmpIDE.Margin = new Padding(4, 2, 4, 2);
            txtEmpIDE.Name = "txtEmpIDE";
            txtEmpIDE.Size = new Size(140, 32);
            txtEmpIDE.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(409, 216);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(140, 23);
            label8.TabIndex = 17;
            label8.Text = "Employee ID:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(734, 542);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(173, 34);
            label9.TabIndex = 19;
            label9.Text = "View Salary";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(378, 598);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(135, 23);
            label10.TabIndex = 20;
            label10.Text = "Employee ID";
            // 
            // txtSalSearch
            // 
            txtSalSearch.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtSalSearch.Location = new Point(554, 604);
            txtSalSearch.Margin = new Padding(4, 2, 4, 2);
            txtSalSearch.Name = "txtSalSearch";
            txtSalSearch.Size = new Size(293, 32);
            txtSalSearch.TabIndex = 21;
            // 
            // comboBoxMonthSearch
            // 
            comboBoxMonthSearch.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            comboBoxMonthSearch.FormattingEnabled = true;
            comboBoxMonthSearch.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            comboBoxMonthSearch.Location = new Point(888, 604);
            comboBoxMonthSearch.Margin = new Padding(4, 2, 4, 2);
            comboBoxMonthSearch.Name = "comboBoxMonthSearch";
            comboBoxMonthSearch.Size = new Size(140, 31);
            comboBoxMonthSearch.TabIndex = 22;
            // 
            // btnSalSearch
            // 
            btnSalSearch.BackColor = Color.FromArgb(255, 255, 192);
            btnSalSearch.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalSearch.Location = new Point(1092, 598);
            btnSalSearch.Margin = new Padding(4, 2, 4, 2);
            btnSalSearch.Name = "btnSalSearch";
            btnSalSearch.Size = new Size(144, 42);
            btnSalSearch.TabIndex = 23;
            btnSalSearch.Text = "Search";
            btnSalSearch.UseVisualStyleBackColor = false;
            btnSalSearch.Click += btnSalSearch_Click;
            // 
            // dgvdatasal
            // 
            dgvdatasal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdatasal.Location = new Point(347, 656);
            dgvdatasal.Margin = new Padding(4, 4, 4, 4);
            dgvdatasal.Name = "dgvdatasal";
            dgvdatasal.RowHeadersWidth = 51;
            dgvdatasal.Size = new Size(888, 127);
            dgvdatasal.TabIndex = 24;
            // 
            // Salary
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1543, 824);
            Controls.Add(dgvdatasal);
            Controls.Add(btnSalSearch);
            Controls.Add(comboBoxMonthSearch);
            Controls.Add(txtSalSearch);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtEmpIDE);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(btnCalNoPay);
            Controls.Add(btnCalGrossPay);
            Controls.Add(btnCalBasePay);
            Controls.Add(label7);
            Controls.Add(txtNoPay);
            Controls.Add(label6);
            Controls.Add(txtGrossPay);
            Controls.Add(label5);
            Controls.Add(txtBasePay);
            Controls.Add(label4);
            Controls.Add(txtOTH);
            Controls.Add(label3);
            Controls.Add(txtAbDays);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Sizable;
            Margin = new Padding(4, 2, 4, 2);
            Name = "Salary";
            Text = "Salary";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtAbDays, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtOTH, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(txtBasePay, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(txtGrossPay, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(txtNoPay, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(btnCalBasePay, 0);
            Controls.SetChildIndex(btnCalGrossPay, 0);
            Controls.SetChildIndex(btnCalNoPay, 0);
            Controls.SetChildIndex(comboBox1, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(txtEmpIDE, 0);
            Controls.SetChildIndex(label9, 0);
            Controls.SetChildIndex(label10, 0);
            Controls.SetChildIndex(txtSalSearch, 0);
            Controls.SetChildIndex(comboBoxMonthSearch, 0);
            Controls.SetChildIndex(btnSalSearch, 0);
            Controls.SetChildIndex(dgvdatasal, 0);
            ((System.ComponentModel.ISupportInitialize)dgvdatasal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAbDays;
        private TextBox txtOTH;
        private Label label3;
        private Label label4;
        private TextBox txtBasePay;
        private TextBox txtGrossPay;
        private Label label5;
        private TextBox txtNoPay;
        private Label label6;
        private Label label7;
        private Button btnCalBasePay;
        private Button btnCalGrossPay;
        private Button btnCalNoPay;
        private ComboBox comboBox1;
        private TextBox txtEmpIDE;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtSalSearch;
        private ComboBox comboBoxMonthSearch;
        private Button btnSalSearch;
        private DataGridView dgvdatasal;
    }
}