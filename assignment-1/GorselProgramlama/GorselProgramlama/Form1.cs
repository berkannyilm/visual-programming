namespace GorselProgramlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelSonuc.Visible = false;
        }

        private void VizeFinalHesapla(object snd,EventArgs e)
        {
            labelSonuc.Visible = true;
            double vize, final, ortalama ;
            vize = Convert.ToDouble(numericUpDown1.Value);
            final = Convert.ToDouble(numericUpDown2.Value);
            ortalama = vize * 0.4 + final * 0.6;

           if (final < 50)
            {
                labelSonuc.Text = "FF ile kaldýnýz";
                labelSonuc.ForeColor = Color.Red;
            }
            else if(ortalama>=85 && ortalama<100)
            {
                labelSonuc.Text = ortalama.ToString()+  " AA ile geçtiniz";
                labelSonuc.ForeColor = Color.Green;
            }
            else if (ortalama >= 80 && ortalama < 85)
            {
                labelSonuc.Text = ortalama.ToString() + " BA ile geçtiniz";
                labelSonuc.ForeColor = Color.Green;
            }
            else if (ortalama >=70 && ortalama < 80)
            {
                labelSonuc.Text = ortalama.ToString() +  " BB ile geçtiniz";
                labelSonuc.ForeColor = Color.Green;
            }
            else if (ortalama >= 60 && ortalama < 70)
            {
                labelSonuc.Text = ortalama.ToString() + " CB ile geçtiniz";
                labelSonuc.ForeColor = Color.Green;
            }
            else if (ortalama >= 50 && ortalama < 60)
            {
                labelSonuc.Text = ortalama.ToString() + " CC ile geçtiniz";
                labelSonuc.ForeColor = Color.Green;
            }
            else
            {
                labelSonuc.Text = "FF ile kaldýnýz";
                labelSonuc.ForeColor = Color.Red;
            } 
        }
    }
}