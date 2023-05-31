using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT
{
    public class SquareSudokuFactory : ISudokuFactory
    {
        public SquareSudoku SquareSudoku
        {
            get => default;
            set
            {
            }
        }

        public void CreateSudoku()
        {
            throw new NotImplementedException();
        }
    }
}
