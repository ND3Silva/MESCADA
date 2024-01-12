using System;
namespace Q4
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            
            int n;
            Console.WriteLine("Please enter a number");
            n=Convert.ToInt32(Console.ReadLine());
            Sum UserSum = new(n);
            UserSum.PrintSum();
      
   
        }

    }

}

