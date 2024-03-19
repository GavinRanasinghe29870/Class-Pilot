namespace Class_Pilot
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            btnDashboard = new Button();
            btnAttendence = new Button();
            btnCreateClass = new Button();
            btnStudentRegister = new Button();
            btnPayment = new Button();
            btnReports = new Button();
            btnTeacherEdit = new Button();
            btnClassEdit = new Button();
            btnTute = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            StudentEditMenu = new FlowLayoutPanel();
            btnStudentEdit = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            StuEditMenuTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            StudentEditMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(63, 68, 93);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 91);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 6);
            label1.Name = "label1";
            label1.Size = new Size(270, 65);
            label1.TabIndex = 0;
            label1.Text = "Attendence";
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = Properties.Resources.dashboard__1_;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(3, 100);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(75, 0, 10, 0);
            btnDashboard.Size = new Size(304, 59);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnAttendence
            // 
            btnAttendence.FlatAppearance.BorderSize = 0;
            btnAttendence.FlatStyle = FlatStyle.Flat;
            btnAttendence.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAttendence.ForeColor = Color.White;
            btnAttendence.Image = Properties.Resources.check;
            btnAttendence.ImageAlign = ContentAlignment.MiddleLeft;
            btnAttendence.Location = new Point(3, 165);
            btnAttendence.Name = "btnAttendence";
            btnAttendence.Padding = new Padding(75, 0, 10, 0);
            btnAttendence.Size = new Size(304, 59);
            btnAttendence.TabIndex = 2;
            btnAttendence.Text = "Attendence";
            btnAttendence.UseVisualStyleBackColor = false;
            // 
            // btnCreateClass
            // 
            btnCreateClass.FlatAppearance.BorderSize = 0;
            btnCreateClass.FlatStyle = FlatStyle.Flat;
            btnCreateClass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateClass.ForeColor = Color.White;
            btnCreateClass.Image = Properties.Resources.training;
            btnCreateClass.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateClass.Location = new Point(3, 230);
            btnCreateClass.Name = "btnCreateClass";
            btnCreateClass.Padding = new Padding(75, 0, 10, 0);
            btnCreateClass.Size = new Size(304, 59);
            btnCreateClass.TabIndex = 3;
            btnCreateClass.Text = "Create Class";
            btnCreateClass.UseVisualStyleBackColor = false;
            // 
            // btnStudentRegister
            // 
            btnStudentRegister.FlatAppearance.BorderSize = 0;
            btnStudentRegister.FlatStyle = FlatStyle.Flat;
            btnStudentRegister.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStudentRegister.ForeColor = Color.White;
            btnStudentRegister.Image = Properties.Resources.registered;
            btnStudentRegister.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudentRegister.Location = new Point(3, 295);
            btnStudentRegister.Name = "btnStudentRegister";
            btnStudentRegister.Padding = new Padding(75, 0, 10, 0);
            btnStudentRegister.Size = new Size(304, 59);
            btnStudentRegister.TabIndex = 4;
            btnStudentRegister.Text = "Student Register";
            btnStudentRegister.TextAlign = ContentAlignment.MiddleRight;
            btnStudentRegister.UseVisualStyleBackColor = false;
            // 
            // btnPayment
            // 
            btnPayment.FlatAppearance.BorderSize = 0;
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPayment.ForeColor = Color.White;
            btnPayment.Image = Properties.Resources.payment_method;
            btnPayment.ImageAlign = ContentAlignment.MiddleLeft;
            btnPayment.Location = new Point(3, 360);
            btnPayment.Name = "btnPayment";
            btnPayment.Padding = new Padding(75, 0, 10, 0);
            btnPayment.Size = new Size(304, 59);
            btnPayment.TabIndex = 5;
            btnPayment.Text = "Payments";
            btnPayment.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.White;
            btnReports.Image = Properties.Resources.report;
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(3, 425);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(75, 0, 10, 0);
            btnReports.Size = new Size(304, 59);
            btnReports.TabIndex = 6;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnTeacherEdit
            // 
            btnTeacherEdit.FlatAppearance.BorderSize = 0;
            btnTeacherEdit.FlatStyle = FlatStyle.Flat;
            btnTeacherEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTeacherEdit.ForeColor = Color.White;
            btnTeacherEdit.Image = Properties.Resources.teacher;
            btnTeacherEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnTeacherEdit.Location = new Point(3, 490);
            btnTeacherEdit.Name = "btnTeacherEdit";
            btnTeacherEdit.Padding = new Padding(75, 0, 10, 0);
            btnTeacherEdit.Size = new Size(304, 59);
            btnTeacherEdit.TabIndex = 7;
            btnTeacherEdit.Text = "Teacher Edit";
            btnTeacherEdit.UseVisualStyleBackColor = false;
            // 
            // btnClassEdit
            // 
            btnClassEdit.FlatAppearance.BorderSize = 0;
            btnClassEdit.FlatStyle = FlatStyle.Flat;
            btnClassEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClassEdit.ForeColor = Color.White;
            btnClassEdit.Image = Properties.Resources.class_notes;
            btnClassEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnClassEdit.Location = new Point(3, 626);
            btnClassEdit.Name = "btnClassEdit";
            btnClassEdit.Padding = new Padding(75, 0, 10, 0);
            btnClassEdit.Size = new Size(304, 59);
            btnClassEdit.TabIndex = 9;
            btnClassEdit.Text = "Class Edit";
            btnClassEdit.UseVisualStyleBackColor = false;
            // 
            // btnTute
            // 
            btnTute.FlatAppearance.BorderSize = 0;
            btnTute.FlatStyle = FlatStyle.Flat;
            btnTute.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTute.ForeColor = Color.White;
            btnTute.Image = Properties.Resources.paper_stack;
            btnTute.ImageAlign = ContentAlignment.MiddleLeft;
            btnTute.Location = new Point(3, 691);
            btnTute.Name = "btnTute";
            btnTute.Padding = new Padding(75, 0, 10, 0);
            btnTute.Size = new Size(304, 59);
            btnTute.TabIndex = 10;
            btnTute.Text = "Tute/Exam";
            btnTute.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(77, 83, 113);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(btnDashboard);
            flowLayoutPanel1.Controls.Add(btnAttendence);
            flowLayoutPanel1.Controls.Add(btnCreateClass);
            flowLayoutPanel1.Controls.Add(btnStudentRegister);
            flowLayoutPanel1.Controls.Add(btnPayment);
            flowLayoutPanel1.Controls.Add(btnReports);
            flowLayoutPanel1.Controls.Add(btnTeacherEdit);
            flowLayoutPanel1.Controls.Add(StudentEditMenu);
            flowLayoutPanel1.Controls.Add(btnClassEdit);
            flowLayoutPanel1.Controls.Add(btnTute);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(307, 909);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // StudentEditMenu
            // 
            StudentEditMenu.Controls.Add(btnStudentEdit);
            StudentEditMenu.Controls.Add(button11);
            StudentEditMenu.Controls.Add(button12);
            StudentEditMenu.Controls.Add(button13);
            StudentEditMenu.Location = new Point(3, 555);
            StudentEditMenu.MaximumSize = new Size(304, 249);
            StudentEditMenu.MinimumSize = new Size(304, 65);
            StudentEditMenu.Name = "StudentEditMenu";
            StudentEditMenu.Size = new Size(304, 65);
            StudentEditMenu.TabIndex = 1;
            // 
            // btnStudentEdit
            // 
            btnStudentEdit.FlatAppearance.BorderSize = 0;
            btnStudentEdit.FlatStyle = FlatStyle.Flat;
            btnStudentEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStudentEdit.ForeColor = Color.White;
            btnStudentEdit.Image = Properties.Resources.reading;
            btnStudentEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudentEdit.Location = new Point(3, 3);
            btnStudentEdit.Name = "btnStudentEdit";
            btnStudentEdit.Padding = new Padding(75, 0, 10, 0);
            btnStudentEdit.Size = new Size(304, 59);
            btnStudentEdit.TabIndex = 8;
            btnStudentEdit.Text = "Student Edit";
            btnStudentEdit.UseVisualStyleBackColor = false;
            btnStudentEdit.Click += btnStudentEdit_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(37, 40, 54);
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button11.ForeColor = Color.White;
            button11.Image = Properties.Resources.dot;
            button11.Location = new Point(3, 66);
            button11.Margin = new Padding(3, 1, 3, 1);
            button11.Name = "button11";
            button11.Padding = new Padding(0, 0, 47, 0);
            button11.Size = new Size(304, 59);
            button11.TabIndex = 9;
            button11.Text = "Assign To Class";
            button11.TextAlign = ContentAlignment.MiddleRight;
            button11.TextImageRelation = TextImageRelation.ImageBeforeText;
            button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(37, 40, 54);
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.ForeColor = Color.White;
            button12.Image = Properties.Resources.dot;
            button12.Location = new Point(3, 127);
            button12.Margin = new Padding(3, 1, 3, 1);
            button12.Name = "button12";
            button12.Size = new Size(301, 59);
            button12.TabIndex = 10;
            button12.Text = "Remove From Class";
            button12.TextAlign = ContentAlignment.MiddleRight;
            button12.TextImageRelation = TextImageRelation.ImageBeforeText;
            button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(37, 40, 54);
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button13.ForeColor = Color.White;
            button13.Image = Properties.Resources.dot;
            button13.Location = new Point(3, 188);
            button13.Margin = new Padding(3, 1, 3, 1);
            button13.Name = "button13";
            button13.Size = new Size(304, 59);
            button13.TabIndex = 11;
            button13.Text = "Student Details Edit";
            button13.TextAlign = ContentAlignment.MiddleRight;
            button13.TextImageRelation = TextImageRelation.ImageBeforeText;
            button13.UseVisualStyleBackColor = false;
            // 
            // StuEditMenuTimer
            // 
            StuEditMenuTimer.Interval = 10;
            StuEditMenuTimer.Tick += timer1_Tick_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(63, 68, 93);
            ClientSize = new Size(1418, 909);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            StudentEditMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Button btnDashboard;
        private Button btnAttendence;
        private Button btnCreateClass;
        private Button btnStudentRegister;
        private Button btnPayment;
        private Button btnReports;
        private Button btnTeacherEdit;
        private Button btnClassEdit;
        private Button btnTute;
        private FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer StuEditMenuTimer;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button btnStudentEdit;
        private FlowLayoutPanel StudentEditMenu;
    }
}
