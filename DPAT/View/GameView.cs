using DPAT.Factory;
using System;

namespace DPAT.View
{
    public class GameView
    {
        public void PrintPuzzle(SquareSudoku sudoku, int currentRow, int currentColumn)
        {
            Console.Clear();
            Console.WriteLine("-------------------");

            for (int i = 1; i < 10; ++i)
            {
                for (int j = 1; j < 10; ++j)
                {
                    if (i - 1 == currentRow && j - 1 == currentColumn)
                    {
                        PrintCellWithColor(sudoku.Rows[i - 1].Cells[j - 1], ConsoleColor.Blue, ConsoleColor.White);
                    }
                    else if (sudoku.Rows[i - 1].Cells[j - 1].CellState is Definitive)
                    {
                        PrintCellWithColor(sudoku.Rows[i - 1].Cells[j - 1], sudoku.Rows[i - 1].Cells[j - 1].CellState.Color, ConsoleColor.Black);
                    }
                    else
                    {
                        Console.Write("|{0}", sudoku.Rows[i - 1].Cells[j - 1].Value);
                    }
                }

                Console.WriteLine("|");
                if (i % 3 == 0)
                {
                    Console.WriteLine("-------------------");
                }
            }
        }

        private void PrintCellWithColor(ICell cell, ConsoleColor backgroundColor, ConsoleColor foregroundColor)
        {
            Console.Write("|");
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;
            Console.Write("{0}", cell.Value);
            Console.ResetColor();
        }

        public int GetMove()
        {
            while (true)
            {
                ConsoleKey consoleKey = Console.ReadKey(intercept: true).Key;
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
                    case ConsoleKey.S:
                        return 5;
                }
            }
        }

        public void DisplaySudokuSolution(bool isSolved)
        {
            if (isSolved)
            {
                Console.WriteLine("You solved it!");
            }
            else
            {
                Console.WriteLine("Still some mistakes :(");
                Console.WriteLine("Press any key to continue playing...");
            }

            Console.ReadKey(intercept: true);
        }
    }
}
