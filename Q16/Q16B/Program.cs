using System;
using System.IO.IsolatedStorage;
using System.Security.Cryptography.X509Certificates;

namespace Q16
{

    class MainClass
    {
        
        public static void Main(string[] args)
        {          
            List<int> list1 = new List<int> { 1,2,3,5,6,};
            List<string> list2 = new List<string> { "a","b","c"};
            List<int> list3 = new List<int> { 1, 2, 3};
            ChangeElements Input = new ChangeElements(list1);

           int MoveBy2Elements = 2;
           Input.MoveElementsByK(list1, MoveBy2Elements);

           Console.WriteLine(string.Join(",",Input.InterchangeElements(list2, list3)));
          
        }
        

    }

}

