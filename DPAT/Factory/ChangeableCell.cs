using DPAT.Models.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT.Factory
{
    public class ChangeableCell : Component, ICell 
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

        public override void Add(Component c)
        {
            throw new NotImplementedException();
        }

        public void ChangeState(ICellState cellState)
        {
            CellState = cellState;
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
