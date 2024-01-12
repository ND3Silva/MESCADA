using System;
using System.Security.Cryptography;
namespace Q13
{

    class MainClass
    {
        public static void Main(string[] args)
        {

            string input;
          
            Console.WriteLine("Please enter a word: ");
            input = Console.ReadLine();
            WordCheck Word = new WordCheck(input) ;
            Word.CheckPalindrome();
           

        }

    }

}

