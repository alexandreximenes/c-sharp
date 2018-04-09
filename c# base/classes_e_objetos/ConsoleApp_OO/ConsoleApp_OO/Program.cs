using System;

namespace ConsoleApp_OO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conta\n");

            Conta alexandre = new Conta();
            alexandre.numero = 1;
            alexandre.titular = "Alexandre";
            alexandre.saldo = 10;

            Conta arhtur = new Conta();
            arhtur.numero = 1;
            arhtur.titular = "Arthur";
            arhtur.saldo = 100;


            Console.WriteLine("Saldo do" + alexandre.titular + " é " + alexandre.saldo);
            Console.WriteLine("Saldo do" + arhtur.titular + " é " + arhtur.saldo);

            Console.ReadKey();
        }
    }
}
