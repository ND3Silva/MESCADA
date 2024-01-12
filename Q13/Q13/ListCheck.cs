using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q13
{
    using System;
    using System.Collections;
    using System.Net.Http.Headers;

    public class WordCheck
    {
        private string _word;

        public WordCheck(string InputWord)
        {
            _word = InputWord;
        }

        public void CheckPalindrome()
        {

            int SameElementCount=0;
            for (int i=0;i<(_word.Length/2);i++)
            {

                for (int j=_word.Length-1;j>=_word.Length/2;j--) 
                {
                    if (_word[i] == _word[j])
                    {
                        SameElementCount++;
                        break;
                    }

                }
            }

            if( SameElementCount == _word.Length/2 ) {

                Console.WriteLine(" The word is a palindrome ");
               
            }
            else
            {
                Console.WriteLine(" The word is not a palindrome ");
                
            }
           

        }
        
    }
}
