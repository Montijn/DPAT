using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT.Factory
{
    public abstract class CellFactory
    {
       public abstract ICell CreateCell();
    }
}
