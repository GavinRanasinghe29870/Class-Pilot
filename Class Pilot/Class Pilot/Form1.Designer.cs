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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button9 = new Button();
            button10 = new Button();
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
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.dashboard__1_;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 100);
            button1.Name = "button1";
            button1.Padding = new Padding(75, 0, 10, 0);
            button1.Size = new Size(304, 59);
            button1.TabIndex = 1;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.check;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 165);
            button2.Name = "button2";
            button2.Padding = new Padding(75, 0, 10, 0);
            button2.Size = new Size(304, 59);
            button2.TabIndex = 2;
            button2.Text = "Attendence";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.training;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 230);
            button3.Name = "button3";
            button3.Padding = new Padding(75, 0, 10, 0);
            button3.Size = new Size(304, 59);
            button3.TabIndex = 3;
            button3.Text = "Create Class";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = Properties.Resources.registered;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(3, 295);
            button4.Name = "button4";
            button4.Padding = new Padding(75, 0, 10, 0);
            button4.Size = new Size(304, 59);
            button4.TabIndex = 4;
            button4.Text = "Student Register";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Image = Properties.Resources.payment_method;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(3, 360);
            button5.Name = "button5";
            button5.Padding = new Padding(75, 0, 10, 0);
            button5.Size = new Size(304, 59);
            button5.TabIndex = 5;
            button5.Text = "Payments";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Image = Properties.Resources.report;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(3, 425);
            button6.Name = "button6";
            button6.Padding = new Padding(75, 0, 10, 0);
            button6.Size = new Size(304, 59);
            button6.TabIndex = 6;
            button6.Text = "Reports";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Image = Properties.Resources.teacher;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(3, 490);
            button7.Name = "button7";
            button7.Padding = new Padding(75, 0, 10, 0);
            button7.Size = new Size(304, 59);
            button7.TabIndex = 7;
            button7.Text = "Teacher Edit";
            button7.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.White;
            button9.Image = Properties.Resources.class_notes;
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(3, 626);
            button9.Name = "button9";
            button9.Padding = new Padding(75, 0, 10, 0);
            button9.Size = new Size(304, 59);
            button9.TabIndex = 9;
            button9.Text = "Class Edit";
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.White;
            button10.Image = Properties.Resources.paper_stack;
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.Location = new Point(3, 691);
            button10.Name = "button10";
            button10.Padding = new Padding(75, 0, 10, 0);
            button10.Size = new Size(304, 59);
            button10.TabIndex = 10;
            button10.Text = "Tute/Exam";
            button10.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(77, 83, 113);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Controls.Add(button7);
            flowLayoutPanel1.Controls.Add(StudentEditMenu);
            flowLayoutPanel1.Controls.Add(button9);
            flowLayoutPanel1.Controls.Add(button10);
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
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button9;
        private Button button10;
        private FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer StuEditMenuTimer;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button btnStudentEdit;
        private FlowLayoutPanel StudentEditMenu;
    }
}
