using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class Program
    {
        private static bool board;

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
        
           
        
        public static void  Display()
        {
            char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);

            Console.WriteLine("     |     |      ");
        }
        
        static void Main(string[] args)
        {
            Program.Initializing();
            char[] board = Initializing();
            char letter = Choosing();
            Console.WriteLine(letter);
            Program.Display();
            Console.ReadLine();
        }
    }
}
