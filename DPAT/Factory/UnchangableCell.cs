using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT.Factory
{
    public class UnchangeableCell : ICell
    {
        public int Value { get; set; }
        public string Color { get; set; }
        public ICellState CellState => new Definitive();

    }
}
