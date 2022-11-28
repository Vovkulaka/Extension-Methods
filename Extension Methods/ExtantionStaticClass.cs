using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods
{
    static internal class ExtantionStaticClass
    {
        static private int aa = 10;

        static private int result = 0;
        static public int ExtentionMethod_A_multiply_AA (this BaseClass baseClass) // ОБОВ'ЯЗКОВОВ ПЕРЕДАЄШ ТОЙ ТИП, ЯКИЙ ХОЧЕШ РОЗШИРИТИ!!!
        {
            result = baseClass.a * aa;

            return result;
        }
    }
}
