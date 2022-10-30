using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    // 열거형 Data Type enum
    public enum Operators {Add, Sub, Mul, Div};

    public partial class Form1 : Form
    {
        public bool isNewNum = true;
        public int result = 0;
        public Operators Opt = Operators.Add;

        public Form1()
        {
            InitializeComponent();
            NumScreen.Text = "0";
        }
        public void SetNum(String num)
        {
            if (isNewNum)
            {
                NumScreen.Text = num;
                isNewNum = false;
            }
            else
            {
                NumScreen.Text = NumScreen.Text + num;
            }
        }

        private void Num1BtnClick(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
        }

        private void Num2BtnClick(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
        }

        private void Num3BtnClick(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
        }

        private void Num4BtnClick(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
        }

        private void Num5BtnClick(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
        }

        private void Num6BtnClick(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
        }

        private void Num7BtnClick(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
        }

        private void Num8BtnClick(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
        }

        private void Num9BtnClick(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
        }

        private void Num0BtnClick(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
        }

        private void ClearBtnClick(object sender, EventArgs e)
        {
            NumScreen.Text = "0";
            isNewNum = true;
            Opt = Operators.Add;
            result = 0;
        }

        private void DelBtnClick(object sender, EventArgs e)
        {
            if (NumScreen.Text == "0")
                NumScreen.Text = "0";
            else
                NumScreen.Text = NumScreen.Text.Substring(0, NumScreen.Text.Length - 1);

        }
        private void CalculateBtnClick(object sender, EventArgs e)
        {
            if (isNewNum == false)
            {
                int num = int.Parse(NumScreen.Text);

                if (Opt == Operators.Add)
                {
                    result += num;
                }
                else if (Opt == Operators.Sub)
                {
                    result -= num;
                }
                else if (Opt == Operators.Mul)
                {
                    result *= num;
                }
                else if (Opt == Operators.Div)
                {
                    result /= num;
                }

                Button optButton = (Button)sender;
                if (optButton.Text == "+")
                {
                    Opt = Operators.Add;
                }
                else if (optButton.Text == "X")
                {
                    Opt = Operators.Mul;
                }
                else if (optButton.Text == "/")
                {
                    Opt = Operators.Div;
                }
                else if (optButton.Text == "-")
                {
                    Opt = Operators.Sub;
                }
               
                NumScreen.Text = result.ToString();
                isNewNum = true;
                
            }

        }
    }
}
