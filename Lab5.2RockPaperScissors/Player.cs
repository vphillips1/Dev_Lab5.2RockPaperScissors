using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._2RockPaperScissors
{
    public abstract class Player
    {
        public string name;
        public RoShamBo roshamboValue;

        public string playerName
        {
            get { return name; }
            set { name = value; }
        }

        public RoShamBo roshambo
        {
            get { return roshamboValue; }
            set { roshamboValue = value; }
        }
        public abstract RoShamBo GenerateRoshambo();
                     

    }

}
