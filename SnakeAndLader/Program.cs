using System;
namespace SnakeAndLader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game");
            Play play = new Play();
            play.GamePlay();
        }
    }
}