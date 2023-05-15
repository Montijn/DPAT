using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT
{
    public class Game
    {
        int currentRow = 0;
        int currentColumn = 0;
        int[,] puzzle = {
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
        public SudokuFactory SudokuFactory
        {
            get => default;
            set
            {
            }
        }

        public FileReader FileReader
        {
            get => default;
            set
            {
            }
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
                            if(puzzle[currentRow, currentColumn] == 0)
                            {
                                puzzle[currentRow, currentColumn] = number;
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
                        Console.Write("{0}", puzzle[i - 1, j - 1]);
                        Console.ResetColor();
                    }
                    
                    else
                        Console.Write("|{0}", puzzle[i - 1, j - 1]);
                }

                Console.WriteLine("|");
                if (i % 3 == 0) Console.WriteLine("-------------------");
            }
        }
        public void LoadGame()
        {
           
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
