using DPAT.Models.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT.Factory
{
    public class UnchangeableCell : Component, ICell
    {
        public int Value { get; set; }
        public string Color { get; set; }
        public ICellState CellState => new Definitive();

        public override void Add(Component c)
        {
            throw new NotImplementedException();
        }

        public override void GetValue()
        {
            throw new NotImplementedException();
        }

        public override void Remove(Component c)
        {
            throw new NotImplementedException();
        }
    }
}
