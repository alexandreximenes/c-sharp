using Interface;
using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Instancia uma conta poupança
            ContaPoupanca cp = new ContaPoupanca();
            cp.Deposita(1000);
            cp.Saca(100);

            //Instancia outra uma conta poupança
            ContaInvestimento cp2 = new ContaInvestimento();
            cp2.Deposita(100);
            cp2.Saca(10);

            //totalizado o tributo das contas
            TotalizadorDeTributos t = new TotalizadorDeTributos();
            t.Acumula(cp);
            t.Acumula(cp2);

            Console.WriteLine("saldo da conta poupança é  "+ cp.Saldo);
            Console.WriteLine("saldo da conta poupança é  " + cp2.Saldo);
            Console.WriteLine("Tributos totais das contas  " + Convert.ToString(t.Total() ));
            Console.WriteLine("Total de contas é  " + Convert.ToString(Conta.totalDeContas() ));
            Console.ReadKey();
        }
    }
}
