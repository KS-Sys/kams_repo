using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    internal class Program
    {
        public static float Board_number;
        public static char[,] DebugBoard = new char[3,3];
        public static char player_token = 'X';
        public static char opponent_token = 'O';
        static void Main(string[] args)
        {

            int selection = 0;
            Console.WriteLine("welcome to tic tac toe" + "\n" + "Please choose the player options below");
            Console.WriteLine("1 - Player 1 game" + "\n" + "2 - Player 2 game" + "\n" + "3 - Debug Board");

            string s = Console.ReadLine();
            selection = int.Parse(s);

            switch (selection)
            {
                case 1:
                    Play_Game();
                    break;
                case 2:
                    break;
                case 3:
                    Call_Board();
                    break;
            }
        }

        /// <summary>
        /// this method will be the one that will execute the main game
        /// </summary>
        private static void Play_Game()
        {
            int token_num;
            string token_text;
            Call_Board();
            Console.WriteLine("enter number where you would like to add your token");
            token_text = Console.ReadLine();
            token_num = int.Parse(token_text);

            switch (token_num)
            {
                case 1:
                    DebugBoard[0,0] = player_token; 
                    break;
                case 2:
                    DebugBoard[0,1] = player_token;
                    break;
                case 3:
                    DebugBoard[0,2] = player_token;
                    break;
                case 4:
                    DebugBoard[1,0] = player_token;
                    break;
                case 5:
                    DebugBoard[1,1] = player_token;
                    break;
                case 6:
                    DebugBoard[1, 2] = player_token;
                    break;
                case 7:
                    DebugBoard[2, 0] = player_token;
                    break;
                case 8:
                    DebugBoard[2, 1] = player_token;
                    break;
                case 9:
                    DebugBoard[2, 2] = player_token;
                    break;
            }

        }
        /// <summary>
        /// Private methods should be sufficent for now as the code is accessible in the same class
        /// the method is running static so it does not need to be called as a object in current state 
        /// </summary>
        private static void Call_Board()
        {
            for(int y = 0; y < 3; y++)
            {
                for(int x = 0; x < 3; x++)
                {
                    Console.Write("[" + DebugBoard[y, x] + "]");
                }
                Console.Write("\n");
            }
        }

        /// <summary>
        /// Method for simple token selection for X or O
        /// I am planning to change this to custom tokens when possible
        /// </summary>
        /// <param name="Player_1"></param>
        private static void Token(string Player_1)
        {
            Console.WriteLine("Choose O or X");
            Player_1 = Console.ReadLine();

            if (Player_1 == "X")
            {
                Board_number = 1.1f;
                return;
            }
            else if (Player_1 == "0")
            {
                Board_number = 1.2f;
                return;
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
