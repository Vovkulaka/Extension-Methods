using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods
{
    internal class BaseClass
    {
        internal int a = 11;
        internal int b { get; set; } = 22;

        public int A_plus_B ()
        {
            return a + b;
        }
    }
}
