using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    internal static class Math
    {
        public static int Rest(int wert, int divisor)
        {
            int i = wert / divisor;
            return wert - (divisor * i);
        }
    }
}
