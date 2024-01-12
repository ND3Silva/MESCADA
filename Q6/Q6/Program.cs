using System;
namespace Q4
{

    class MainClass
    {
        public static void Main(string[] args)
        {

            int n;
            string selection;
            Console.WriteLine("Please enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            Sum UserSum = new(n);
            Product UserProduct = new(n);
            Console.WriteLine("Do you want to compute the sum or product? (Press s for Sum or p for product");
            selection = Console.ReadLine();
           
           if(selection == "s")
           {
                UserSum.PrintSum();
           }
           else if(selection== "p")
           {
                UserProduct.PrintProduct();
           }
           else
           {
                Console.WriteLine("You have not chosen s or p");
           }

        }

    }

}