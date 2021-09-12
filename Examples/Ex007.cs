using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter01.Examples
{
    class Ex007
    {
        #region Variable
            int Korean = 100;
            int English = 100;
            int Math = 98;
            int Sports = 97;
        #endregion
        public void Run()
        {
            int totoalScore = Korean + English + Math + Sports;

            Console.WriteLine("성적 총점 {0}",totoalScore);
            Console.WriteLine("평균 {0}",totoalScore/4); //totalScore와 4 모두 int 형이므로, 소수점 밑은 출력되지 않음.
        }
    }
}
