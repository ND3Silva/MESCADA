using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
namespace Q18
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string> list1 = new List<string> { "This", "Text", "is","very","long", "for", "a", "string"};

            PrintLine list = new PrintLine(list1);

            list.RearrangeToFixedChar(list1, 10);
        }

    }

}

