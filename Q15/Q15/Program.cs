using System;
using System.Security.Cryptography;
namespace Q15
{

    class MainClass
    {
        public static void Main(string[] args)
        {

           List<string> list1  = new List<string >{ "a", "b", "c"};
            List<int> list2 = new List<int> { 1, 2, 3 };
            List<string> Concat = new List<string> ();


            foreach (string s in list1) 
            {
                
             Concat.Add(s); }

            foreach (int n in list2)
            {
                string s = n.ToString(); 
                Concat.Add(s);
            }


            foreach(string s in Concat)
            {
                Console.WriteLine(s);
            }




        }

    }

}

