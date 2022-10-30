using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Class는 별도의 파일로 관리되는 것이 좋다.
// new 키워드는 메모리 할당 연산자
namespace CuteCat
{
    // internal class의 의미는 CuteCat 이라는 namespace에서만 사용 가능한 Class라는 의미
    // public class의 경우 타 namespace에서도 사용 가능
    public class Cat
    {
        // 아무런 접근 제한자를 두지 않는 경우 private으로 동작함.
        // private은 변수는 Class 내부에서만 사용 가능함,
        // Class외부 즉, 인스턴스 차원에서는 변수가 있는지 확인, 접근이 불가함(W,R).
        public string Name;
        public int Age;

        // 고양이의 행복지수는 Method를 통해서만 접근 가능하도록 private으로 선언
        // 외부에서 직접적으로로 고양이의 행복지수를 Control할 수 없음.
        private int Happiness = 50;

        // 명시적 생성자 선언
        // 생성자는 public으로 사용해야한다. 외부에서 접근해야하기 때문
        // private이면 class사용을 못함
        // 생성자는 return 타입이 없으며 method와 차이점이다.
        // 생성자의 함수명은 Class명과 같아야함.

        // 기본생성자(자동생성됨, 코드에 추가되던 안되던 똑같음)
        //public Cat()
        //{
       // }
        
        // 매개변수를 받는 생성자
        // Class의 field, method에 접근할 때 . 연산자를 사용
        // Class 내부에서 사용하는 this는 인스턴스 자체이다.
        // 즉 아래의 내용은 현재 인스턴스화 되는 객체의 Name은 Cat 클래스를 생성할 때 넘어가는 name이다. 라는 의미가 된다.
        public Cat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        private int CheckHappiness(int Happiness)
        {
            if(Happiness >= 100)
            {
                Happiness = 100;
            }
            else if(Happiness <= 0)
            {
                Happiness = 0;
            }
            return Happiness;
        }
        public void GetBored()
        {
            Happiness -= 10;
            CheckHappiness(Happiness);
        }
        public void Play()
        {
            Happiness += 10;
            CheckHappiness(Happiness);
        }
        public void Eat()
        {
            Happiness += 20;
            CheckHappiness(Happiness);
        }
        public string Express()
        {
            string message = "";

            if(Happiness >= 80)
            {
                message = "I'm verry happy! ^>3<^";
            }
            else if(Happiness >= 60)
            {
                message = "I'm happy~ ^-3-^";
            }
            else if(Happiness >= 40)
            {
                message = "I'm so so ^-_-^";
            }
            else if(Happiness >= 20)
            {
                message = "I'm gloomy... ^ㅜ_ㅜ^";
            }
            else
            {
                message = "I'm sad... <ㅠ_ㅠ>";
            }
            return this.Name + ": " + message;
        }
    }
}
