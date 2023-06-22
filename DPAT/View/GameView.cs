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
                        Console.Write("|");
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("{0}", sudoku.Rows[i - 1].Cells[j - 1].Value);
                        Console.ResetColor();
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

            Console.ReadKey();
        }
    }
}
