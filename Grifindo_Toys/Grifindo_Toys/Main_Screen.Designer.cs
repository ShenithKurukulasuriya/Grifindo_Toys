namespace Grifindo_Toys
{
    partial class Main_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Screen));
            btnEmployeeControl = new Button();
            btnSalary = new Button();
            btnSettings = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnAddEmployee = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnEmployeeControl
            // 
            btnEmployeeControl.BackColor = Color.FromArgb(192, 255, 192);
            btnEmployeeControl.Font = new Font("Century Gothic", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployeeControl.Location = new Point(257, 558);
            btnEmployeeControl.Margin = new Padding(3, 2, 3, 2);
            btnEmployeeControl.Name = "btnEmployeeControl";
            btnEmployeeControl.Size = new Size(210, 104);
            btnEmployeeControl.TabIndex = 0;
            btnEmployeeControl.Text = "Employee Control";
            btnEmployeeControl.UseVisualStyleBackColor = false;
            btnEmployeeControl.Click += btnEmployeeControl_Click;
            // 
            // btnSalary
            // 
            btnSalary.BackColor = Color.FromArgb(192, 255, 192);
            btnSalary.Font = new Font("Century Gothic", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalary.Location = new Point(729, 558);
            btnSalary.Margin = new Padding(3, 2, 3, 2);
            btnSalary.Name = "btnSalary";
            btnSalary.Size = new Size(206, 110);
            btnSalary.TabIndex = 1;
            btnSalary.Text = "View Monthly Salary";
            btnSalary.UseVisualStyleBackColor = false;
            btnSalary.Click += btnSalary_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(192, 255, 192);
            btnSettings.Font = new Font("Century Gothic", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.Location = new Point(493, 558);
            btnSettings.Margin = new Padding(3, 2, 3, 2);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(208, 104);
            btnSettings.TabIndex = 2;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.pngegg;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(272, 113);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.MinimumSize = new Size(88, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(315, 402);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(632, 311);
            label1.Name = "label1";
            label1.Size = new Size(430, 39);
            label1.TabIndex = 4;
            label1.Text = "Welcome to Gryfindor Toys";
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.FromArgb(192, 255, 192);
            btnAddEmployee.Font = new Font("Century Gothic", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddEmployee.Location = new Point(964, 558);
            btnAddEmployee.Margin = new Padding(3, 2, 3, 2);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(210, 104);
            btnAddEmployee.TabIndex = 5;
            btnAddEmployee.Text = "Add employee";
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // Main_Screen
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.release_1_hogwarts;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1200, 700);
            Controls.Add(btnAddEmployee);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnSettings);
            Controls.Add(btnSalary);
            Controls.Add(btnEmployeeControl);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Main_Screen";
            Text = "Main_Screen";
            //Load += Main_Screen_Load;
            Controls.SetChildIndex(btnEmployeeControl, 0);
            Controls.SetChildIndex(btnSalary, 0);
            Controls.SetChildIndex(btnSettings, 0);
            Controls.SetChildIndex(pictureBox1, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(btnAddEmployee, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEmployeeControl;
        private Button btnSalary;
        private Button btnSettings;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnAddEmployee;
    }
}