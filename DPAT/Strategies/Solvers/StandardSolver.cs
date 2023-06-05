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
                        return false;
                    }
                }
            }

            return true;
        }

        private bool IsSafe(int row, int col, int num)
        {
            return !UsedTwiceInRow(row, num) && !UsedTwiceInColumn(col, num) && !UsedTwiceInBox(row - row % 3, col - col % 3, num);
        }

        private bool UsedTwiceInRow(int row, int num)
        {
            int count = 0;
            for (int col = 0; col < size; col++)
            {
                if (puzzle.Rows[row].Cells[col].Value == num)
                {
                    count++;
                    if (count > 1)
                        return true;
                }
            }

            return false;
        }

        private bool UsedTwiceInColumn(int col, int num)
        {
            int count = 0;
            for (int row = 0; row < size; row++)
            {
                if (puzzle.Rows[row].Cells[col].Value == num)
                    count++;
                if (count > 1)
                    return true;
            }

            return false;
        }

        private bool UsedTwiceInBox(int startRow, int startCol, int num)
        {
            int count = 0;
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (puzzle.Boxes[startRow + row].Cells[startCol + col].Value == num)
                    {
                        count++;
                        if (count > 1)
                            return true;
                    }
                }
            }
            return false;
        }
    }
}
