using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    class ContaPoupanca : Conta

    {
        //sobrescrevendo o metodo da classe Conta
        public override void Saca(double valor)
        {
            this.Saldo -= valor + 0.1;
        }
    }
}
