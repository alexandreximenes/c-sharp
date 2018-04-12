using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasContas
{
    class ContaCorrente : Conta
    {
        public ContaCorrente(Cliente cliente, double saldo) : base(cliente, saldo)
        {
        }

        public override string ToString()
        {
            return $"[ Conta {Cliente.Numero} do cliente {Cliente.Nome}, é : {Saldo} ]";
        }
    }
}