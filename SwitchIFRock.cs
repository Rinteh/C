using System;
using System.Transactions;

namespace Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();//creating a random variable to stand in for the computers choice
            bool playAgain = true;
            String player,computer,answer; //establishing the variables 

            while (playAgain)//enables the playagain at the end
            {
                player = "";
                computer = "";
                answer = "";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }


                switch (random.Next(1, 4))//Creating choices for the computer to select from using its random variable
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch (player)//Showing the outcome of each selection made by the player vs computer
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else
                        {
                            Console.WriteLine("You lose!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You win!");
                        }
                        else
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        break;
                }
                
                Console.Write("Would you like to play again (Y/N): ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();//ensures that the answer is always readable

                if (answer == "Y")//Allows the user to select if they wish to play again
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }

            }

            Console.WriteLine("Thanks for playing!");

        
        Console.ReadKey();
        }
    }
}
