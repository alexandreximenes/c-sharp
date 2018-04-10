using Interface;
using System;
using System.Collections.Generic;
using System.Text;


namespace Heranca
{
    class TotalizadorDeTributos
    {
        double total = 0;
        public void Acumula(Tributavel t)
        {
            total += t.Calcula();
        }

        public double Total() {
            return total;
        }
    }
}
