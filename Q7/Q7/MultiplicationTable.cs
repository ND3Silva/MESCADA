using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    using System;
    using System.Net.Http.Headers;

    public class MultiplicationTable
    {
        private int _number;

        public MultiplicationTable(int SelectedNumber)
        {
            _number = SelectedNumber;
        }

        public void PrintTable()
        {
            int product;
            Console.WriteLine("The Multiplication Table for " + _number + " is: ");
            for (int i = 1; i <= 12; i++)
            {
                product = i * _number;
                Console.WriteLine(i + "x" + _number + "= " + product + "\n");
            }

        }
    }
}
