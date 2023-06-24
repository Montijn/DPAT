using DPAT.Models.Components;
using DPAT.Models.States;
using System;

namespace DPAT.Factory
{
    public class UnchangeableCell : Component, ICell
    {
        private int _value;
        private bool _isValueSet;
        private ICellState _cellState;
        private int[] _assistingValues;

        public int Value
        {
            get => _value;
            set
            {
                if (!_isValueSet)
                {
                    _value = value;
                    _isValueSet = true;
                }
            }
        }

        public ICellState CellState
        {
            get => _cellState;
            set
            {
                _cellState = value;
            }
        }
        public int[] AssistingValues
        {
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
