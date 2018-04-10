using System;
using System.Collections.Generic;
using System.Text;
using Interface;

namespace Heranca
{
    class ContaPoupanca : Conta, Tributavel

    {
        public double Calcula()
        {
            return this.Saldo * 0.2;
        }

        //sobrescrevendo o metodo da classe Conta
        public override void Saca(double valor)
        {
            this.Saldo -= valor + 0.1;
        }
    }
}
