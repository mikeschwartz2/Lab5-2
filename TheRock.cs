using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_2
{
    class TheRock : Player
    {
        public TheRock(string name)
            : base(name)
        {
            //GenerateRoshambo();
        }

        public override void GenerateRoshambo()
        {
            rpsChoice = "rock";
        }

        public override string ToString()
        {
            return $"{rpsChoice}";
        }


    }
}
