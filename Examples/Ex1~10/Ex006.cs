using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter01.Examples
{
    class Ex006
    {
        public void Run()
        {
            #region >> 정수형 변수
            sbyte shortByteNumber = 127;
            byte byteNumber = 0;
            short shortNumber = 32767;
            int intNunmber = 20000;
            long longNumber = 50000;
            #endregion

            Console.WriteLine("정수 : {0},{1},{2},{3},{4}",
                shortByteNumber,
                byteNumber,
                shortNumber,
                intNunmber,
                longNumber
            );

            #region >> 실수형 변수
            float floatNumber = 3.14f;
            double doubleNumber = 1.5;
            decimal decimalNumber = 5.5m;
            #endregion

            Console.WriteLine("실수 : {0},{1},{2}",
                floatNumber,
                doubleNumber,
                decimalNumber
            );

            #region >> 문자열 변수
            char ch = 'A';
            string strMessage = "Hello World";
            #endregion

            Console.WriteLine(ch);
            Console.WriteLine(strMessage);

            #region >> 참/ 거짓 변수
            bool bCalculate01 = (1 + 2 == 3);
            bool bCalculate02 = ((12 > 8) && (8 < 20));
            bool isContainWord = "Hello Csharp".Contains("Hello");
            #endregion

            Console.WriteLine("1+2 = 3? ({0})", bCalculate01);
            Console.WriteLine("12는 8보다 크고, 8은 20보다 작다? ({0})", bCalculate02);
            Console.WriteLine("Hello Csharp 문장에 Hello가 포함되어 있다 ? ({0})", isContainWord);

            #region >> 만능 변수
            object objValue = 1;
            //오브젝트는 값만 저장하고 자료형은 저장하지 않음.

            var vValue = "var"; //var는 지역변수로서만 사용할 수 있음.
            //var는 값과 자료형 저장하지만, 한 번 할당되면 자료형을 변경할 수 없음.

            dynamic dValue = true;
            //dynamic은 값과 자료형 저장하며, 자료형을 변경할 수 있음.
            #endregion

            Console.WriteLine("object 변수 값은 {0}", objValue);
            Console.WriteLine("var 변수 값은 {0}", vValue);
            Console.WriteLine("dynamic 변수 값은 {0}", dValue);
        }
    }
}