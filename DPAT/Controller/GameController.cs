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
        private bool assisting = false;

        public GameController()
        {
            FileReader _fileReader = FileReader.GetInstance();
            Console.WriteLine(_fileReader.ToString());
            int[,] parsedArray = _fileReader.loadFile();
            SudokuBuilder builder = new SquareSudokuBuilder(parsedArray);
            SudokuDirector sudokuDirector = new SudokuDirector();
            sudokuDirector.Construct(builder);
            _sudoku = builder.GetSudoku();
            gameView = new GameView();
        }

        public void StartGame()
        {
            //ChangeToAssisting();
            if (assisting)
            {
                gameView.PrintAssisingSudoku(_sudoku, currentRow, currentColumn);
            }
            else
            {
                gameView.PrintDefinitiveSudoku(_sudoku, currentRow, currentColumn);
            }
            
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
                            if (_sudoku.Rows[currentRow].Cells[currentColumn] is ChangeableCell) // Compare Value property
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

                if (assisting)
                {
                    gameView.PrintAssisingSudoku(_sudoku, currentRow, currentColumn);
                }
                else
                {
                    gameView.PrintDefinitiveSudoku(_sudoku, currentRow, currentColumn);
                }
            }
        }

        private void ChangeToAssisting()
        {
            assisting = true;
            foreach (Row row in _sudoku.Rows)
            {
                foreach (ICell cell in row.Cells)
                {
                    cell.CellState = new Assisting();
                    if (cell is ChangeableCell changeableCell)
                    {
                        changeableCell.AssistingValues = new int[9];
                    }
                    else if (cell is UnchangeableCell unchangeableCell)
                    {
                        cell.AssistingValues = new int[] { unchangeableCell.Value };
                    }
                }
            }

            foreach (Column column in _sudoku.Columns)
            {
                foreach (ICell cell in column.Cells)
                {
                    cell.CellState = new Assisting();
                    if (cell is ChangeableCell changeableCell)
                    {
                        changeableCell.AssistingValues = new int[9];
                    }
                    else if (cell is UnchangeableCell unchangeableCell)
                    {
                        cell.AssistingValues = new int[] { unchangeableCell.Value };
                    }
                }
            }

            foreach (Box box in _sudoku.Boxes)
            {
                foreach (ICell cell in box.Cells)
                {
                    cell.CellState = new Assisting();
                    if (cell is ChangeableCell changeableCell)
                    {
                        changeableCell.AssistingValues = new int[9];
                    }
                    else if (cell is UnchangeableCell unchangeableCell)
                    {
                        cell.AssistingValues = new int[] { unchangeableCell.Value };
                    }
                }
            }
        }
        private void CheckSudokuSolution()
        {
            Checker solver = new Checker(_sudoku);
            bool isSolved = solver.IsSolvedCorrectly();
            gameView.DisplaySudokuSolution(isSolved);
        }
    }
}
