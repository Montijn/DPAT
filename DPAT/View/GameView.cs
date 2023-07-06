using DPAT.Factory;
using System;
using System.Collections.Generic;

namespace DPAT.View
{
    public class GameView
    {
        public void PrintDefinitiveSudoku(SquareSudoku sudoku, int currentRow, int currentColumn)
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

        public void PrintAssisingSudoku(SquareSudoku sudoku, int currentRow, int currentColumn)
        {
            Console.Clear();

            foreach (var row in sudoku.Rows)
            {
                // Store the assisting values for each row in a list
                List<int[]> assistingValuesList = new List<int[]>();

                foreach (var cell in row.Cells)
                {
                    if (cell.CellState is Assisting)
                    {
                        assistingValuesList.Add(cell.AssistingValues);
                    }
                }

                // Print the assisting values for each row
                for (int assistingRow = 0; assistingRow < 3; assistingRow++)
                {
                    foreach (var assistingValues in assistingValuesList)
                    {
                        for (int col = assistingRow * 3; col < (assistingRow + 1) * 3; col++)
                        {
                            if (col < assistingValues.Length)
                            {
                                int value = assistingValues[col];
                                Console.Write("{0}", value);
                            }
                            else
                            {
                                Console.Write("_"); // Display spaces for missing values
                            }

                            if ((col + 1) % 3 == 0)
                            {
                                Console.Write("|");
                            }
                        }
                    }
                    Console.WriteLine(); // Move to the next line for the next assisting row
                }

                // Print the remaining cells in the row
                foreach (var cell in row.Cells)
                {
                    if (cell.CellState is Definitive)
                    {
                        PrintCellWithColor(cell, cell.CellState.Color, ConsoleColor.Black);
                    }
                    else if (cell.CellState is Assisting)
                    {
                        // Skip printing the assisting values again
                        continue;
                    }
                    else
                    {
                        Console.Write("|{0}", cell.Value);
                    }
                }
                Console.WriteLine("|");
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
