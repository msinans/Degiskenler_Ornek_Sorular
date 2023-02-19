namespace Degiskenler_Ornek_Sorular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kýsa, uzun, cevre, alan;
            kýsa = Convert.ToInt16(textBox1.Text);
            uzun = Convert.ToInt16(textBox2.Text);
            cevre = (kýsa + uzun) * 2;
            alan = kýsa * uzun;
            label5.Text = cevre.ToString() + " cm";
            label6.Text = alan.ToString() + " cm";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double yaricap, pi, cevre, alan;
            yaricap = Convert.ToDouble(textBox3.Text);
            pi = 3.14;
            cevre = 2 * pi * yaricap;
            alan = yaricap * yaricap * pi;

            label8.Text = cevre.ToString("0.00");
            label10.Text = alan.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double s1, s2, s3, ort;

            s1 = Convert.ToDouble(textBox4.Text);
            s2 = Convert.ToDouble(textBox5.Text);
            s3 = Convert.ToDouble(textBox6.Text);
            ort = (s1 + s2 + s3) / 3;
            label18.Text = ort.ToString("0.00");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int s1, s2, s3, toplam, fark, carpim;
            s1 = Convert.ToInt16(txtS1.Text);
            s2 = Convert.ToInt16(txtS2.Text);
            s3 = Convert.ToInt16(txtS3.Text);
            toplam = s1 + s2 + s3;
            fark = s1 - s2 - s3;
            carpim = s1 * s2 * s3;
            listBox1.Items.Add("Üç Sayýnýn Toplamý: " + toplam + " Farký: " + fark + " Çarpýmý: " + carpim);
        }
    }
}