using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter01.Examples
{
    public class Ex001
    {
        sbyte shortByteNumber = 127;
        byte byteNumber = 0;
        short shortNumber = 32767;
        int intNunmber = 20000;
        long longNumber = 50000;

        float floatNumber = 3.14f;
        double doubleNumber = 1.5;
        decimal decimalNumber = 5.5m;

        public void Run()
        {
            

            Console.WriteLine("정수 : {0},{1},{2},{3},{4}",
                shortByteNumber,
                byteNumber,
                shortNumber,
                intNunmber,
                longNumber
            );

            Console.WriteLine("실수 : {0},{1},{2}",
                floatNumber,
                doubleNumber,
                decimalNumber                    
            );
        }
    }
}
