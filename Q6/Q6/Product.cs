using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    using System;

    public class Product
    {
        private int _upperlimit;
        private int _ProductValue;

        public Product(int Upperlimit)
        {
            _upperlimit = Upperlimit;
            _ProductValue = 1;
        }
        public void PrintProduct()
        {
            for (int i = 1; i <= _upperlimit; i++)
            {
                _ProductValue *= i;
            }
            Console.WriteLine("The Product of numbers from 1 to " + _upperlimit + " is: " + _ProductValue);
        }

    }
}
