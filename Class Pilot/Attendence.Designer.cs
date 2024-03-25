namespace Class_Pilot
{
    partial class Attendence
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
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            splitContainer1 = new SplitContainer();
            label10 = new Label();
            label11 = new Label();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblStuName = new Label();
            label5 = new Label();
            panel2 = new Panel();
            button8 = new Button();
            textBox2 = new TextBox();
            label4 = new Label();
            btnStuIDSearch = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            StudentEditMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
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
            button2.BackColor = Color.FromArgb(87, 95, 128);
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
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 12F);
            dateTimePicker1.Location = new Point(413, 120);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(408, 39);
            dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(338, 119);
            label2.Name = "label2";
            label2.Size = new Size(69, 32);
            label2.TabIndex = 2;
            label2.Text = "Date:";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(338, 187);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(44, 48, 65);
            splitContainer1.Panel1.Controls.Add(label10);
            splitContainer1.Panel1.Controls.Add(label11);
            splitContainer1.Panel1.Controls.Add(label8);
            splitContainer1.Panel1.Controls.Add(label9);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(lblStuName);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(button8);
            splitContainer1.Panel1.Controls.Add(textBox2);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(btnStuIDSearch);
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Size = new Size(1442, 669);
            splitContainer1.SplitterDistance = 700;
            splitContainer1.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(390, 284);
            label10.Name = "label10";
            label10.Size = new Size(145, 30);
            label10.TabIndex = 14;
            label10.Text = "StudentName";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(302, 284);
            label11.Name = "label11";
            label11.Size = new Size(0, 30);
            label11.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(422, 243);
            label8.Name = "label8";
            label8.Size = new Size(145, 30);
            label8.TabIndex = 12;
            label8.Text = "StudentName";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(302, 243);
            label9.Name = "label9";
            label9.Size = new Size(96, 30);
            label9.TabIndex = 11;
            label9.Text = "Address:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(422, 202);
            label6.Name = "label6";
            label6.Size = new Size(145, 30);
            label6.TabIndex = 10;
            label6.Text = "StudentName";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(302, 202);
            label7.Name = "label7";
            label7.Size = new Size(114, 30);
            label7.TabIndex = 9;
            label7.Text = "Phone No:";
            // 
            // lblStuName
            // 
            lblStuName.AutoSize = true;
            lblStuName.Font = new Font("Segoe UI", 11F);
            lblStuName.ForeColor = Color.White;
            lblStuName.Location = new Point(422, 163);
            lblStuName.Name = "lblStuName";
            lblStuName.Size = new Size(145, 30);
            lblStuName.TabIndex = 8;
            lblStuName.Text = "StudentName";
            lblStuName.Click += lblStuName_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(302, 163);
            label5.Name = "label5";
            label5.Size = new Size(76, 30);
            label5.TabIndex = 7;
            label5.Text = "Name:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Location = new Point(33, 157);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 250);
            panel2.TabIndex = 6;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(66, 126, 243);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 11F);
            button8.ForeColor = Color.White;
            button8.Image = Properties.Resources.search;
            button8.Location = new Point(512, 88);
            button8.Name = "button8";
            button8.Padding = new Padding(10, 0, 0, 0);
            button8.Size = new Size(132, 40);
            button8.TabIndex = 5;
            button8.Text = "Search";
            button8.TextAlign = ContentAlignment.MiddleRight;
            button8.TextImageRelation = TextImageRelation.ImageBeforeText;
            button8.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(171, 91);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(312, 31);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(33, 91);
            label4.Name = "label4";
            label4.Size = new Size(83, 32);
            label4.TabIndex = 3;
            label4.Text = "Name:";
            // 
            // btnStuIDSearch
            // 
            btnStuIDSearch.BackColor = Color.FromArgb(66, 126, 243);
            btnStuIDSearch.FlatAppearance.BorderSize = 0;
            btnStuIDSearch.FlatStyle = FlatStyle.Flat;
            btnStuIDSearch.Font = new Font("Segoe UI", 11F);
            btnStuIDSearch.ForeColor = Color.White;
            btnStuIDSearch.Image = Properties.Resources.search;
            btnStuIDSearch.Location = new Point(512, 31);
            btnStuIDSearch.Name = "btnStuIDSearch";
            btnStuIDSearch.Padding = new Padding(10, 0, 0, 0);
            btnStuIDSearch.Size = new Size(132, 40);
            btnStuIDSearch.TabIndex = 2;
            btnStuIDSearch.Text = "Search";
            btnStuIDSearch.TextAlign = ContentAlignment.MiddleRight;
            btnStuIDSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStuIDSearch.UseVisualStyleBackColor = false;
            btnStuIDSearch.Click += btnStuIDSearch_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(171, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(312, 31);
            textBox1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(33, 34);
            label3.Name = "label3";
            label3.Size = new Size(132, 32);
            label3.TabIndex = 0;
            label3.Text = "Student ID:";
            // 
            // Attendence
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(63, 68, 93);
            ClientSize = new Size(1792, 909);
            Controls.Add(splitContainer1);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(flowLayoutPanel1);
            Name = "Attendence";
            Text = "Form1";
            Load += Form1_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            StudentEditMenu.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private SplitContainer splitContainer1;
        private Button btnStuIDSearch;
        private TextBox textBox1;
        private Label label3;
        private Button button8;
        private TextBox textBox2;
        private Label label4;
        private Label lblStuName;
        private Label label5;
        private Panel panel2;
        private Label label10;
        private Label label11;
        private Label label8;
        private Label label9;
        private Label label6;
        private Label label7;
    }
}
