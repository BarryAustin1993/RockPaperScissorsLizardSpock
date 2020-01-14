using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        //Member Variables (HAS A)
        public Human player1;
        public Player player2;
        public int victoryPoints;
        //Constructor
        public Game()
        {


        }
        //Member Methods (CAN DO)
        public void Run()
        {
            Instructions();
            PlayerSettings();
            PlayerNames();
            DetermineRounds();
            GamePlay();
            GameDecision();
        }
        public void Instructions()
        {
            Console.WriteLine("Welcome to your simulated game of Rock, Paper, Scissors, Lizard, Spock!\n" +
                "or RPSLS for short. We use this game since the orginal game of RPS, is flawed.\n" +
                "Statistics show that if you know your Opponent, you will pick the same item 75% of the time!\n" +
                "This is solved by adding two varibles.\n\nHit ENTER to Learn the additional rule sets!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Rock crushes Scissors\nScossors cuts Paper\nPaper covers Rock\nRock crushes Lizard\nLizard posisons Spock\nSpock smashes Scissors\nScissors decapitates Lizard\nLizard eats Paper\nPaper disproves Spock\nSpock vaporizes Rock\n\nHit Enter to continue to Game Set Up!!");
            Console.ReadLine();
            Console.Clear();
        }
        public void TypeOfPlayersDefined(String userDecision)
        {
            Console.Clear();
            switch (userDecision)
            {
                case "1":
                    player1 = new Human();
                    player2 = new Computer();
                    break;
                case "2":
                    player1 = new Human();
                    player2 = new Human();
                    break;
            }
        }
        public void PlayerSettings()
        {
            string userDecision;

            Console.WriteLine("First are you playing against a Computer to let the universe decide...\n" +
                "Or against another player to settle a debate!\n" +
                "To settle debates in a timely fashion, just use the numbers associated with your choice!\n\nHit Enter to go to next menu.");
            Console.ReadLine();

            Console.WriteLine("Please enter 1 or 2:\n" +
          "1: One Player\n" +
          "2: Two Player");
            switch (Console.ReadLine().ToLower())
            {
                case "1":
                case "one":
                case "one player":
                    userDecision = "1";
                    TypeOfPlayersDefined(userDecision);
                    break;
                case "2":
                case "two":
                case "two player":
                    userDecision = "2";
                    TypeOfPlayersDefined(userDecision);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Not a valid option, Please try again!");
                    PlayerSettings();
                    break;
            }
        }
        public void PlayerNames()
        {
            player1.NameChoice();
            player2.NameChoice();
        }
        public void DetermineRounds()
        {
            Console.WriteLine("How many points, does a player need to become victorious!");
            string userInput = Console.ReadLine();
            bool success = Int32.TryParse(userInput, out victoryPoints);
            if (success)
            {
                victoryPoints = Convert.ToInt32(userInput);
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please enter number such as 1,2,3, ect");
                DetermineRounds();
            }
            
        }
        public void GamePlay()
        {
            do
            {
                Console.WriteLine(player1.userName + ": " + player1.gamePoints + "     " + player2.userName + ": " + player2.gamePoints + "\n\n" +
                    player1.userName + "'s Turn!");
                player1.GestureChoice();
                Console.Clear();
                Console.WriteLine(player1.userName + ": " + player1.gamePoints + "     " + player2.userName + ": " + player2.gamePoints + "\n\n" +
                   player2.userName + "'s Turn!");
                player2.GestureChoice();
                Console.Clear();
                GestureComparrison();

            }
            while (player1.gamePoints != victoryPoints && player2.gamePoints != victoryPoints);
        }
        public void GameDecision()
        {
            if (player1.gamePoints == victoryPoints)
            {
                Console.Clear();
                Console.WriteLine("Congradulations! " + player1.userName + " you Win!");
                Console.ReadLine();
                //Restart game or end game choice
            }
            else if (player2.gamePoints == victoryPoints)
            {
                Console.Clear();
                Console.WriteLine("Congradulations! " + player2.userName + " Two you Win!");
                Console.ReadLine();
                //Restart game or end game choice
            }
        }
        public void GestureComparrison()
        {
            if (player1.chosenGesture == "rock")
            {
                if (player2.chosenGesture == "rock")
                {
                    Console.WriteLine("Both Players picked Rock. No points Awarded!");
                }
                else if (player2.chosenGesture == "lizard" || player2.chosenGesture == "scissors")
                {
                    Console.WriteLine(player1.userName + " picked " + player1.chosenGesture + ", and " + player2.userName + " picked " + player2.chosenGesture + "!\n" + player1.userName + " won that round!");
                    player1.gamePoints++;
                }
                else if (player2.chosenGesture == "spock" || player2.chosenGesture == "paper")
                {
                    Console.WriteLine(player1.userName + " picked " + player1.chosenGesture + ", and " + player2.userName + " picked " + player2.chosenGesture + "!\n" + player2.userName + " won that round!");
                    player2.gamePoints++;
                }
            }
            else if (player1.chosenGesture == "paper")
            {
                if (player2.chosenGesture == "paper")
                {
                    Console.WriteLine("Both Players picked Paper. No points Awarded!");
                }
                else if (player2.chosenGesture == "rock" || player2.chosenGesture == "spock")
                {
                    Console.WriteLine(player1.userName + " picked " + player1.chosenGesture + ", and " + player2.userName + " picked " + player2.chosenGesture + "!\n" + player1.userName + " won that round!");
                    player1.gamePoints++;
                }
                else if (player2.chosenGesture == "lizard" || player2.chosenGesture == "scissors")
                {
                    Console.WriteLine(player1.userName + " picked " + player1.chosenGesture + ", and " + player2.userName + " picked " + player2.chosenGesture + "!\n" + player2.userName + " won that round!");
                    player2.gamePoints++;
                }
            }
            else if (player1.chosenGesture == "scissors")
            {
                if (player2.chosenGesture == "scissors")
                {
                    Console.WriteLine("Both Players picked scissors. No points Awarded!");
                }
                else if (player2.chosenGesture == "paper" || player2.chosenGesture == "lizard")
                {
                    Console.WriteLine(player1.userName + " picked " + player1.chosenGesture + ", and " + player2.userName + " picked " + player2.chosenGesture + "!\n" + player1.userName + " won that round!");
                    player1.gamePoints++;
                }
                else if (player2.chosenGesture == "spock" || player2.chosenGesture == "rock")
                {
                    Console.WriteLine(player1.userName + " picked " + player1.chosenGesture + ", and " + player2.userName + " picked " + player2.chosenGesture + "!\n" + player2.userName + " won that round!");
                    player2.gamePoints++;
                }
            }
            else if (player1.chosenGesture == "lizard")
            {
                if (player2.chosenGesture == "lizard")
                {
                    Console.WriteLine("Both Players picked Lizard. No points Awarded!");
                }
                else if (player2.chosenGesture == "spock" || player2.chosenGesture == "paper")
                {
                    Console.WriteLine(player1.userName + " picked " + player1.chosenGesture + ", and " + player2.userName + " picked " + player2.chosenGesture + "!\n" + player1.userName + " won that round!");
                    player1.gamePoints++;
                }
                else if (player2.chosenGesture == "rock" || player2.chosenGesture == "scissors")
                {
                    Console.WriteLine(player1.userName + " picked " + player1.chosenGesture + ", and " + player2.userName + " picked " + player2.chosenGesture + "!\n" + player2.userName + " won that round!");
                    player2.gamePoints++;
                }
            }
            else if (player1.chosenGesture == "spock")
            {
                if (player2.chosenGesture == "spock")
                {
                    Console.WriteLine("Both Players picked Spock. No points Awarded!");
                }
                else if (player2.chosenGesture == "rock" || player2.chosenGesture == "scissors")
                {
                    Console.WriteLine(player1.userName + " picked " + player1.chosenGesture + ", and " + player2.userName + " picked " + player2.chosenGesture + "!\n" + player1.userName + " won that round!");
                    player1.gamePoints++;
                }
                else if (player2.chosenGesture == "paper" || player2.chosenGesture == "lizard")
                {
                    Console.WriteLine(player1.userName + " picked " + player1.chosenGesture + ", and " + player2.userName + " picked " + player2.chosenGesture + "!\n" + player2.userName + " won that round!");
                    player2.gamePoints++;
                }
            }
        }
    }
}
