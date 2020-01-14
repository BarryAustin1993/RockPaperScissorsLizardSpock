using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Human : Player
    {
        //Member Variables (HAS A)

        //Constructor

        //Member Methods (CAN DO)
        public override void GestureChoice()
        {
            Console.WriteLine("Please choose an option:\n1: Rock\n2: Paper\n3: Scissors\n4: Lizzard\n5: Spock");
            switch (Console.ReadLine().ToLower())
            {
                case "1":
                case "rock":
                    chosenGesture = "rock";
                    break;
                case "2":
                case "paper":
                    chosenGesture = "paper";
                    break;
                case "3":
                case "scissors":
                    chosenGesture = "scissors";
                    break;
                case "4":
                case "lizard":
                    chosenGesture = "lizard";
                    break;
                case "5":
                case "spock":
                    chosenGesture = "spock";
                    break;
                default:
                    Console.WriteLine("Invalid Choice, Go Agian");
                    GestureChoice();
                    break;
            }            
         
        }

    }
}
