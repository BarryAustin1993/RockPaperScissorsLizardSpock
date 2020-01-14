using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Computer : Player
    {
        //Member Variables (HAS A)

        //Constructor
        public List<string> Gestures = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        public List<string> Names = new List<string>() { "Paul", "Nevin", "Mike", "Micheal", "David", "Brett", "Flamingo"};
        //Member Methods (CAN DO)
        public override void GestureChoice()
        {
            Random random = new Random();
            chosenGesture = Gestures[random.Next(5)].ToLower();
            Console.WriteLine("The Computer has chosen " + chosenGesture + "\nPress Enter to go to next round");
            Console.ReadLine();
        }
        public override void NameChoice()
        {
            Random random = new Random();
            userName = Names[random.Next(7)];
        }
    }
}
