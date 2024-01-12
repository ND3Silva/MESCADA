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

       
        public void PrintSum()
        {
            for (int i = 0; i <= _upperlimit; i++)
            {
                
                    _sumTotal += i;
                
               
            }
            Console.WriteLine("The Sum of numbers 1 to " + _upperlimit + " is: "+ _sumTotal);
        }

    }
}
