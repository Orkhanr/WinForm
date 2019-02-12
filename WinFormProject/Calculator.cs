using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProject
{
    public partial class Calculator : Form
    {
        public int? FirstNum { get; set; }
        public int? SecondNum { get; set; }
        public string Operation { get; set; }
        public int? Result { get; set; }


        public Calculator()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text == "0")
            {
                tbxScreen.Text = "2";
            }
            else
            {
                tbxScreen.Text += "2";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text == "0")
            {
                tbxScreen.Text = "1";
            }
            else
            {
                tbxScreen.Text += "1";
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text == "0")
            {
                tbxScreen.Text = "3";
            }
            else
            {
                tbxScreen.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text == "0")
            {
                tbxScreen.Text = "4";
            }
            else
            {
                tbxScreen.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text == "0")
            {
                tbxScreen.Text = "5";
            }
            else
            {
                tbxScreen.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text == "0")
            {
                tbxScreen.Text = "6";
            }
            else
            {
                tbxScreen.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text == "0")
            {
                tbxScreen.Text = "7";
            }
            else
            {
                tbxScreen.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text == "0")
            {
                tbxScreen.Text = "8";
            }
            else
            {
                tbxScreen.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text == "0")
            {
                tbxScreen.Text = "9";
            }
            else
            {
                tbxScreen.Text += "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text == "0")
            {
                tbxScreen.Text = "0";
            }
            else
            {
                tbxScreen.Text += "0";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (FirstNum == null)
            {
                FirstNum = int.Parse(tbxScreen.Text);
                tbxScreen.Text = "0";

            }
            else
            {
                Calculate();
                tbxScreen.Text = Result.ToString();
                FirstNum = Result;
            }
            Operation = "+";
        }

      

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (FirstNum == null)
            {
                FirstNum = int.Parse(tbxScreen.Text);
                tbxScreen.Text = "0";

            }
            else
            {
                Calculate();
                tbxScreen.Text = Result.ToString();
                FirstNum = Result;
            }
            Operation = "-";
        }

        private void btnMlt_Click(object sender, EventArgs e)
        {
            if (FirstNum == null)
            {
                FirstNum = int.Parse(tbxScreen.Text);
                tbxScreen.Text = "0";

            }
            else
            {
                Calculate();
                tbxScreen.Text = Result.ToString();
                FirstNum = Result;
            }
            Operation = "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (FirstNum == null)
            {
                FirstNum = int.Parse(tbxScreen.Text);
                tbxScreen.Text = "0";

            }
            else
            {
                Calculate();
                tbxScreen.Text = Result.ToString();
                FirstNum = Result;
            }
            Operation = "/";
        }
        public void Calculate()
        {
            switch (Operation)
            {
                case "+":
                    Result = int.Parse(tbxScreen.Text) + FirstNum;
                    break;

                case "-":
                    Result = int.Parse(tbxScreen.Text) - FirstNum;
                    break;
                case "*":
                    Result = int.Parse(tbxScreen.Text) * FirstNum;
                    break;
                case "/":
                    Result = FirstNum / int.Parse(tbxScreen.Text);
                    break;
                default:
                    break;
            }
        }
    }
}
