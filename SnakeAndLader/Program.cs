using System;
namespace SnakeAndLader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game");
            Play play1 = new Play();
            play1.GamePlay();
            int Player1 = play1.GamePlay();
            Play play2 = new Play();
            play2.GamePlay();
            int Player2 = play2.GamePlay();
            play2.winner(Player1, Player2);
        }
    }
}