using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q19
{
    using System;
    using System.Collections;
    using System.ComponentModel.DataAnnotations;
    using System.Net.Http.Headers;

    public class Translate
    {
        private List<string> _list;

        public Translate(List<string> InputList)
        {
            _list = InputList;
        }

        public void TranslateToPigLatin()
        {

            foreach (string word in _list)
            {
                char FL = word.First();
                string firstLetter = FL.ToString();
                string WordWithoutFirstLetter = word.Substring(1);

                Console.WriteLine(WordWithoutFirstLetter + firstLetter.ToLower() + "ay");
            }

        }

        public string WordWithoutSuffix(string word){
            //removing last 2 characters from word
            return word.Substring(0, word.Length - 2);
        }

        public string BringLastLetterToFrontAndRemove(string word)
        {
            //saving last letter, moving and removing from word
            char lastletter = word.Last();
            word = lastletter + word;
            word= word.Substring(0, word.Length - 1);
            return word;

        }
        public void TranslateToEnglish(List<string> list)
        {
            for( int i =0; i<list.Count; i++)
            {
                if (list[i].EndsWith("ay"))
                {   //satisfy condition then remove suffix, swap and remove letters
                    list[i] = WordWithoutSuffix(list[i]);
                    list[i] = BringLastLetterToFrontAndRemove(list[i]);
                    Console.WriteLine(list[i]);
                    
                     
                }

            }

        }

    }
       
    
}
