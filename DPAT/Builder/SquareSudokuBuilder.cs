using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT.Builder
{
    class SquareSudokuBuilder : SudokuBuilder
    {
        protected SquareSudoku _sudoku;
        private int[,] initialPuzzle = {
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

        public override void BuildSudoku()
        {
            _sudoku = new SquareSudoku();
        }

        public override void BuildBoxes()
        {
            Box[] boxes = new Box[9];
            for (int i = 0; i < 9; i++)
            {
                Cell[] cells = new Cell[9];
                for (int j = 0; j < 9; j++)
                {
                    cells[j] = new Cell();
                    cells[j].Value = initialPuzzle[i / 3 * 3 + j / 3, i % 3 * 3 + j % 3];
                    if (cells[j].Value == 0)
                    {
                        cells[j].CellState = new Assisting();
                    }
                    else
                    {
                        cells[j].CellState = new Definitive();
                    }
                }
                boxes[i] = new Box(cells);
            }

            _sudoku.Boxes = boxes;
        }

        public override void BuildRows()
        {
            // Ensure _sudoku.Rows is initialized
            if (_sudoku.Rows == null)
            {
                _sudoku.Rows = new Row[9];
            }

            for (int i = 0; i < 9; i++)
            {
                Cell[] cells = new Cell[9];
                for (int j = 0; j < 9; j++)
                {
                    cells[j] = new Cell();
                    cells[j].Value = initialPuzzle[i, j];
                    if (cells[j].Value == 0)
                    {
                        cells[j].CellState = new Assisting();
                    }
                    else
                    {
                        cells[j].CellState = new Definitive();
                    }
                }
                _sudoku.Rows[i] = new Row(cells);
            }
        }

        public override void BuildColumns()
        {
            // Ensure _sudoku.Columns is initialized
            if (_sudoku.Columns == null)
            {
                _sudoku.Columns = new Column[9];
            }

            for (int i = 0; i < 9; i++)
            {
                Cell[] cells = new Cell[9];
                for (int j = 0; j < 9; j++)
                {
                    cells[j] = new Cell();
                    cells[j].Value = initialPuzzle[j, i];
                }
                _sudoku.Columns[i] = new Column(cells);
            }
        }

        public override SquareSudoku GetSudoku()
        {
            return _sudoku;
        }
    }
}
