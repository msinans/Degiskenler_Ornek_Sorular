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
            int k�sa, uzun, cevre, alan;
            k�sa = Convert.ToInt16(textBox1.Text);
            uzun = Convert.ToInt16(textBox2.Text);
            cevre = (k�sa + uzun) * 2;
            alan = k�sa * uzun;
            label5.Text = cevre.ToString() + " cm";
            label6.Text = alan.ToString() + " cm";
        }
    }
}