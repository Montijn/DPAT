using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT.Factory
{
    public class ChangeableCellCreator : CellCreator
    {
        public override ICell CreateCell()
        {
            return new ChangeableCell();
        }
    }
}
