using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NestedClasses
{
    public  partial class ContainingClass
    {
        partial class ContainedClass
        {
            public int Numero;
            public ContainedClass(int i)
            { Numero = i*10; }
        }
    }
}

    
