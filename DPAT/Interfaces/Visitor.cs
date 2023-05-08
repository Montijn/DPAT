using System;
using System.Collections.Generic;
using System.Text;

namespace DPAT
{
    public interface Visitor
    {

        public void VisitSquare();
        public void VisitSamurai();
        public void VisitJigsaw();
    }
}
