using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Util util = new Util();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (util.Num1 != "" && util.Action == "")
            {

            }
            else
            {
                if (util.Num == "0")
                {
                    util.Num = "1";
                }
                else
                {
                    util.Num += "1";
                }
            }
            textBox1.Text = util.Num;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (util.Num1 != "" && util.Action == "")
            {

            }
            else
            {
                if (util.Num == "0")
                {
                    util.Num = "2";
                }
                else
                {
                    util.Num += "2";
                }
            }
            textBox1.Text = util.Num;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (util.Num1 != "" && util.Action == "")
            {

            }
            else
            {
                if (util.Num == "0")
                {
                    util.Num = "3";
                }
                else
                {
                    util.Num += "3";
                }
            }
            textBox1.Text = util.Num;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (util.Num1 != "" && util.Action == "")
            {

            }
            else
            {
                if (util.Num == "0")
                {
                    util.Num = "4";
                }
                else
                {
                    util.Num += "4";
                }
            }
            textBox1.Text = util.Num;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (util.Num1 != "" && util.Action == "")
            {

            }
            else
            {
                if (util.Num == "0")
                {
                    util.Num = "5";
                }
                else
                {
                    util.Num += "5";
                }
            }
            textBox1.Text = util.Num;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (util.Num1 != "" && util.Action == "")
            {

            }
            else
            {
                if (util.Num == "0")
                {
                    util.Num = "6";
                }
                else
                {
                    util.Num += "6";
                }
            }
            textBox1.Text = util.Num;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (util.Num1 != "" && util.Action == "")
            {

            }
            else
            {
                if (util.Num == "0")
                {
                    util.Num = "7";
                }
                else
                {
                    util.Num += "7";
                }
            }
            textBox1.Text = util.Num;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (util.Num1 != "" && util.Action == "")
            {

            }
            else
            {
                if (util.Num == "0")
                {
                    util.Num = "8";
                }
                else
                {
                    util.Num += "8";
                }
            }
            textBox1.Text = util.Num;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (util.Num1 != "" && util.Action == "")
            {

            }
            else
            {
                if (util.Num == "0")
                {
                    util.Num = "9";
                }
                else
                {
                    util.Num += "9";
                }
            }
            textBox1.Text = util.Num;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (util.Num1 != "" && util.Action == "")
            {

            }
            else
            {
                if (util.Num != "0")
                {
                    util.Num += "0";
                }
            }
            textBox1.Text = util.Num;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (util.Num1 == "" && util.Num == "")
            {

            }
            else if (util.Num1 == "" && util.Num != "")
            {
                util.Num1 = util.Num;
                util.Num = "";
                util.Action = "+";
                textBox1.Text = util.Num;
            }
            else if (util.Num == "")
            {
                util.Action = "+";
                textBox2.Text = util.Num1 + util.Action;
            }
            else
            {
                util.Result();
                if (Convert.ToInt32(util.Num1) > 999999999 || Convert.ToInt32(util.Num1) < -999999999)
                {
                    util.Action = "";
                    util.Num1 = "";
                    textBox1.Text = "EXCEEDED";
                }
                else
                {
                    textBox1.Text = util.Num;
                }
            }
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            if (util.Num1 == "" && util.Num == "")
            {

            }
            else if (util.Num1 == "" && util.Num != "")
            {
                util.Num1 = util.Num;
                util.Num = "";
                util.Action = "-";
                textBox1.Text = util.Num;
            }
            else if (util.Num == "")
            {
                util.Action = "-";
                textBox2.Text = util.Num1 + util.Action;
            }
            else
            {
                util.Result();
                if (Convert.ToInt32(util.Num1) > 999999999 || Convert.ToInt32(util.Num1) < -999999999)
                {
                    util.Action = "";
                    util.Num1 = "";
                    textBox1.Text = "EXCEEDED";
                }
                else
                {
                    textBox1.Text = util.Num;
                }
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (util.Num1 == "" && util.Num == "")
            {

            }
            else if (util.Num1 == "" && util.Num != "")
            {
                util.Num1 = util.Num;
                util.Num = "";
                util.Action = "*";
                textBox1.Text = util.Num;
            }
            else if (util.Num == "")
            {
                util.Action = "*";
                textBox2.Text = util.Num1 + util.Action;
            }
            else
            {
                util.Result();
                if (Convert.ToInt32(util.Num1) > 999999999 || Convert.ToInt32(util.Num1) < -999999999)
                {
                    util.Action = "";
                    util.Num1 = "";
                    textBox1.Text = "EXCEEDED";
                }
                else
                {
                    textBox1.Text = util.Num;
                }
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (util.Num1 == "" && util.Num == "")
            {

            }
            else if (util.Num1 == "" && util.Num != "")
            {
                util.Num1 = util.Num;
                util.Num = "";
                util.Action = "/";
                textBox1.Text = util.Num;
            }
            else if (util.Num == "")
            {
                util.Action = "/";
                textBox2.Text = util.Num1 + util.Action;
            }
            else
            {
                util.Result();
                if (Convert.ToInt32(util.Num1) > 999999999 || Convert.ToInt32(util.Num1) < -999999999)
                {
                    util.Action = "";
                    util.Num1 = "";
                    textBox1.Text = "EXCEEDED";
                }
                else
                {
                    textBox1.Text = util.Num;
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            util.Num = "";
            util.Num1 = "";
            textBox1.Text = util.Num;
            textBox2.Text = util.Num1;
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            if (util.Num != "" && util.Num != "0")
            {
                if (util.Num.Substring(0, 1) == "-")
                {
                    util.Num = util.Num.Substring(1, util.Num.Length - 1);
                }
                else
                {
                    util.Num = util.Num.Insert(0, "-");
                }
            }
            textBox1.Text = util.Num;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (util.Num1 != "" && util.Num != "")
            {
                util.Result();
                util.Action = "";
                if (Convert.ToInt32(util.Num1) > 999999999 || Convert.ToInt32(util.Num1) < -999999999)
                {
                    util.Num1 = "";
                    textBox1.Text = "EXCEEDED";
                }
                else
                {
                    textBox1.Text = util.Num;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = util.Num1 + util.Action;
        }
    }
}
