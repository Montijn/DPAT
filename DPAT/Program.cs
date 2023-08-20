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
            GameController game = new GameController();
            game.StartGame();
        }
    }
}
