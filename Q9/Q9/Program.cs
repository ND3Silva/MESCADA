using System;
namespace Q9
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           
            int n;
            Console.WriteLine("What year is it?: ");
            n = Convert.ToInt32(Console.ReadLine());
            LeapYear LY = new LeapYear(n);
            LY.PrintNext20LeapYears();

        }

    }

}

