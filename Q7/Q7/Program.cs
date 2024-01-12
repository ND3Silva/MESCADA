using System;
namespace Q7
{

    class MainClass
    {
        public static void Main(string[] args)
        {

            int n;
            Console.WriteLine("Please enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            MultiplicationTable MT = new(n);
            MT.PrintTable();

        }

    }

}

