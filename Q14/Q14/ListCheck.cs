using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q14
{
    using System;
    using System.Collections;
    using System.Net.Http.Headers;

    public class ListSum
    {
        private List<int> _list;

        public ListSum(List<int> InputList)
        {
            _list = InputList;
        }

        public void ComputeSumForLoop()
        {
            int sum = 0;

            for (int i = 0; i < _list.Count; i++)
            {
                sum += _list[i];

            }
            Console.WriteLine("The Sum using For Loop is: "+sum);

        }
        public void ComputeSumWhileLoop()
        {
            int Count= 0;
            int sum = 0;
            while (Count <= _list.Count-1)
            {
                sum += _list[Count];
                Count++;
            }

            Console.WriteLine("The Sum using While loop is: "+ sum);

        }
       public int ComputeSumRecursion(List<int> list, int size)
        {
            if (size == 0)
            {  // final recursion
                return 0;
            }

            return (ComputeSumRecursion(list, size - 1)+ list[size-1]); 
          
        }
    }
}
