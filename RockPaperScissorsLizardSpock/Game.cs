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
                    OnePlayerGame();
                    break;
                case "2":
                    TwoPlayerGame();
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
                if (userDecision != "1" && userDecision != "2") ;
                {
                    Console.WriteLine("You have entered an invalid option! Please try again!");
                }
            } while (userDecision != "1" && userDecision != "2");
            return userDecision;
        }
        public void OnePlayerGame()
        {

        }
        public void TwoPlayerGame()
        {

        }
    }
}
