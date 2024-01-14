using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q16
{
    public class ChangeElements
    {
        private List<int> _list;

        public ChangeElements(List<int> InputList)
        {
            _list = InputList;
        }

        public void MoveElementsByK(List<int> list1, int k)
        {
            int NewIndex = 0;
            int[] temp = new int[list1.Capacity];

            //start by saving values for 0-k indeces
            for (int j = 0; j <= (k); j++)
            {
                temp[j] = list1[j];
            }
            // bring kth index to 0 and then start sequence again
            for (int i = k; i < list1.Count; i++)
            {
                list1[NewIndex] = list1[i];
                NewIndex++;
            }
            for (int j = 0; j < (k); j++)
            {
                // Take final values stored earlier in temp and put at the end of list
                list1[NewIndex] = temp[j];
                NewIndex++;
            }
            list1.ForEach(Console.WriteLine);

        }

        public List<string> InterchangeElements(List<string> List1, List<int> List2)
        {
            int combinedLength = List1.Count + List2.Count;
            List<string> result = new List<string>();

            for (int i=0; i<combinedLength; i++)
            {
                //checking the bounds whether it can handle the no. of elements
                if (i < List1.Count)
                {
                    result.Add(List1[i].ToString());
                }

                if (i < List2.Count)
                {
                    result.Add(List2[i].ToString());
                }

            }

            return result;
        }






    }
       
    
}
