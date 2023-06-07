using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT.Factory
{
    public abstract class CellCreator
    {
       public abstract ICell CreateCell();
    }
}
