using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT
{
    public class Cell
    {
        private ICellState _cellState;
        private int _value;

        public int Value
        {
            get => _value;
            set
            {
                _value = value;
            }
        }
        public  ICellState CellState
        {
            get => _cellState;
            set
            {
                _cellState = value;
            }
        }
        public void ChangeState(ICellState cellState)
        {
            CellState = cellState;
        }

    }
}
