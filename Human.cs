using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_2
{
    class Human : Player
    {
        public Human(string name)
            : base(name)
        {
            //GenerateRoshambo();
        }

        public override void GenerateRoshambo()
        {
            Console.Write("Please enter Rock, Paper, Or Scissors: ");
            rpsChoice = Console.ReadLine().ToLower();

        }

        public override string ToString()
        {
            return $"{rpsChoice}";
        }

    }
}
