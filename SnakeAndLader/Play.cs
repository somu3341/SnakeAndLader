using System;
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
        public void GamePlay()
        {
            while (this.PlayerPosition < WINNING_POSITION)
            {
            int option=random.Next(0, 3);
                switch (option)
                {
                    case NO_PLAY:
                       // Console.WriteLine("Same Position");
                        break;
                    case LADDER:
                        this.PlayerPosition += DieRoll();                       
                        break;
                    case SNAKE:
                        this.PlayerPosition -= DieRoll();                       
                        break;
                }
                Console.WriteLine("Player position  " + PlayerPosition);
            }
            Console.WriteLine("Player position  " + PlayerPosition);
        }
    }
}
