using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class Program
    {

        public static char[]  Initializing()
        {
            char[] board = new char[10];
            for (int i=0;i<board.Length;i++)
            {
                board[i] =' ';
                
            }
            return board;
            
        }

        public static char Choosing()
        {
            Console.WriteLine("choose option:");
            string letter = Console.ReadLine();
            return char.ToUpper(letter[0]);
        }
        
           
        
        public static void  Display(char[] board)
        {
            
            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", board[1], board[2], board[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", board[4], board[5], board[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", board[7], board[8], board[9]);

            Console.WriteLine("     |     |      ");
        }
        
        static void Main(string[] args)
        {
            Program.Initializing();
            char[] board = Initializing();
            char letter = Choosing();
            Console.WriteLine(letter);
            Program.Display(board);
            Console.ReadLine();
        }

       
    }
}
