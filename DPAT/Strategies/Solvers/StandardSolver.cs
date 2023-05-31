using System;

namespace DPAT
{
    public class StandardSolver : ISolverStrategy
    {
        private SquareSudoku puzzle;
        private int size;

        public StandardSolver(SquareSudoku puzzle)
        {
            this.puzzle = puzzle;
            this.size = 9;
        }

        public bool IsSolvedCorrectly()
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    int currentValue = puzzle.Rows[row].Cells[col].Value;
                    if (currentValue == 0 || !IsSafe(row, col, currentValue))
                    {
                        return false; // Sudoku is not solved correctly
                    }
                }
            }

            return true; // Sudoku is solved correctly
        }

        private bool IsSafe(int row, int col, int num)
        {
            return !UsedInRow(row, num) && !UsedInColumn(col, num) && !UsedInBox(row - row % 3, col - col % 3, num);
        }

        private bool UsedInRow(int row, int num)
        {
            for (int col = 0; col < size; col++)
            {
                if (puzzle.Rows[row].Cells[col].Value == num)
                    return true;
            }

            return false;
        }

        private bool UsedInColumn(int col, int num)
        {
            for (int row = 0; row < size; row++)
            {
                if (puzzle.Rows[row].Cells[col].Value == num)
                    return true;
            }

            return false;
        }

        private bool UsedInBox(int startRow, int startCol, int num)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (puzzle.Rows[row + startRow].Cells[col + startCol].Value == num)
                        return true;
                }
            }

            return false;
        }
    }
}
