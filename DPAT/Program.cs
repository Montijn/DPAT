using DPAT.Builder;
using System;

namespace DPAT
{
    class Program
    {
        static void Main(string[] args)
        {
            SudokuBuilder builder = new SquareSudokuBuilder();
            Game game = new Game(builder);
            game.StartGame();
        }
    }
}
