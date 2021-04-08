using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._2RockPaperScissors
{
    class TheSharks : Player
    {
        public override RoShamBo GenerateRoshambo()
        {
            Random rnd = new Random();

           int roshamboValue = rnd.Next(0, 3);

            return (RoShamBo)roshamboValue;
            
            // C# generate enum 
            // Enum.TryParse<RoShamBo>(roshamboValue.ToString(), out RoShamBo roshamboChoice);


        }
    }
}
