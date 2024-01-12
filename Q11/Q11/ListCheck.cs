using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11
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
        public void CheckElementOccurs(int Element)
        {
            Console.WriteLine("You are checking for Element: " + Element + " in the list");
            if (_list.Contains(Element))
            {
                Console.WriteLine("\n" + Element + " is in the list in position: " + _list.IndexOf(Element));

            }
            else { Console.WriteLine("The element is not found in the list"); }

      
        }
        
    }
}
