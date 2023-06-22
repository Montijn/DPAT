using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT.Factory
{
    public interface ICell
    {
        int Value { get; set; }
        ICellState CellState { get;}
        string Color { get; set; }

    }
}

