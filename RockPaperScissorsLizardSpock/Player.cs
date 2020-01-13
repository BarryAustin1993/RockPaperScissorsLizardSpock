 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    abstract class Player
    {
        //Member Variables (HAS A)

        public List<string> Gestures = new List<string>() { "1", "2", "3", "4", "5" };




        //Constructor

        //Member Methods (CAN DO)
        protected abstract void GestureChoice();
       

    }
}
