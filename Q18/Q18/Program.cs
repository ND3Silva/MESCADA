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
            List<string> list1 = new List<string> { "Hello", "World", "in","a","frame"};

            Frame list = new Frame(list1);
            list.MakeFrame();
        }

    }

}

