using DPAT.Models.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT.Factory
{
    public class ChangeableCell : Component, ICell 
    {
        private ICellState _cellState;
        private int _value;
        private int[] _assistingValues;
        public int Value
        {
            get => _value;
             set => _value = value;
        }
        public ICellState CellState
        {
            get => _cellState;
            set
            {
                _cellState = value;
            }
        }

        public int[] AssistingValues {
            get => _assistingValues;
            set
            {
                _assistingValues = value;
            }
        }

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
