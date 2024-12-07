using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public interface CreditService
    {
        int TaşıtHesapla(int a);
        int KonutHesapla(int a);
        int IhtiyacHesapla(int a);
    }
}
