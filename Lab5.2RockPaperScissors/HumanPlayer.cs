using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._2RockPaperScissors
{
    class HumanPlayer : Player
    {

        public HumanPlayer(string Name)
        {
            name = Name;
        }
        public override RoShamBo GenerateRoshambo()
        {
          
            bool again = true;
            do
            {

                Console.WriteLine("Rock, Paper, or Scissors ? (R/P/S):");
                string userChoice = Console.ReadLine();

                if (validRPSInput(userChoice))
                {


                    if (userChoice.Equals("Rock", StringComparison.OrdinalIgnoreCase) || userChoice.Equals("r", StringComparison.OrdinalIgnoreCase))
                    {

                        return RoShamBo.rock;

                    }
                    else if (userChoice.Equals("Paper", StringComparison.OrdinalIgnoreCase) || userChoice.Equals("p", StringComparison.OrdinalIgnoreCase))
                    {

                        return RoShamBo.paper;

                    }
                    else if (userChoice.Equals("Scissors", StringComparison.OrdinalIgnoreCase) || userChoice.Equals("s", StringComparison.OrdinalIgnoreCase))
                    {
                        return RoShamBo.scissor;

                    }

                }

            } while (again);

            return roshambo;
        }


        private bool validRPSInput(string userSelection)
        {
            if (userSelection.Equals("rock", StringComparison.OrdinalIgnoreCase) || userSelection.Equals("r", StringComparison.OrdinalIgnoreCase) || userSelection.Equals("paper", StringComparison.OrdinalIgnoreCase) || userSelection.Equals("p", StringComparison.OrdinalIgnoreCase) || userSelection.Equals("scissors", StringComparison.OrdinalIgnoreCase) || userSelection.Equals("s", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                Console.WriteLine("That is not a valid selection, please try again");
                return false;
            }
        }


        
    }
}

