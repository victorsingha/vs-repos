using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NO_PLAY = 0;
            const int LADDER = 1;
            const int SNAKE = 2;
            int TARGET = 100;
            int dicePlayed = 0;
            int playerNo = 1;

            int currentScoreP1 = 0;
            int currentScoreP2 = 0;
            Random random = new Random();
            while (currentScoreP1 != TARGET && currentScoreP2 != TARGET)
            {
                dicePlayed++;
                Console.WriteLine("Player "+playerNo+" turn");
                int diceResult = random.Next(0, 6) + 1;
                int option = random.Next(0, 3);
                switch (option)
                {
                    case NO_PLAY:
                        Console.WriteLine("NO PLAY");
                        if (playerNo == 1) playerNo = 2;
                        else playerNo = 1;
                        

                        break;
                    case LADDER:
                        Console.WriteLine("LADDER");
                        if (playerNo == 1)
                        {
                            currentScoreP1 = currentScoreP1 + diceResult;
                            if (currentScoreP1 > 100)
                            {
                                currentScoreP1 = currentScoreP1 - diceResult;
                            }
                        }
                        else
                        {
                            currentScoreP2 = currentScoreP2 + diceResult;
                            if (currentScoreP2 > 100)
                            {
                                currentScoreP2 = currentScoreP2 - diceResult;
                            }
                        }                    
                        break;
                    case SNAKE:
                        Console.WriteLine("SNAKE");
                        if (playerNo == 1)
                        {
                            currentScoreP1 = currentScoreP1 - diceResult;
                            if (currentScoreP1 < 0)
                            {
                                currentScoreP1 = 0;
                            }
                            playerNo = 2;
                        }
                        else
                        {
                            currentScoreP2 = currentScoreP2 - diceResult;
                            if (currentScoreP2 < 0)
                            {
                                currentScoreP2 = 0;
                            }
                            playerNo = 1;
                        }
                        break;
                }
                Console.WriteLine("Dice Result: " + diceResult);
                Console.WriteLine("P1 Score: "+currentScoreP1);
                Console.WriteLine("P2 Score: "+currentScoreP2);
                Console.WriteLine("________________");
            }
            Console.WriteLine("Total Dice Playerd: "+dicePlayed);
            if(currentScoreP1>currentScoreP2) Console.WriteLine("P1 Wins :)");
            else Console.WriteLine("P2 Wins :)");
            Console.ReadKey();
        }
    }
}
