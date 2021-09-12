using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter01.Examples
{
    class Ex003
    {
        bool bCalculate01 = (1 + 2 == 3);
        bool bCalculate02 = ((12 > 8) && (8 < 20));
        bool isContainWord = "Hello Csharp".Contains("Hello"); //.Contains(); == 한 문자열 안에 다른 문자열이 포함되어 있는지 체크.

        public void Run()
        {
            Console.WriteLine("1+2 = 3? ({0})", bCalculate01);
            Console.WriteLine("12는 8보다 크고, 8은 20보다 작다? ({0})", bCalculate02);
            Console.WriteLine("Hello Csharp 문장에 Hello가 포함되어 있다 ? ({0})", isContainWord);
        }
    }
}
