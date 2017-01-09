using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeDimensionalForms
{
    public abstract class ThreeDShape
    {
        public virtual double Volume { get; }
        public virtual double Surface { get; }
    }
}
