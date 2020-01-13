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
        //Constructor
        public Game()
        {
        

        }
        //Member Methods (CAN DO)
        public void Run()
        {
            Instructions();
            GameSettings();
        }
        public void Instructions ()
        {
            Console.WriteLine("Welcome to your simulated game of Rock, Paper, Scissors, Lizard, Spock!\n" +
                "or RPSLS for short. We use this game since the orginal game of RPS, is flawed.\n" +
                "Statistics show that if you know your Opponent, you will pick the same item 75% of the time!\n" +
                "This is solved by adding two varibles. hit ENTER to Learn the additional rule sets!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Rock crushes Scissors\nScossors cuts Paper\nPaper covers Rock\nRock crushes Lizard\nLizard posisons Spock\nSpock smashes Scissors\nScissors decapitates Lizard\nLizard eats Paper\nPaper disproves Spock\nSpock vaporizes Rock\nHit Enter to continue to Game Settings!!");
            Console.ReadLine();
            Console.Clear();
        }
        public void GameSettingValidate()
        {          
            String userDecision = GameSettingB();
            switch (userDecision)
            {
                case "1":
                    player1 = new Human();
                    player2 = new Human();
                    GamePlay();
                    break;
                case "2":
                    player1 = new Human();
                    player2 = new Computer();
                    GamePlay();
                    break;
            }
        }
        public void GameSettings()
        {
            Console.WriteLine("First are you playing against a Computer to let the universe decide...\n" +
                "Or against another player to settle a debate!" +
                "To settle debates in a timely fashion, just use the numbers associated with your choice!");
                GameSettingB();
        }
        public string GameSettingB()
        {
            string userDecision;
            do 
            {
                Console.WriteLine("Please enter 1 or 2:\n" +
              "1: Human versus Computer\n" +
              "2: Human versus Human");
                userDecision = Console.ReadLine();
                Console.Clear();
                if (userDecision != "1" && userDecision != "2")
                {
                    Console.WriteLine("You have entered an invalid option! Please try again!");
                }
            } while (userDecision != "1" && userDecision != "2");
            return userDecision;
        }
        public void GamePlay()
        {
            do
            {
                Console.WriteLine("Player Ones Turn!");
                player1.GestureChoice();
                Console.ReadLine();
                Console.Clear();
                //validations of player 1s choice
                Console.WriteLine("Player Two Turn!");
                player2.GestureChoice();
                Console.ReadLine();
                Console.Clear();
                //validations of player 2s choice
                GestureComparrison();
                
            }
            while (player1.gamePoints < 2 && player2.gamePoints < 2);
            GameDecision();
        }
        public void GameDecision()
            {
                if (player1.gamePoints == 2)
                {
                    Console.WriteLine("Congradulations! Player One you Win!");
                    //Restart game or end game choice
                }
                else if (player2.gamePoints == 2)
                {
                    Console.WriteLine("Congradulations! Player Two you Win!");
                    //Restart game or end game choice
                }
            } 
        public void GestureComparrison()
        {
            if (player1.chosenGesture == "1")
            {
                if (player2.chosenGesture == "1")
                {
                    Console.WriteLine("Both Players picked Rock. No points Awarded!");
                }
                else if (player2.chosenGesture == "4" || player2.chosenGesture == "3")
                {
                    Console.WriteLine("Player 1 gains a point, just one more to win it all!");
                    player1.gamePoints++;
                }
                else if (player2.chosenGesture == "5" || player2.chosenGesture == "2")
                {
                    Console.WriteLine("Player 2 gains a point, just one more to win it all!");
                    player2.gamePoints++;
                }
            }
            else if (player1.chosenGesture == "2")
            {
                if (player2.chosenGesture == "2")
                {
                    Console.WriteLine("Both Players picked Rock. No points Awarded!");
                }
                else if (player2.chosenGesture == "1" || player2.chosenGesture == "5")
                {
                    Console.WriteLine("Player 1 gains a point, just one more to win it all!");
                    player1.gamePoints++;
                }
                else if (player2.chosenGesture == "4" || player2.chosenGesture == "3")
                {
                    Console.WriteLine("Player 2 gains a point, just one more to win it all!");
                    player2.gamePoints++;
                }
            }
            else if (player1.chosenGesture == "3")
            {
                if (player2.chosenGesture == "3")
                {
                    Console.WriteLine("Both Players picked Rock. No points Awarded!");
                }
                else if (player2.chosenGesture == "2" || player2.chosenGesture == "4")
                {
                    Console.WriteLine("Player 1 gains a point, just one more to win it all!");
                    player1.gamePoints++;
                }
                else if (player2.chosenGesture == "5" || player2.chosenGesture == "1")
                {
                    Console.WriteLine("Player 2 gains a point, just one more to win it all!");
                    player2.gamePoints++;
                }
            }
            else if (player1.chosenGesture == "4")
            {
                if (player2.chosenGesture == "3")
                {
                    Console.WriteLine("Both Players picked Rock. No points Awarded!");
                }
                else if (player2.chosenGesture == "5" || player2.chosenGesture == "2")
                {
                    Console.WriteLine("Player 1 gains a point, just one more to win it all!");
                    player1.gamePoints++;
                }
                else if (player2.chosenGesture == "1" || player2.chosenGesture == "3")
                {
                    Console.WriteLine("Player 2 gains a point, just one more to win it all!");
                    player2.gamePoints++;
                }
            }
            else if (player1.chosenGesture == "5")
            {
                if (player2.chosenGesture == "5")
                {
                    Console.WriteLine("Both Players picked Rock. No points Awarded!");
                }
                else if (player2.chosenGesture == "1" || player2.chosenGesture == "3")
                {
                    Console.WriteLine("Player 1 gains a point, just one more to win it all!");
                    player1.gamePoints++;
                }
                else if (player2.chosenGesture == "2" || player2.chosenGesture == "4")
                {
                    Console.WriteLine("Player 2 gains a point, just one more to win it all!");
                    player2.gamePoints++;
                }
            }
        }
    }
}
