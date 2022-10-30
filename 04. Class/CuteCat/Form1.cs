using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuteCat
{
    public partial class Form1 : Form
    {
        // 인스턴스 생성
        // new Cat() 의 Cat()은 클래스 생성자이다.
        // Cat() 메소드는 인스턴스를 생성할 때 사용하며 생성자라고 불린다.
        // Cat.cs를 보면 Cat()이라는 생성자에 대한 코드를 작성지 않아도 클래스와 같은 이름으로 자동 추가된다.
        // 기본 생성자가 아닌 경우 필드에 대한 내용을 넘겨줘야함.
        // Instance가 생성됨과 동시에 변수의 초기화를 진행한다는 장점이 있음.
        private Cat MyCat = new Cat("Kitty", 2);

        public Form1()
        {
            InitializeComponent();

           
        }

        private void ExpressClick(object sender, EventArgs e)
        {
            CatScreen.Text = MyCat.Express();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            MyCat.Play();
            CatScreen.Text = MyCat.Express();
        }

        private void Feed_Click(object sender, EventArgs e)
        {
            MyCat.Eat();
            CatScreen.Text = MyCat.Express();
        }

        private void CatTimer_Tick(object sender, EventArgs e)
        {
            MyCat.GetBored();
            CatScreen.Text = MyCat.Express();
        }
    }

}
