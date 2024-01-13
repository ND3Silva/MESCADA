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

    public class PrintLine
    {
        private List<string> _list;

        public PrintLine(List<string> InputList)
        {
            _list = InputList;
        }

        public void RearrangeToFixedChar(List<string> list, int CharCount)
        {
            //keeping track of characters
            int CurrentCharsInLine = 0;

          foreach( string word in list)
          {
                //adjusting output if chars are larger than required line amount
                if(CurrentCharsInLine+ word.Length+1> CharCount)
                {
                    Console.WriteLine();
                    CurrentCharsInLine = 0;
                }

                //include spaces for sentences and count
                Console.Write(word+" ");
                CurrentCharsInLine += word.Length+1;

          }
          
         

        }

    }
       
    
}
