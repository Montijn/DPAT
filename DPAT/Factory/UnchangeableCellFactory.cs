using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT.Factory
{
    public class UnchangeableCellFactory : CellFactory
    {
        public override ICell CreateCell()
        {
            return new UnchangeableCell();
        }
    }
}
