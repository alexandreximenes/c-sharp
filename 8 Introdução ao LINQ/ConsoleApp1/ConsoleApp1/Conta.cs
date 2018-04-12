using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasContas
{
    abstract class Conta
    {
        public Cliente Cliente { get; }
        public double Saldo { get; protected set; }
        private double valor = 0;
        public Conta(Cliente cliente, double saldo)
        {
            try {
                Cliente = cliente;
                Saldo = saldo;

            }
            catch (Exception e) {
                Console.WriteLine("Não foi possivel capturar os dados da conta");
            }
        }

        public void Saca(double valor)
        {
            try
            {
                this.valor = valor;
            }
            catch (Exception e)
            {
                Console.WriteLine("Não conseguir converter o valor do saque");
            }
            if (valor < 0)
            {
                throw new ArgumentException();
            }
            if (valor <= this.Saldo)
            {
                this.Saldo -= valor;
            }
            else
            {
                throw new Exception();
            }
        }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }
    }
}
