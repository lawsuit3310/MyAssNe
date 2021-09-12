using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter01.Examples
{
    class Ex004
    {
        object objValue = 1;
        //오브젝트는 값만 저장하고 자료형은 저장하지 않음.
        dynamic dValue = true;
        //dynamic은 값과 자료형 저장하며, 자료형을 변경할 수 있음.
        public void Run()
        {
            var vValue = "var"; //var는 지역변수로서만 사용할 수 있음.
            //var는 값과 자료형 저장하지만, 한 번 할당되면 자료형을 변경할 수 없음.

            Console.WriteLine("object 변수 값은 {0}",objValue) ;
            Console.WriteLine("var 변수 값은 {0}",vValue) ;
            Console.WriteLine("dynamic 변수 값은 {0}",dValue) ;

        }
    }
}
