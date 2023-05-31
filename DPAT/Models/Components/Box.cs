using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT
{
    public class Box
    {
        public Box(Cell[] cells)
        {
            Cells = cells;
        }

        public Cell[] Cells { get; set; }
    }
}
