using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockSpock
{
    class RobotPlayer : Player
    {
       Random random = new Random();
       public int score; 
 

        public override int MovePicker()
        {
            int robotMove = random.Next(0, 4);
            return robotMove;
        }

     

    }
}
