using DPAT.Factory;
using DPAT.Models.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT
{
    public class Column : Component
    {
        public Column(ICell[] cells)
        {
            Cells = cells;
        }

        public ICell[] Cells { get; set; }

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
