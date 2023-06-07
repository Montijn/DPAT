using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT
{
    public class Row
    {
        public Row(Cell[] cells)
        {
            Cells = cells;
        }

        public Cell[] Cells { get; set; }
    }
}
