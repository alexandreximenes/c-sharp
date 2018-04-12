using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasContas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando uma lista
            List<Conta> contas = new List<Conta>();
            contas.Add(ContaComSaldo(100));
            contas.Add(ContaComSaldo(200));
            contas.Add(ContaComSaldo(300));
            contas.Add(ContaComSaldo(600));
            contas.Add(ContaComSaldo(700));

            //Buscando contas que contenham saldo acima de 500
            var filtro = from c in contas
                         where c.Saldo > 500
                         select c;

            //Usando linq para buscar as contas que contenham a letra x no nome do Cliente e com Saldo menor que 500
            filtro = from c in contas
                     where c.Cliente.Nome.Contains('x') && c.Saldo > 500
                     select c;

            //imprimeFiltro
            imprime(filtro);

            // Somando todas os saldos com lambda
            double total = filtro.Sum(c => c.Saldo);
            Console.WriteLine("\n\nSaldo : {0}", total);

            double media = filtro.Average(c => c.Saldo);
            Console.WriteLine("\nMedia do Saldo : {0}", media);

            Console.ReadKey();


        }

        private static void imprime(IEnumerable<Conta> filtro)
        {
            foreach (Conta c in filtro)
            {
                Console.WriteLine(c);
            }
        }

        private static Conta ContaComSaldo(double valor)
        {
            Cliente cliente = new Cliente(111, "Alexandre");
            Conta conta = new ContaCorrente(cliente, 0.00);
            conta.Deposita(valor);

            return conta;
        }
    }
}
