namespace Class_Pilot
{
    public partial class Attendence : Form
    {
        private bool StuEditCollapse = true;
        private const int AnimationIncrement = 10;
        private const int AnimationInterval = 5;
        public Attendence()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (StuEditCollapse)
            {
                if (StudentEditMenu.Height < StudentEditMenu.MaximumSize.Height)
                {
                    StudentEditMenu.Height += AnimationIncrement;
                }
                else
                {
                    StuEditCollapse = false;
                    StuEditMenuTimer.Stop();
                }
            }
            else
            {
                if (StudentEditMenu.Height > StudentEditMenu.MinimumSize.Height)
                {
                    StudentEditMenu.Height -= AnimationIncrement;
                }
                else
                {
                    StuEditCollapse = true;
                    StuEditMenuTimer.Stop();
                }
            }
        }

        private void btnStudentEdit_Click(object sender, EventArgs e)
        {
            if (!StuEditMenuTimer.Enabled)
            {
                StuEditMenuTimer.Interval = AnimationInterval;
                StuEditMenuTimer.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void btnStuIDSearch_Click(object sender, EventArgs e)
        {

        }

        private void lblStuName_Click(object sender, EventArgs e)
        {

        }
    }
}
