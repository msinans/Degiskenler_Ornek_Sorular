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
    }
}