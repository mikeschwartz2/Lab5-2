using System;
using System.Collections.Generic;

namespace Lab5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerChoice;
            int playerWin = 0;
            int opponentWin = 0;

            List<Player> playerList = new List<Player>();
            playerList.Add(new TheRock("The Rock"));
            playerList.Add(new RandomPlayer("Random Dude"));

            Console.Write("Please enter your name: ");
            playerList.Add(new Human(Console.ReadLine()));
            Console.WriteLine($"Would you like to play against The Rock or Random Dude");
            playerChoice = Console.ReadLine();

            string rerun = "";
            do
            {
                foreach (Player p in playerList)
                {
                    p.GenerateRoshambo();
                    //Console.WriteLine(p);
                }

                Console.WriteLine("===================================");
                Roshambo(playerChoice, playerList);

                rerun = Rerun(rerun);
            }
            while (rerun == "y");
        }

        static void Roshambo(string playerChoice, List<Player> playerList)
        {
            if (playerChoice == "The Rock")
            {
                Console.WriteLine("Hey you are playing The Rock");
                Console.WriteLine($"The Rock selected: \t{playerList[0]}");
                Console.WriteLine($"You Selected: \t\t{playerList[2]}");

                string outCome = OutCome(playerList[2].ToString(), playerList[0].ToString());
                Console.WriteLine($"{outCome}");

            }
            else if (playerChoice == "Random Dude")
            {
                Console.WriteLine("Hey you are playing some Random Dude");
                Console.WriteLine($"The Rock selected: \t{playerList[1]}");
                Console.WriteLine($"You Selected: \t\t{playerList[2]}");
                string outCome = OutCome(playerList[2].ToString(), playerList[1].ToString());
                Console.WriteLine($"{outCome}");
            }
            else
            {
                Console.WriteLine("You are to dumb to play this game. That was not a valid player");
            }
        }

        static string OutCome(string player1, string player2)
        {
            string outCome;

            if (player1 == "rock")
            {
                if (player2 == "scissors")
                {
                    outCome = "You Win!";
                }
                else if (player2 == "paper")
                {
                    outCome = "You Lose!";
                }
                else
                {
                    outCome = "It is a draw!";
                }
            }
            else if (player1 == "paper")
            {
                if (player2 == "rock")
                {
                    outCome = "You Win!";
                }
                else if (player2 == "scissors")
                {
                    outCome = "You Lose!";
                }
                else
                {
                    outCome = "It is a draw!";
                }
            }
            else
            {
                if(player2 == "paper")
                {
                    outCome = "You Win!";
                }
                else if (player2 == "rock")
                {
                    outCome = "You Lose!";
                }
                else 
                {
                    outCome = "It is a draw!";
                }
            }
            return outCome;
        }


        static string Rerun(string rerun)
        {
            Console.WriteLine("Would you like to play again? y/n");
            rerun = Console.ReadLine();
            rerun = rerun.ToLower();

            while (rerun != "y" && rerun != "n")
            {
                Console.WriteLine("This is not a valid input. Would you like to play again: y/n");
                rerun = Console.ReadLine();
                rerun = rerun.ToLower();
            }
            return rerun;
        }


    }
}
