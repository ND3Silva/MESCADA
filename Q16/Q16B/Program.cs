using System;

namespace Q16
{

    class MainClass
    {
        public static void Main(string[] args)
        {


            List<int> list1 = new List<int> { 1, 2, 3, 4, 5, 6 };

            int k = 2;
            int NewIndex = 0;
            int[] temp = new int[list1.Capacity];

            for (int j = 0; j <= (k); j++)
            {
                temp[j] = list1[j];
            }

            for (int i = k; i < list1.Count; i++)
            {
                
                list1[NewIndex] = list1[i];
                NewIndex++;
            }
            for (int j = 0; j < (k ); j++)
            {
               
                list1[NewIndex] = temp[j];
                NewIndex++;
              
            }
            list1.ForEach(Console.WriteLine);
                 


        }

    }

}

