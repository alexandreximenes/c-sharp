using Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    class ContaInvestimento : Conta, Tributavel

    {
        public double Calcula()
        {
            return this.Saldo * 0.3;
        }

        //sobrescrevendo o metodo da classe Conta
        public override void Saca(double valor)
        {
            this.Saldo -= valor + 0.1;
        }
    }
}
