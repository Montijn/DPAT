using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT
{
    public class Column
    {
        public Column(Cell[] cells)
        {
            Cells = cells;
        }

        public Cell[] Cells { get; set; }
    }
}
