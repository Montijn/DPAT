using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPAT.Models.Components
{
    public abstract class Component
    {

        public abstract void GetValue();
        public abstract void Add(Component c);
        public abstract void Remove(Component c);
    }
}
