using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockSpock
{
    class Turn
    {

        public List<string> moveNames = new List<string>() { "Scissors", "Rock", "Paper", "Lizard", "Spock" };
        Player playerTwo;
        Player playerOne;
        Menu menu = new Menu();
         
        public void StartGame()
        {
            string nPlayers = menu.MenuOptions();
            switch (nPlayers)
            {
                case "1":
                    HumanVsComp();
                    break;
                case "2":
                    HumanVsHuman();
                    break;
            }

        }
      

        public void HumanVsComp()
        {
            playerOne = new HumanPlayer();
            playerTwo = new RobotPlayer();
            RoundPlay();
        }

        public void HumanVsHuman()
        {
            playerOne = new HumanPlayer();
            playerTwo = new HumanPlayer();
            RoundPlay();
        }

        public void RoundPlay()
        {
            while (playerOne.score < 3 && playerTwo.score < 3)
            {
                playerOne.move = playerOne.MovePicker();
                playerTwo.move = playerTwo.MovePicker();
                int score = ((5 + playerOne.move - playerTwo.move) % 5);
                if (score == 1 || score == 3)
                {
                    playerOne.AddScore();
                    Console.Write("\n{0} beats {1} \n \n", moveNames[playerOne.move], moveNames[playerTwo.move]);
                    Console.Write("Player One Score: " + playerOne.score + "\n" + "Player Two Score: " + playerTwo.score + "\n \n");
                    RoundPlay();
                }
                else if (score == 2 || score == 4)
                {
                    playerTwo.AddScore();
                    Console.Write("\n{1} beats {0} \n \n", moveNames[playerTwo.move], moveNames[playerOne.move]);
                    Console.Write("Player One Score: " + playerOne.score + "\n" + "Player Two Score: " + playerTwo.score + "\n \n");
                    RoundPlay();
                }
                else
                    Console.WriteLine("\nTie \n");
                    Console.Write("Player One Score: " + playerOne.score + "\n" + "Player Two Score: " + playerTwo.score + "\n \n");
                    RoundPlay();
            }
            if (playerOne.score > playerTwo.score)
            {
                Console.WriteLine("Player One Wins! \n");
            }
            else
            {
                Console.WriteLine("Player Two Wins! \n");
            }
            RestartOption();

        }

        public void RestartOption()
        { 
            Console.WriteLine("Do you want to play another round? Yes / No");
            string restart = Console.ReadLine();
            switch(restart)  
            {
                case "yes":
                    StartGame();
                    break;
                case "no":
                    Console.WriteLine("Good Game");
                    break;
                default:
                    RestartOption();
                    break;
            }
        }
    }
}