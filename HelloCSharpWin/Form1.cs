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
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}
