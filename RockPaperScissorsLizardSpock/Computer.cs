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
        public List<string> Gestures = new List<string>() { "1", "2", "3", "4", "5" };

        //Member Methods (CAN DO)
        public override void GestureChoice()
        {
            Random random = new Random();
            chosenGesture = Gestures[random.Next(5)];
        }

    }
}
