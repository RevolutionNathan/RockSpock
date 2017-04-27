using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockSpock
{
    class Menu
    {
        
        public string nPlayers;
        //public string humanMovePick;
        public void PromptMenuOptions()
        {
            Console.WriteLine("Menu Options: Hit 1 for One Player, 2 for Two Player");
        }
        
        public string StoreMenuChoice()
        {
            nPlayers = Console.ReadLine();
            return nPlayers;
        }

        public void ChoseOnePlayerMessage()
        {
            Console.WriteLine("You picked to play the computer.");
        }

        public void choseTwoPlayerMessage()
        {
            Console.WriteLine("Yay! You have a friend to play with.");
        }
        public string MenuOptions()
        {
            PromptMenuOptions();
            StoreMenuChoice();
            switch (nPlayers)
            {
                case "1":
                    ChoseOnePlayerMessage();
                    return nPlayers;
                   
                case "2":
                    choseTwoPlayerMessage();
                    return nPlayers;
                   
                default:
                    return MenuOptions();
                    break;
            }
        }

       


        //
    }
}
