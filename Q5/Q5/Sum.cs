using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    using System;



    public class Sum
    {
        private int _upperlimit;
        private int _sumTotal;

        public Sum(int Upperlimit)
        {
            _upperlimit = Upperlimit;
        }

        public bool divisibleby3(int number)
        {
            return number % 3 == 0;
        }

        public bool divisibleby5(int number)
        {
            return number % 5 == 0;
        }
        public void PrintSum()
        {
            for (int i = 0; i <= _upperlimit; i++)
            {
                if ((divisibleby3(i)) || (divisibleby5(i)))
                {
                    _sumTotal += i;
                }

            }
            Console.WriteLine("The Sum of numbers divisible by 3 or 5, from 1 to " + _upperlimit + " is: " + _sumTotal);
        }

    }
}
