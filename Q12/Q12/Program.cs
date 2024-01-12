using System;
namespace Q12
{

    class MainClass
    {
        public static void Main(string[] args)
        {

            int n;
          
            Console.WriteLine("Please enter a list of 5 numbers one by one: ");
            List<int> UserInputList = new List<int> ();
            for (int i =0; i<=5; i++)
            {
                n = Convert.ToInt32(Console.ReadLine());
                UserInputList.Add(n);
            }
          
            ListCheck List = new(UserInputList);
            List.ReturnOddElements();

        }

    }

}

