using System;
using System.Threading;
namespace TicTacToe
{
    class Program
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int choice;
        static int flag = 0;
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Player1:X and Player2:O");
                Console.WriteLine("\n");
                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2");

                }
                else
                {
                    Console.WriteLine("Player 1");
                }
                Console.WriteLine("\n");
                Board();
                choice = int.Parse(Console.ReadLine());
                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        arr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                }
                else
                {
                    Console.WriteLine("Desculpe, a linha {0} já está marcada com {1}", choice, arr[choice]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Por favor espere 2 segundos, o quadro está carregando novamente...");
                    Thread.Sleep(2000);
                }
                flag = CheckWin();
            }
            while (flag != 1 && flag != -1);
            Console.Clear();
            Board();
            if  (flag == 1)
            {
                Console.WriteLine("Player {0} venceu,"(player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }
        private static void Board()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }


    }




}
