using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT
{
    public class JigsawSudokuFactory : ISudokuFactory
    {
        public JigsawSudoku JigsawSudoku
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
