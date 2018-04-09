using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Conta cp = new ContaPoupanca();
            cp.Deposita(100);
            cp.Saca(10);

            Console.WriteLine("saldo da conta poupança é  "+ cp.Saldo);
            Console.ReadKey();
        }
    }
}
