using System;
namespace SnakeAndLader
{
    public class Play
    {
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING_POSITION = 100;
        int PlayerPosition1 = 0, count = 0;
        int PlayerPosition2 = 0;
        Random random = new Random();
        public int DieRoll()
        {
            int die = random.Next(1, 7);
            Console.WriteLine("Die value-->" +die);
            count++;
            return die;
        }
        public void GamePlay()
        {
            while (this.PlayerPosition1 < WINNING_POSITION)
            {
             int option1 = random.Next(0, 3);
             
                switch (option1)
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                        this.PlayerPosition1 += DieRoll();                       
                        break;
                    case SNAKE:
                        int dieRoll = DieRoll();
                        if (this.PlayerPosition1 - dieRoll > 0)
                            this.PlayerPosition1 -= dieRoll;
                        else
                            this.PlayerPosition1 = 0;
                        if (this.PlayerPosition1 == WINNING_POSITION)
                        {
                            Console.WriteLine("Player position1  " + PlayerPosition1);
                            Console.WriteLine("DieCount---->" + count);
                        }                       
                        break;
                }
                int option2 = random.Next(0, 3);
                switch (option2)
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                        this.PlayerPosition2 += DieRoll();                     
                        if (this.PlayerPosition2 >= WINNING_POSITION)
                        {
                            Console.WriteLine("Player position  " + PlayerPosition2);
                            Console.WriteLine("DieCount " + count);
                        }
                        break;
                    case SNAKE:
                        this.PlayerPosition2 += DieRoll();
                        break;

                }   
            }
            Console.WriteLine("Player1 position  " + PlayerPosition1);
            Console.WriteLine("Player2 position  " + PlayerPosition2);
            if (PlayerPosition1 < PlayerPosition2)
                Console.WriteLine("Player2 is winner");
            else
                Console.WriteLine("Player1 is winner");
        }
    }
}
    