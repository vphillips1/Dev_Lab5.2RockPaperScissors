using System;

namespace Lab5._2RockPaperScissors
{
      
    class Program
    {
     
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Rock Paper Scissors!");

       
            bool keepPlaying = true;
            
            while(keepPlaying)
            {
                RPSGame rpsgame = new RPSGame();
                rpsgame.RunRPSGame();

                keepPlaying = ContinuePlaying();
                
            }
            
        }

        public static bool ContinuePlaying()
        {
            bool invalidInput = true;

            do
            {
                Console.WriteLine(" Play again ? (y/n) ");
                string userInput = Console.ReadLine().ToLower();


                if (userInput == "y" || userInput == "yes")
                {

                    return true;
                }
                else if (userInput == "n" || userInput == "no")
                {

                    Console.WriteLine("Thank you for playing!");
                    return false;
                }
                else
                {
                    Console.WriteLine("That is not a valid selection");
                }

            } while (invalidInput);

            return true;
        }
    }
}
