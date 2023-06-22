using DPAT.Builder;
using System;

namespace DPAT
{
    class Program
    {

        private GameController game;

        [STAThread]
        static void Main(string[] args)
        {
            SudokuBuilder builder = new SquareSudokuBuilder();
            GameController game = new GameController(builder);
            game.StartGame();
        }
    }
}
