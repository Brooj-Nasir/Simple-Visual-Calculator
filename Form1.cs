namespace calcu
{
    public partial class Form1 : Form
    {
        int value1;
        int value2;
        int result = 0;
        string sign;
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(textBox1.Text);
            sign = "-";
            label1.Text = textBox1.Text + sign;
            textBox1.Text = " ";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void btn_Mul_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(textBox1.Text);
            sign = "*";
            label1.Text = textBox1.Text + sign;
            textBox1.Text = " ";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(textBox1.Text);
            sign = "+";
            label1.Text = textBox1.Text + sign;
            textBox1.Text = " ";
        }

        private void btn_Equal_Click(object sender, EventArgs e)
        {
            value2 = Convert.ToInt32(textBox1.Text);
            label2.Text = textBox1.Text;
            if (sign == "+")
            {
                result = value1 + value2;
                textBox1.Text = Convert.ToString(result);
            }
            else if (sign == "-")
            {
                result = value1 - value2;
                textBox1.Text = Convert.ToString(result);
            }
            else if (sign == "*")
            {
                result = value1 * value2;
                textBox1.Text = Convert.ToString(result);
            }
            else if (sign == "/")
            {
                result = value1 / value2;
                textBox1.Text = Convert.ToString(result);
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void btn_Div_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(textBox1.Text);
            sign = "/";
            label1.Text = textBox1.Text + sign;
            textBox1.Text = " ";
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(textBox1.Text);
            sign = "log";
            label1.Text = textBox1.Text + sign;
            textBox1.Text = " ";
        }
    }
}
