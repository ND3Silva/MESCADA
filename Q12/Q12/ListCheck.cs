using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12
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

        public List<int> ReturnOddElements()
        {
            List<int> OddElements = new List<int>();

            foreach (int i in _list)
            {
                if (i % 2 != 0 || i==0)  //checking for odd element index and adding to new list (starting at 0)
                {
                    OddElements.Add(_list[i]);
                }
            }


            Console.WriteLine("The Elements in odd positions in the list are: ");

            OddElements.ForEach(i => Console.WriteLine(i));
            foreach(int y in OddElements)
            {
                Console.WriteLine(OddElements);
            }

            return OddElements;

        }
        
    }
}
