using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    class TotalizadorDeSaldos
    {
        private double total = 0;
        public void adiciona(Conta conta) {
            total += conta.Saldo;
        }

        public double saldoTotal() {
            return total;
        }
    }
}
