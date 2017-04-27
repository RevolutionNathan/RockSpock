using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockSpock
{
    
    class HumanPlayer : Player
    {
        public int humanScore;
        public string humanMove;
        public int humanMovePick;
        public int score;

        public void PickHumanMovePrompt()
        {
            Console.WriteLine("Pick your move --> 0: Scissors; 1: Rock; 2: Paper; 3: Lizard; 4: Spock.");
        }

        public override int MovePicker()
        {
            PickHumanMovePrompt();
            humanMove = Console.ReadLine();
            int humanMovePick = int.Parse(humanMove);
            switch(humanMovePick) 
            {
                case 0:
                    return humanMovePick;
                    break;
                case 1:
                    return humanMovePick;
                    break;
                case 2:
                    return humanMovePick;
                    break;
                case 3:
                    return humanMovePick;
                    break;
                case 4:
                    return humanMovePick;
                    break;
                default: 
                    Console.Write("You must pick a number between 0 and 4.");
                    return MovePicker();
                    break; 
            }
        }
      
    } 


}
