using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT
{
    public class Incorrect : ICellState
    {
        public ConsoleColor Color => throw new NotImplementedException();
    }
}
