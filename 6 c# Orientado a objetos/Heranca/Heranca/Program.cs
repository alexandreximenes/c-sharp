using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Instancia uma conta poupança
            Conta cp = new ContaPoupanca();
            cp.Deposita(100);
            cp.Saca(10);

            //Instancia outra uma conta poupança
            Conta cp2 = new ContaPoupanca();
            cp2.Deposita(500);
            cp2.Saca(50);

            //totalizado o saldo das contas
            TotalizadorDeSaldos totalizadorDeSaldos = new TotalizadorDeSaldos();
            totalizadorDeSaldos.adiciona(cp);
            totalizadorDeSaldos.adiciona(cp2);

            Console.WriteLine("saldo da conta poupança é  "+ cp.Saldo);
            Console.WriteLine("saldo da conta poupança é  " + cp2.Saldo);
            Console.WriteLine("saldo total das contas  " + totalizadorDeSaldos.saldoTotal());
            Console.ReadKey();
        }
    }
}
