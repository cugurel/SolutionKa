using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public interface MatematicService
    {
        int Add(int a, int b);
        int Multiply(int a, int b);
        int Division(int a, int b);
        int Substraction(int a, int b);
        void Print(int a, int b);
    }
}
