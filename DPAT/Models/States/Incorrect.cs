using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT
{
    public class Incorrect : ICellState
    {
        public string Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
