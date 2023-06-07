using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT
{
    public class Wrong : ICellState
    {
        public void GetValue()
        {
            throw new NotImplementedException();
        }

        public void SetValue(int value)
        {
            throw new NotImplementedException();
        }
    }
}
