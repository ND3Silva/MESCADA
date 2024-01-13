using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q18
{
    using System;
    using System.Collections;
    using System.Net.Http.Headers;

    public class Frame
    {
        private List<string> _list;

        public Frame(List<string> InputList)
        {
            _list = InputList;
        }

        public void MakeFrame()
        {
            int squareFrameWidth = 0;

            //finding largest word to make border length
            foreach (string word in _list)
            {
                if (word.Length > squareFrameWidth)
                {
                    squareFrameWidth = word.Length;
                }
            }
            //writing top border with extra stars for the vertical lines
            string border = new string('*', squareFrameWidth + 2);
            Console.WriteLine(border);

            //writing each word and padding to reach the largest word length
            foreach (string s in _list)
            {
                Console.WriteLine("*" + s.PadRight(squareFrameWidth) + "*");
            }

            //bottom border
            Console.WriteLine(border);

        }

    }
       
    
}
