using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT.Factory
{
    public class ChangeableCell : ICell
    {
        private int _value;
        private string _color;

        public int Value
        {
            get => _value;
            set => _value = value;
        }


        public string Color
        {
            get => _color;
            set => _color = value;
        }

        public ICellState CellState { get; private set; }

        public void ChangeState(ICellState cellState)
        {
            CellState = cellState;
        }
    }
}
