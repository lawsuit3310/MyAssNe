using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Examples.Ex006 ex6 = new Examples.Ex006();
            Examples.Ex007 ex7 = new Examples.Ex007();
            Examples.Ex008 ex8 = new Examples.Ex008();

            //ex6.Run();
            ex7.Run();
            ex8.Run(); //ex7의 코드에 명시적 형변환 추가
        }
    }
}
