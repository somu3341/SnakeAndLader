using System;
namespace SnakeAndLader
{
    public class Play
    {
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2;
        int PlayerPosition = 0;
        Random random = new Random();
        public int DieRoll()
        {
            int die = random.Next(1, 7);
            return die;
        }
        public void GamePlay()
        {
            int option=random.Next(0, 3);
            switch (option)
            {
                case NO_PLAY:
                    Console.WriteLine("Same Position");
                    break;
                    case LADDER:
                    this.PlayerPosition += DieRoll();
                    Console.WriteLine("Player position  " +PlayerPosition);
                    break;
                    case SNAKE:
                    this.PlayerPosition -= DieRoll();
                    Console.WriteLine("Player position  " +PlayerPosition);
                    break;                       
            }
        }

    }
}
