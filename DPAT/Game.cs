using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT
{
    public class Game
    {
        private SudokuFactory _sudokuFactory { get; set; }

        public Game()
        {
            LoadGame();
        }

        public SudokuFactory SudokuFactory
        {
            get
            {
                return _sudokuFactory;
            }
            set
            {
                _sudokuFactory = value;
            }
        }

        public void StartGame()
        {

        }
        public void LoadGame()
        {
            FileReader reader = FileReader.GetInstance();
            reader.loadFile();
        }

    }
}
