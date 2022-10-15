// C#은 using 키워드를 통해 namespace 를 Import함
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespace 키워드는 필드( {} )를 구분하기 위해 사용한다.
// 필드는 클래스 또는 메소드를 구분하며 using을 통해 클래스를 호출하는 경우 namespace를 통한 구분이 필요하다.

namespace HelloCSharp // HelloCSharp 라는 namespace로 HelloWorld를 출력하는 'Program' Class를 구분시킴
{
    class Program // 실행 시 Window OS가 HelloCSharp 의 Program을 실행함(Main Function)
    {
        // Main Function은 타 언어와 마찬가지로 Program(Console Application) 실행 시 최우선으로 실행됨
        // 
        static void Main(String[] args)
        {
            Console.WriteLine("Hello C#");
            Console.ReadKey(); // 사용자가 Consle에 값을 입력할 때 까지 대기
        }
    }
}