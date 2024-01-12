using System;
using System.Security.Cryptography;
namespace Q14
{

    class MainClass
    {
        public static void Main(string[] args)
        {

            List<int> inputList = new List<int> { 1, 2, 3, 4, 5 } ;
            ListSum SumList = new ListSum(inputList);

            SumList.ComputeSumForLoop();
            SumList.ComputeSumWhileLoop();
         Console.WriteLine("The Sum Using recursion is: " + SumList.ComputeSumRecursion(inputList,inputList.Count));




        }

    }

}

