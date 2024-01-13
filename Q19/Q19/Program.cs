using Q19;
using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
namespace Q19
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string> list1 = new List<string> { "The", "Quick", "Brown","Fox"};
            List<string> list2 = new List<string> { "hetay", "uickqay", "rownbay", "oxfay" };
            Translate Sentence = new Translate(list1);
            Console.WriteLine("Translating "+ "'The Quick Brown Fox'"+" into Pig Latin: ");
            Sentence.TranslateToPigLatin();
            Console.WriteLine("Translating Back into English: ");
            Sentence.TranslateToEnglish(list2);

        }

    }

}

