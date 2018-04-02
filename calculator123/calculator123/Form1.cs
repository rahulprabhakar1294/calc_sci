using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator123
{
    public partial class Form1 : Form
    {
        Double res = 0;
        String oprn = "";
        bool enter_val = false;
        float icel, ifar, ikev;
        char oprn2;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 317;
            textBox2.Width = 278;
        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1113;
            textBox2.Width = 586;
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 317;
            textBox2.Width = 278;
        }

        private void scintificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 622;
            textBox2.Width = 586;
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "0") || (enter_val))
                textBox2.Text = "";
            enter_val = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textBox2.Text.Contains("."))
                    textBox2.Text = textBox2.Text + num.Text;
            }
            else
                textBox2.Text = textBox2.Text + num.Text;
            enter_val = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            lblshow.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            lblshow.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1, 1);
            if (textBox2.Text == "")
                textBox2.Text = "0";

        }

        private void airthametic(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            oprn = num.Text;
            res = Double.Parse(textBox2.Text);
            textBox2.Text = "";
            lblshow.Text = Convert.ToString(res)+" "+oprn;
            enter_val = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            lblshow.Text = "";
            switch(oprn)
            {
                case "+":
                    textBox2.Text = (res + Double.Parse(textBox2.Text)).ToString();
                    break;
                case "-":
                    textBox2.Text = (res - Double.Parse(textBox2.Text)).ToString();
                    break;
                case "*":
                    textBox2.Text = (res * Double.Parse(textBox2.Text)).ToString();
                    break;
                case "/":
                    textBox2.Text = (res / Double.Parse(textBox2.Text)).ToString();
                    break;
                case "%":
                    textBox2.Text = (res % Double.Parse(textBox2.Text)).ToString();
                    break;

            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double var1 = 1;
            for (int i = 1; i <= Convert.ToDouble(textBox2.Text); i++)
            {
                var1 = var1 * i;
            }
            textBox2.Text = Convert.ToString(var1);            
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox2.Text = "3.141592654";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox2.Text);
            lblshow.Text = Convert.ToString("log10" + "(" + (textBox2.Text) + ")");
            ilog = Math.Log10(ilog);
            textBox2.Text = Convert.ToString(ilog);
            //conversion into log10 
        }

        private void button31_Click(object sender, EventArgs e)
        {
            double sqrt = Double.Parse(textBox2.Text);
            lblshow.Text = Convert.ToString("sqrt" + "(" + (textBox2.Text) + ")");
            sqrt = Math.Sqrt(sqrt);
            textBox2.Text = Convert.ToString(sqrt);
            //conversion into square root
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Double a = Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox2.Text);
            textBox2.Text = Convert.ToString(a);
            //conversion into x*x
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double cosh = Double.Parse(textBox2.Text);
            lblshow.Text = Convert.ToString("cosh" + "(" + (textBox2.Text) + ")");
            cosh = Math.Cosh(cosh);
            textBox2.Text = Convert.ToString(cosh);
            //conversion into cosh
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double tanh = Double.Parse(textBox2.Text);
            lblshow.Text = Convert.ToString("tanh" + "(" + (textBox2.Text) + ")");
            tanh = Math.Tanh(tanh);
            textBox2.Text = Convert.ToString(tanh);
            //conversion into tanh
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double sinh = Double.Parse(textBox2.Text);
            lblshow.Text = Convert.ToString("sinh" + "(" + (textBox2.Text) + ")");
            sinh = Math.Sinh(sinh);
            textBox2.Text = Convert.ToString(sinh);
            //conversion into sinh
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double radians = Double.Parse(textBox2.Text);
            double degrees = radians *Math.PI / 180;
            lblshow.Text = Convert.ToString("sin" + "(" + (textBox2.Text) + ")");
            double sin = Math.Sin(degrees);
            textBox2.Text = Convert.ToString(sin);
            //conversion into sin
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double radians = Double.Parse(textBox2.Text);
            double degrees = radians * Math.PI / 180;
            lblshow.Text = Convert.ToString("cos" + "(" + (textBox2.Text) + ")");
            double cos = Math.Cos(degrees);
            textBox2.Text = Convert.ToString(cos);
            //conversion into cos
        }

        private void button29_Click(object sender, EventArgs e)
        {
            double radians = Double.Parse(textBox2.Text);
            double degrees = radians * Math.PI / 180;
            lblshow.Text = Convert.ToString("tan" + "(" + (textBox2.Text) + ")");
            double tan = Math.Tan(degrees);
            textBox2.Text = Convert.ToString(tan);
            //conversion into tan
        }

        private void button33_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox2.Text);
            textBox2.Text = Convert.ToString(a, 2);
            //conversion into bin

        }

        private void button32_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox2.Text);
            textBox2.Text = Convert.ToString(a);
            //conversion into dec
        }

        private void button34_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox2.Text);
            textBox2.Text = Convert.ToString(a, 16);
            //conversion into hex
        }

        private void button35_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox2.Text);
            textBox2.Text = Convert.ToString(a, 8);
            //conversion into octal
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Double a = Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox2.Text);
            textBox2.Text = Convert.ToString(a);
            //conversion into x*x*x
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Double a =Convert.ToDouble(1.0 / Convert.ToDouble(textBox2.Text));
            textBox2.Text = Convert.ToString(a);
            //conversion into 1/x
        }

        private void rbcel2fah_CheckedChanged(object sender, EventArgs e)
        {
            oprn2 = 'C';
        }

        private void rbfah2cel_CheckedChanged(object sender, EventArgs e)
        {
            oprn2 = 'F';

        }

        private void rbkel_CheckedChanged(object sender, EventArgs e)
        {
            oprn2 = 'K';

        }

        private void button42_Click(object sender, EventArgs e)
        {
            textconv.Clear();
            boxres.Text = "";
            rbcel2fah.Checked = false;
            rbkel.Checked = false;
            rbfah2cel.Checked = false;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(-Convert.ToInt32(textBox2.Text));
            enter_val = false;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox2.Text);
            lblshow.Text = Convert.ToString("ln" + "(" + (textBox2.Text) + ")");
            ilog = Math.Log(ilog);
            textBox2.Text = Convert.ToString(ilog);
            //conversion into ln
        }

        private void button41_Click(object sender, EventArgs e)
        {
            switch(oprn2)
            {
                case 'C':
                    //celsius to fahrenheit
                    icel = float.Parse(textconv.Text);
                    boxres.Text = (((9 * icel) / 5) + 32).ToString();
                    break;
                case 'F':
                    //fahrenheit to celsius
                    ifar = float.Parse(textconv.Text);
                    boxres.Text = ((ifar -32) * 5/9).ToString();
                    break;
                case 'K':
                    //kelvin
                    ikev = float.Parse(textconv.Text);
                    boxres.Text = ((((9 * ikev) / 5) + 32)+273.15).ToString();
                    break;
            }
        }
    }
}
