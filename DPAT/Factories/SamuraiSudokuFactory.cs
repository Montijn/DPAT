using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT
{
    public class SamuraiSudokuFactory : SudokuFactory
    {
        public SamuraiSudoku SamuraiSudoku
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
