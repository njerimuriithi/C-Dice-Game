using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicegame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints=0;
            int enemyPoints=0;


            Random random = new Random();

            for(int i=0 ;i<10;i++ )
            {
                Console.WriteLine("press any key to roll the dice");

                Console.ReadKey();
                playerRandomNum = random.Next(1,7);
                Console.WriteLine($"you rolled a {playerRandomNum}");

                Console.ReadKey();
                enemyRandomNum = random.Next(1,7);
                 Console.WriteLine($"enemy rolled a {enemyRandomNum}");

                if (playerRandomNum > enemyRandomNum)
                {
                    playerPoints ++;
                }else if(enemyRandomNum >playerRandomNum)
                    {
                    enemyPoints++;
                }
                else
                {
                    Console.WriteLine("Draw");
                }

                if(playerPoints > enemyPoints)
                {
                    Console.WriteLine("You win");
                }else if (playerPoints < enemyPoints)
                {
                    Console.WriteLine("You loose");
                }
                else
                {
                    Console.WriteLine("draw");
                }

            }

            Console.ReadLine();

        }
    }
}
