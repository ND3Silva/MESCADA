using System;
namespace Q4
{

    class MainClass
    {
        public static void Main(string[] args)
        {

            int guess=-1;
            int attempts=0;
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 100);
            int lastguess=-1;

          

            while (guess!= randomNumber)
            {

                Console.WriteLine("Please enter your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
                
                if (guess != lastguess)
                {
                    attempts++;
                }

                lastguess = guess; // need to assign after the attempts logic in order to distinguish previous attempt

                if (guess< randomNumber)
                {
                    Console.WriteLine("Your guess was too low");
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Your guess was too high");
                }
                else if(guess == randomNumber)
                {
                    break;
                }

                
            }

            Console.WriteLine("Congrats! the number was: "+ randomNumber +"\n The number of attempts you took is: " + attempts);


        }

    }

}

