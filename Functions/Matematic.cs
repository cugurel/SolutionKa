using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class Matematic : MatematicService
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Division(int a, int b)
        {
            return a / b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public void Print(int a, int b)
        {
            Console.WriteLine("a sayısı : "+a+ " b sayısı : "+b);
        }

        public int Substraction(int a, int b)
        {
            return a - b;
        }
    }
}
