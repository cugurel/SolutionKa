using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class CreditClass : CreditService
    {
        public int IhtiyacHesapla(int a)
        {
            return a + 200;
        }

        public int KonutHesapla(int a)
        {
            return a + 300;
        }

        public int TaşıtHesapla(int a)
        {
            return a + 400;
        }
    }
}
