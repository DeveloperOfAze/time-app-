namespace Timer_App
{
    public partial class Form1 : Form
    {

        int i = 0;
        int saniye = 180;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            string saniye1 = textBox1.Text;
                
                           
            saniye--;
            if (saniye < 170 )
            {
                lblMinute.Visible = true;
                lblSecond.Visible = true;
                lblorta.Visible = true;

                lblMinute.Text = (saniye / 60).ToString();
                lblSecond.Text = (saniye % 60).ToString();
            }
       
        }

        private void lblMinute_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMinute.Visible = false;
            lblSecond.Visible = false;
            lblorta.Visible = false;
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }
    }
}