using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10
{
    using System;
    using System.Net.Http.Headers;

    public class ListCheck
    {
        private List<int> _list;

        public ListCheck(List<int> InputList)
        {
            _list = InputList;
        }

        public int ReturnLargestElement()
        {
            Console.WriteLine("The Largest Element in the list is: " + _list.Max());
            return _list.Max();

        }
        
    }
}
