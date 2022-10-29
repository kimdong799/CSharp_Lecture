using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharpWin
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        // Window App의 HelloLabel에 대한 이벤트 핸들러
        private void HelloLabel_Click(object sender, EventArgs e)
        {
            HelloLabel.Text = "Hello C#"; // HelloLabel의 Text가 지정된 문자열로 바뀜

            int num1 = 1;
            int num2 = 2;

            int sum = num1 + num2;

            HelloLabel.Text = sum.ToString();

        }

        // Snum Number Click Evernt Handler
        public void sumNumbers_Click(object sender, EventArgs e)
        {
            // Init numbers
            int number1 = 0;
            int number2 = 0;
        }
            

        // Add 함수 선언
        public int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        // Overloaing 
        // 같은 이름의 함수라도 다른 이자값들을 받는다면 언제든지 생성 가능
        private float Add(float num1, float num2)
        {
            float result = num1 + num2;
            return result;
        }
    }
}
