namespace Euklides_NWD
{
    public partial class Form1 : Form
    {
        int a, b, w, x;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            String NWD = "NWD = " + a;
            MessageBox.Show(NWD.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            if (b != 0)
            {
                w = a % b;
                a = b;
                b = w;
            }
            x = a * b;
            int nww = x / a;
            String NWW = "NWW = " + nww;
            MessageBox.Show(NWW.ToString());

        }
    }
}