using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    class SingleTon1
    {
        static SingleTon1 instance; // 5. 전역으로 가야 메서드가 끝나도 살아서 계속 쓸 수 있다.
        private SingleTon1() //2. 프라이빗으로 바꾸면 인스턴스 생성 불가하기 때문에.
        {

        }

        public static SingleTon1 CreateInstance()//3. 외부에서 불러야 하니 public, 모두 쓸테니 static 4. 반환 타입은 싱글톤의 타입으로!!
        {
            if (instance == null)
            {
                instance = new SingleTon1();
            }

            return instance;
        }
        public void Method()
        {
            Console.WriteLine("메서드 실행");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SingleTon1 c1 = SingleTon1.CreateInstance();
            c1.Method(); //1. 기본생성자가 있어서 필요할때마다 지가 생성한다.

            SingleTon1 c2 = SingleTon1.CreateInstance();
            c2.Method(); //1. 기본생성자가 있어서 필요할때마다 지가 생성한다.
        }
    }
}