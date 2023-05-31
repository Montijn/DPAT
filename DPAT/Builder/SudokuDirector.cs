using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT.Builder
{
    class SudokuDirector
    {
        public void Construct(SudokuBuilder builder)
        {
            builder.BuildSudoku();
            builder.BuildBoxes();
            builder.BuildRows();
            builder.BuildColumns();

        }
    }
}
