using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT
{
    public class Game
    {
        int currentRow = 0;
        int currentColumn = 0;
        Cell[,] puzzle = new Cell[9, 9];
/*        public ISudokuFactory SudokuFactory
        {
            get => default;
            set
            {
            }
        }*/

        public void StartGame()
        {
            FileReader _fileReader = FileReader.GetInstance();
            Console.WriteLine(_fileReader.ToString());

            _fileReader.loadFile();
            /*LoadGame();*/
/*            Console.WriteLine("-------------------");
            PrintPuzzle();
            bool checkMove = true;
            while (checkMove)
            {
                int move = GetMove();
                switch (move)
                {
                    case 0: // UpArrow
                        if (currentRow > 0)
                            currentRow--;
                        break;
                    case 1: // RightArrow
                        if (currentColumn < 8)
                            currentColumn++;
                        break;
                    case 2: // DownArrow
                        if (currentRow < 8)
                            currentRow++;
                        break;
                    case 3: // LeftArrow
                        if (currentColumn > 0)
                            currentColumn--;
                        break;
                    case 4: // Enter
                        ConsoleKey consoleKey = Console.ReadKey().Key;
                        if (char.IsDigit((char)consoleKey))
                        {
                            int number = int.Parse(((char)consoleKey).ToString());
                            if (puzzle[currentRow, currentColumn].Value == 0) // Compare Value property
                            {
                                puzzle[currentRow, currentColumn].Value = number; // Update Value property
                            }
                        }
                        break;
                    default:
                        break;
                }

                Console.Clear();
                Console.WriteLine("-------------------");
                PrintPuzzle();
            }*/
        }

        private void PrintPuzzle()
        {
            for (int i = 1; i < 10; ++i)
            {
                for (int j = 1; j < 10; ++j)
                {
                    if (i - 1 == currentRow && j - 1 == currentColumn)
                    {
                        Console.Write("|");
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("{0}", puzzle[i - 1, j - 1].Value);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("|{0}", puzzle[i - 1, j - 1].Value);
                    }
                }

                Console.WriteLine("|");
                if (i % 3 == 0)
                {
                    Console.WriteLine("-------------------");
                }
            }
        }
        private void LoadGame()
        {
            int[,] initialPuzzle = {
                { 3, 2, 1, 7, 0, 4, 0, 0, 0 },
                { 6, 4, 0, 0, 9, 0, 0, 0, 7 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 4, 5, 9, 0, 0 },
                { 0, 0, 5, 1, 8, 7, 4, 0, 0 },
                { 0, 0, 4, 9, 6, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 2, 0, 0, 0, 7, 0, 0, 1, 9 },
                { 0, 0, 0, 6, 0, 9, 5, 8, 2 }
             };

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    puzzle[i, j] = new Cell();
                    puzzle[i, j].Value = initialPuzzle[i, j];
                    if (puzzle[i, j].Value == 0)
                        puzzle[i, j].CellState = new Assisting();
                    else
                    puzzle[i, j].CellState = new Definitive();
                }
            }
        }

        public int GetMove()
        {
            bool b = true;

            while (b)
            {
                ConsoleKey consoleKey = Console.ReadKey().Key;
                switch (consoleKey)
                {
                    case ConsoleKey.UpArrow:
                        return 0;
                    case ConsoleKey.RightArrow:
                        return 1;
                    case ConsoleKey.DownArrow:
                        return 2;
                    case ConsoleKey.LeftArrow:
                        return 3;
                    case ConsoleKey.Enter:
                        return 4;
                    default:
                        return 5;

                }
            }
            return -1;

        }

    }
}
