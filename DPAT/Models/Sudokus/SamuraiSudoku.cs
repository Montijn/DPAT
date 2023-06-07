using DPAT.Models.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT
{
    public class SamuraiSudoku : Component
    {
        public Box[] Boxes { get; set; }

        public Row[] Rows { get; set; }

        public Column[] Columns { get; set; }

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
