using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT.Builder
{
   public abstract class SudokuBuilder
    {

        public abstract void BuildSudoku();

        public abstract void BuildBoxes();
        public abstract void BuildRows();
        public abstract void BuildColumns();

        public abstract SquareSudoku GetSudoku();
    }
}
