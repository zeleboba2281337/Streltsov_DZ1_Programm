using System;
using System.Windows.Forms;

namespace Streltsov_DZ1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Calculate(long.Parse(textBox1.Text)).ToString();
        }

        private long Calculate(long input)
        {
            long summ = 0;
            for (long i = 0; i <= input; i++)
            {
                summ += (long)Math.Sqrt(i);
            }
            return summ;
        }
    }
}
