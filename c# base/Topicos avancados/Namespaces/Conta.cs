using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alexandre.Cliente;
using Alexandre.Excecoes;


namespace Alexandre.Conta
{
    class Conta
    {
        public Cliente.Cliente Cliente { get; }
        public double Saldo { get; protected set; }
        private double valor = 0;
        public Conta(Cliente.Cliente cliente, double saldo)
        {
            try {
                Cliente = cliente;
                Saldo = saldo;

            }
            catch (Exception e) {
                Console.WriteLine("Não foi possivel capturar os dados da conta");
            }
        }

        public bool Saca(double valor)
        {
            try
            {
                this.valor = valor;
            }
            catch (Exception e) {
                Console.WriteLine("Não conseguir converter o valor do saque");
            }
            if (valor < 0) {
                throw new ArgumentException();
            }
            if (valor <= this.Saldo)
            {
                this.Saldo -= valor;
                return true;
            }
            else
            {
                throw new SaldoInsuficienteException();
            }
        }
    }
}
