using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter01.Examples
{
    class Ex010
    {
        

        public void Run()
        {
            string strNumber = "10";

            int convertNumber = Convert.ToInt32(strNumber); //Convert를 사용한 int형으로의 형변환은 값이 NULL이여도 에러가 나지 않음
            int parseNumber = Int32.Parse(strNumber); //Parse를 사용한 int형으로의 형변환은 값이 NULL일 경우 컴파일러 에라가 남.

            Console.WriteLine("{0} + {1} = {2}",convertNumber,parseNumber,convertNumber + parseNumber);
        }
    }
}
