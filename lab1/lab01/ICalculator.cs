using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    internal interface ICalculator
    {
        void AND(int a, int b);
        void OR(int a, int b);
        void XOR(int a, int b);
        void NOT(int a);
    }
}
