using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Design_Pattern
{
    internal interface Prototype
    {
        Prototype Clone();
    }
}
