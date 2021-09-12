using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter01.Examples.Ex11_
{
    class Ex011
    {
        int globalValue = 20;

        public void Run()
        {
            int localValue = 10;

            Sum();
            Multiple();

            Console.WriteLine("global : {0} / local : {1}",globalValue,localValue);
        }

        private void Sum()
        {
            globalValue += 10;
        }

        private void Multiple()
        {
            globalValue *= 2;
        }
    }
}
