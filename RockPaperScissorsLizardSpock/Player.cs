 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public abstract class Player
    {
        //Member Variables (HAS A)
        public string chosenGesture;
        public int gamePoints;
       




        //Constructor
        public Player()
        {
            gamePoints = 0;

        }


        //Member Methods (CAN DO)
        public abstract void GestureChoice();
       

    }
}
