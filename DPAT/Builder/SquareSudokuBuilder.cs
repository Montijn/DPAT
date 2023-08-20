using DPAT.Factory;
using DPAT.Models.States;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT.Builder
{
    class SquareSudokuBuilder : SudokuBuilder
    {
        protected SquareSudoku _sudoku;
        private int[,] initialPuzzle = {
            { 0, 3, 5, 4, 1, 6, 9, 2, 7 },
            { 2, 9, 6, 8, 5, 7, 4, 3, 1 },
            { 4, 1, 7, 2, 9, 3, 0, 5, 8 },
            { 5, 6, 9, 0, 3, 4, 7, 8, 2 },
            { 1, 0, 3, 6, 7, 8, 5, 4, 0 },
            { 7, 4, 8, 5, 2, 9, 1, 6, 3 },
            { 6, 5, 2, 0, 8, 1, 3, 9, 4 },
            { 9, 8, 1, 3, 4, 5, 2, 7, 6 },
            { 3, 7, 4, 9, 6, 2, 8, 1, 5 }
         };
        public SquareSudokuBuilder(int [,]initialPuzzle)
        {
            this.initialPuzzle = initialPuzzle;
        }

        public override void BuildSudoku()
        {
            _sudoku = new SquareSudoku();
        }

        public override void BuildBoxes()
        {
            Box[] boxes = new Box[9];
            for (int i = 0; i < 9; i++)
            {
                ICell[] cells = new ICell[9];
                for (int j = 0; j < 9; j++)
                {
                    if (initialPuzzle[i / 3 * 3 + j / 3, i % 3 * 3 + j % 3] == 0)
                    {
                        cells[j] = new ChangeableCell();
                        cells[j].CellState = new Definitive();
                    }
                    else
                    {
                        cells[j] = new UnchangeableCell();
                        cells[j].CellState = new Preset();
                    }
                   
                    
                    cells[j].Value = initialPuzzle[i / 3 * 3 + j / 3, i % 3 * 3 + j % 3];
                   
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
                ICell[] cells = new ICell[9];
                for (int j = 0; j < 9; j++)
                {
                    if(initialPuzzle[i, j] == 0)
                    {
                        cells[j] = new ChangeableCell();
                        cells[j].CellState = new Definitive();
                    }
                    else
                    {
                        cells[j] = new UnchangeableCell();
                        cells[j].CellState = new Preset();
                    }
                    cells[j].Value = initialPuzzle[i, j];
                   
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
                ICell[] cells = new ICell[9];
                for (int j = 0; j < 9; j++)
                {
                    if(initialPuzzle[j, i] == 0)
                    {
                        cells[j] = new ChangeableCell();
                        cells[j].CellState = new Definitive();
                    }
                    else
                    {
                        cells[j] = new UnchangeableCell();
                        cells[j].CellState = new Preset();
                    }
 
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
