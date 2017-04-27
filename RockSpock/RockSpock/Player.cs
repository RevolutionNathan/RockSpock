using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockSpock
{
    class Player
    {
        public int move;
        public int score;
        public string name;
        

        public int AddScore()
        {
            score++;
            return score;
        }
        public virtual int MovePicker()
        {
            return 0;
        }
    }
}
