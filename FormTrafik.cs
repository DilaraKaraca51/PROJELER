namespace trafik_lambası
{
    public partial class FormTrafik : Form
    {
        public FormTrafik()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Start();
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {



            sayac++;
            label1.Text= sayac.ToString();
            if (sayac == 1)
            {
                pictureBox1.Visible = true;
                this.BackColor=Color.Red;
            }
            if (sayac == 10)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                this.BackColor=Color.Green;
            }
            if (sayac == 20)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                this.BackColor=Color.Yellow;
            }
            if (sayac == 30)
            {
                pictureBox3.Visible= false;
                sayac =0;
            }


        }


    }
}