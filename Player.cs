using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_2
{
    abstract class Player
    {
        protected string name;
        protected string rpsChoice;

        protected static Random random;

        protected string Name { get => name; set => name = value; }
        protected string RpsChoice { get => rpsChoice; set => rpsChoice = value; }

        protected Player(string name)
        {
            this.name = name;
            if (random == null)
            {
                random = new Random();
            }
        }

        public abstract void GenerateRoshambo();




    }
}
