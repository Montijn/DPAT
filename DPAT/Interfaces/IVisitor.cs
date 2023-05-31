using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT
{
    public interface IVisitor
    {

        public void VisitSquare();
        public void VisitSamurai();
        public void VisitJigsaw();
    }
}
