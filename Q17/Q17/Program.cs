using System;
using System.Globalization;
using System.Security.Cryptography;
namespace Q17
{

    class MainClass
    {
        public static void Main(string[] args)
        {


            List<int> list1 = new List<int> { 2342 };

            int num = list1[0];
            int[] result =  new int[4];
            int count = 0;
            while (num > 0)
            {
                int digit = num % 10;
                result[count] = digit;
                num =num / 10;
                count++;
            }
            foreach (int n in result)
            {
                Console.WriteLine(n);
            };



        }

    }

}

