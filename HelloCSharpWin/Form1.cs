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
        private void sumNumbers_Click(object sender, EventArgs e)
        {
            // Init numbers
            int number1 = 0;
            int number2 = 0;

            // C#에서의 조건문
            // 사용자 VALUE INPUT 예외처리
            if (String.IsNullOrWhiteSpace(sum1.Text))
            {
                MessageBox.Show("sum1에 숫자를 입력하세요");
                sum1.Focus();
                return;
            }
            // TryParse Function은 입력된 매개변수를 특정 데이터 타입으로 변환을 시도한다.
            // Parsing 결과를 Bool 형으로 반환하며 예외처리가 가능하다.
            if(int.TryParse(sum1.Text, out number1) == false){
                MessageBox.Show("sum1에 문자열이 아닌 숫자를 입력해주세요");
                sum1.Focus();
                sum1.SelectAll();
                return;
            }
            if (String.IsNullOrWhiteSpace(sum2.Text))
            {
                MessageBox.Show("sum2에 숫자를 입력하세요");
                sum2.Focus();
                return;
            }
            if(int.TryParse(sum2.Text, out number2) == false)
            {
                MessageBox.Show("sum2에 문자열이 아닌 숫자를 입력해주세요");
                sum2.Focus();
                sum2.SelectAll();
                return;
            }

            int result = Add(number1, number2);
            sumResult.Text = result.ToString();
        }

        // Add 함수 선언
        private int Add(int num1, int num2)
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
