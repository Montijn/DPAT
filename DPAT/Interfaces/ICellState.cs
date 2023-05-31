using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT
{
    public interface ICellState
    {
        public void SetValue(int value);
        public void GetValue();
    }
}
