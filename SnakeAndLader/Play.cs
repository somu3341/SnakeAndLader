using System;
using System.Security.Cryptography.X509Certificates;

namespace SnakeAndLader
{
    public class Play
    {
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING_POSITION = 100;
        int PlayerPosition = 0;
        Random random = new Random();
        public int DieRoll()
        {
            int die = random.Next(1, 7);
            return die;
        }
        public int GamePlay()
        {
            while (this.PlayerPosition < WINNING_POSITION)
            {
                int option = random.Next(0, 3);
                switch (option)
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                        this.PlayerPosition += DieRoll();
                        break;
                    case SNAKE:
                        int dieRoll = DieRoll();
                        if (this.PlayerPosition - dieRoll > 0)
                            this.PlayerPosition -= dieRoll;
                        else
                            this.PlayerPosition = 0;
                        break;
                }
                Console.WriteLine("Player position  " + PlayerPosition);
            }
            return this.PlayerPosition;
            if (this.PlayerPosition == WINNING_POSITION)
            {
                Console.WriteLine("Player position  " + PlayerPosition);
            }
        }public void winner(int p1, int p2)
        {
            if (p1 == 100)
            {
                Console.WriteLine("Player1 is winner");
            }
            else
            {
                Console.WriteLine("Player2 is winner");
            }
        }
    }
}