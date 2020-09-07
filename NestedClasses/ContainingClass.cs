using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NestedClasses
{
    public partial class ContainingClass
    {
        private ContainedClass containedClass;
        public ContainingClass( int i)
        {
        containedClass = new ContainedClass(i);
        }

        public int GetValue() => containedClass.Numero;
    }
}
