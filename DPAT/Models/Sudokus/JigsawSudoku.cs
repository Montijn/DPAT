using DPAT.Models.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT
{
    public class JigsawSudoku : Component
    {
        public Box[] Boxes { get; set; }

        public Row[] Rows { get; set; }

        public Column[] Columns { get; set; }
    }
}
