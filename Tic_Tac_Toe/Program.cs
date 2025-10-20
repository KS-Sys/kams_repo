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
        public static char x_Token = 'X';
        public static char o_Token = 'O';
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
                    do
                    {
                        Board_scan();
                        Play_Game();
                        ai_Opponent();
                    } while (Board_scan() == false);
                    Call_Board();
                    break;
                case 2:
                    break;
                case 3:
                    Call_Board();
                    break;
            }
        }

        private static void ai_Opponent()
        {
            Random tM = new Random();
            int token_num = tM.Next(1, 9); 
            switch (token_num)
            {
                case 1:
                    DebugBoard[0, 0] = o_Token;
                    break;
                case 2:
                    DebugBoard[0, 1] = o_Token;
                    break;
                case 3:
                    DebugBoard[0, 2] = o_Token;
                    break;
                case 4:
                    DebugBoard[1, 0] = o_Token;
                    break;
                case 5:
                    DebugBoard[1, 1] = o_Token;
                    break;
                case 6:
                    DebugBoard[1, 2] = o_Token;
                    break;
                case 7:
                    DebugBoard[2, 0] = o_Token;
                    break;
                case 8:
                    DebugBoard[2, 1] = o_Token;
                    break;
                case 9:
                    DebugBoard[2, 2] = o_Token;
                    break;
            }
        }
        /// <summary>
        /// the method below scans the board if any of the tokens match to make a row.
        /// the method only works for the X token at the moment.
        /// </summary>
        /// <returns></returns>
        private static bool Board_scan()
        {
            // player tokens vertical
            if (DebugBoard[0, 0] == x_Token && DebugBoard[0, 1] == x_Token && DebugBoard[0, 2] == x_Token)
            {
                Console.WriteLine("you won the game");
                return true;
            }
            if (DebugBoard[1, 0] == x_Token && DebugBoard[1, 1] == x_Token && DebugBoard[1, 2] == x_Token)
            {
                Console.WriteLine("you won the game");
                return true;
            }
            if (DebugBoard[2, 0] == x_Token && DebugBoard[2, 1] == x_Token && DebugBoard[2, 2] == x_Token)
            {
                Console.WriteLine("you won the game");
                return true;
            }
            // player tokens horizontal
            if (DebugBoard[0, 0] == x_Token && DebugBoard[1, 0] == x_Token && DebugBoard[2, 0] == x_Token)
            {
                Console.WriteLine("you won the game");
                return true;
            }
            if (DebugBoard[0, 1] == x_Token && DebugBoard[1, 1] == x_Token && DebugBoard[2, 1] == x_Token)
            {
                Console.WriteLine("you won the game");
                return true;
            }
            if (DebugBoard[0, 2] == x_Token && DebugBoard[1, 2] == x_Token && DebugBoard[2, 2] == x_Token)
            {
                Console.WriteLine("you won the game");
                return true;
            }
            // player tokens diagonal
            if (DebugBoard[0, 0] == x_Token && DebugBoard[1, 1] == x_Token && DebugBoard[2, 2] == x_Token)
            {
                Console.WriteLine("you won the game");
                return true;
            }
            if (DebugBoard[0, 2] == x_Token && DebugBoard[1, 1] == x_Token && DebugBoard[2, 0] == x_Token)
            {
                Console.WriteLine("you won the game");
                return true;
            }
            return false;
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
                    DebugBoard[0,0] = x_Token; 
                    break;
                case 2:
                    DebugBoard[0,1] = x_Token;
                    break;
                case 3:
                    DebugBoard[0,2] = x_Token;
                    break;
                case 4:
                    DebugBoard[1,0] = x_Token;
                    break;
                case 5:
                    DebugBoard[1,1] = x_Token;
                    break;
                case 6:
                    DebugBoard[1, 2] = x_Token;
                    break;
                case 7:
                    DebugBoard[2, 0] = x_Token;
                    break;
                case 8:
                    DebugBoard[2, 1] = x_Token;
                    break;
                case 9:
                    DebugBoard[2, 2] = x_Token;
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
