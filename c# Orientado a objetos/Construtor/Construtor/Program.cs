using System;

namespace Construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Cria um objeto do tipo cliente obrigadno nome no construtor
            Cliente cliente = new Cliente("Alexandre Ximenes");

            // Construtor de object
            Conta conta = new Conta();
            conta.Cliente = cliente;
            conta.Deposita(100);

            Console.WriteLine("Cliente " + conta.Cliente + " com saldo de R$ "+ conta.Saldo);
            Console.ReadKey();
        }
    }
}
