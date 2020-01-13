using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Human : Player
    {
        //Member Variables (HAS A)

        //Constructor

        //Member Methods (CAN DO)
        protected override void GestureChoice()
        {
            Console.WriteLine("Please choose an option:\n1: Rock\n2: Paper\n3: Scissors\n4: Lizzard\n5: Spock");
            string userdecision = Console.ReadLine();
           
        }

    }
}
