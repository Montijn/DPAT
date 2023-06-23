using DPAT.Builder;
using DPAT.Factory;
using DPAT.View;
using System;

namespace DPAT
{
    public class GameController
    {
        private int currentRow = 0;
        private int currentColumn = 0;
        private SquareSudoku _sudoku;
        private GameView gameView;

        public GameController(SudokuBuilder sudokuBuilder)
        {
            SudokuDirector sudokuDirector = new SudokuDirector();
            sudokuDirector.Construct(sudokuBuilder);
            _sudoku = sudokuBuilder.GetSudoku();
            gameView = new GameView();
        }

        public void StartGame()
        {
            gameView.PrintPuzzle(_sudoku, currentRow, currentColumn);
            bool checkMove = true;

            while (checkMove)
            {
                int move = gameView.GetMove();

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
                            if (_sudoku.Rows[currentRow].Cells[currentColumn] is ChangeableCell ) // Compare Value property
                            {
                                _sudoku.Rows[currentRow].Cells[currentColumn].Value = number; // Update Value property
                            }
                        }
                        break;
                    case 5: // 's' key
                        CheckSudokuSolution();
                        break;
                    default:
                        break;
                }

                gameView.PrintPuzzle(_sudoku, currentRow, currentColumn);
            }
        }

        private void CheckSudokuSolution()
        {
            StandardSolverVisitor solver = new StandardSolverVisitor(_sudoku);
            bool isSolved = solver.IsSolvedCorrectly();
            gameView.DisplaySudokuSolution(isSolved);
        }
    }
}
