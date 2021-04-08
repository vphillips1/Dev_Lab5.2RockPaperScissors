using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._2RockPaperScissors
{
    class RPSGame
    {
       
        public void RunRPSGame()
        {

            bool invalidSelection = true;


            Console.Write("Enter your name:");
            HumanPlayer humanPlayer = new HumanPlayer(Console.ReadLine());

            while (invalidSelection)
            {
                Console.Write("Would you like to play against TheJets or TheSharks (j/s)?:");
                string playingAgainst = Console.ReadLine().ToLower();

               if(TeamChoice(playingAgainst))
               {
                  invalidSelection = false;
                  bool invalidRPSGame = true;

                    while (invalidRPSGame)
                    {
                        //HumanPlayer humanPlayer = new HumanPlayer();
                        //humanPlayer.playerName = userName;
                        humanPlayer.roshambo = humanPlayer.GenerateRoshambo();



                        if (playingAgainst == "j" || playingAgainst == "J" || playingAgainst == "TheJets" || playingAgainst == "the jets" || playingAgainst == "jets" || playingAgainst == "thejets")
                        {

                            TheJets jets = new TheJets();
                            jets.playerName = "The Jets";
                            jets.roshamboValue = jets.GenerateRoshambo();

                            Console.WriteLine($"{humanPlayer.name}: {humanPlayer.roshamboValue}");
                            Console.WriteLine($"{jets.playerName}: {jets.roshamboValue}");

                            if(humanPlayer.roshamboValue.Equals(RoShamBo.scissor))
                            {

                                Console.WriteLine($"{jets.playerName} Wins");
                            }
                            else if (humanPlayer.roshamboValue.Equals(RoShamBo.paper))
                            {
                                Console.WriteLine($"{humanPlayer.name} Wins");
                            }
                            else
                            {

                                Console.WriteLine("Draw");
                            }
                            break;
                        }
                        else if (playingAgainst == "s" || playingAgainst == "S" || playingAgainst == "TheSharks" || playingAgainst == "the sharks" || playingAgainst == "sharks" || playingAgainst == "thesharks")
                        {
                            TheSharks sharks = new TheSharks();
                            sharks.playerName = "The Sharks";
                            sharks.roshamboValue = sharks.GenerateRoshambo();

                            Console.WriteLine($"{humanPlayer.name}: {humanPlayer.roshamboValue}");
                            Console.WriteLine($"{sharks.playerName}: {sharks.roshamboValue}");

                            if (humanPlayer.roshamboValue.Equals(RoShamBo.scissor))
                            {
                                if (sharks.roshamboValue == RoShamBo.rock)
                                {
                                    Console.WriteLine($"{sharks.playerName} Wins");

                                }else if (sharks.roshamboValue == RoShamBo.paper)
                                {

                                    Console.WriteLine($"{humanPlayer.name} Wins");
                                }
                                else if(sharks.roshamboValue == RoShamBo.scissor)
                                {

                                    Console.WriteLine("Draw");
                                }
                                else
                                {

                                    Console.WriteLine("Wrong selection was made");
                                }

                                
                            }
                            else if (humanPlayer.roshamboValue.Equals(RoShamBo.paper))
                            {

                                if(sharks.roshamboValue == RoShamBo.paper)
                                {
                                    Console.WriteLine("Draw");
                                }
                                else if(sharks.roshamboValue == RoShamBo.scissor)
                                {
                                    Console.WriteLine($"{sharks.playerName} Wins");

                                }
                                else if(sharks.roshamboValue == RoShamBo.rock)
                                {

                                    Console.WriteLine($"{humanPlayer.name} Wins");
                                }
                                else
                                {

                                    Console.WriteLine("Wrong selection was made");
                                }
                               
                                
                            }
                            else if(humanPlayer.roshamboValue.Equals(RoShamBo.rock))
                            {
                                if (sharks.roshamboValue == RoShamBo.paper)
                                {
                                    Console.WriteLine($"{sharks.playerName} Wins");
                                }
                                else if (sharks.roshamboValue == RoShamBo.scissor)
                                {
                                    Console.WriteLine($"{humanPlayer.name} Wins");

                                }
                                else if (sharks.roshamboValue == RoShamBo.rock)
                                {

                                    Console.WriteLine($"Draw");
                                }
                                else
                                {

                                    Console.WriteLine("Wrong selection was made");
                                }

                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Wrong selection was made. Please try again");
                            continue;
                        }

                    }

               }


            }


        }


        public bool TeamChoice(string userSelection)
        {
            if (userSelection == "j" || userSelection == "J" || userSelection == "TheJets" || userSelection == "the jets" || userSelection == "thejets" || userSelection == "jets" || userSelection == "s" || userSelection == "S" || userSelection == "TheSharks" || userSelection == "the sharks" || userSelection == "sharks" || userSelection == "thesharks")
            {
                return true;

            }

            else
            {
                Console.WriteLine("This is not a valid choice. Please try again");
                return false;

            }

        }

    }

}
