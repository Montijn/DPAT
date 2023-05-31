using DPAT.Builder;
using System;

namespace DPAT
{
    public class Game
    {
        private int currentRow = 0;
        private int currentColumn = 0;
        private SquareSudoku _sudoku;

        public Game(SudokuBuilder sudokuBuilder)
        {
            
            SudokuDirector sudokuDirector = new SudokuDirector();
            sudokuDirector.Construct(sudokuBuilder);
            _sudoku = sudokuBuilder.GetSudoku();
        }

        public void StartGame()
        {
            Console.WriteLine("-------------------");
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
                            if (_sudoku.Rows[currentRow].Cells[currentColumn].Value == 0) // Compare Value property
                            {
                                _sudoku.Rows[currentRow].Cells[currentColumn].Value = number; // Update Value property
                            }
                        }
                        break;
                    default:
                        break;
                }

                Console.Clear();
                Console.WriteLine("-------------------");
                PrintPuzzle();
            }
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
                        Console.Write("{0}", _sudoku.Rows[i - 1].Cells[j - 1].Value);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("|{0}", _sudoku.Rows[i - 1].Cells[j - 1].Value);
                    }
                }

                Console.WriteLine("|");
                if (i % 3 == 0)
                {
                    Console.WriteLine("-------------------");
                }
            }
        }

        public int GetMove()
        {
            while (true)
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
        }
    }
}
