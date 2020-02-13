using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_2
{
    class RandomPlayer : Player
    {
        public RandomPlayer(string name)
            : base(name)
        {
            //GenerateRoshambo();
        }

        public override void GenerateRoshambo()
        {
            Roshambo rpsConverter = (Roshambo)random.Next(0,3);
            rpsChoice = rpsConverter.ToString();
        }

        public override string ToString()
        {
            return $"{rpsChoice}";
        }

    }
}
