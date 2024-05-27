namespace QuickPay
{
    public partial class Quickpay : Form
    {
        public Quickpay()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int startP = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startP += 1;
            if (startP <= MyProgress.Maximum)  // Check if startP exceeds maximum
            {
                MyProgress.Value = startP;
            }
            else
            {
                MyProgress.Value = 0; // Reset the progress bar
                login Obj = new login();
                Obj.Show();
                this.Hide();
                timer1.Stop();
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}