using System;

namespace ConsoleApp_OO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conta\n");

            //Cria os objetos
            Cliente alexandre = new Cliente();
            Conta contaCorrente1 = new Conta();

            //Seta os valores
            alexandre.numero = 1;
            alexandre.titular = "Alexandre";
            contaCorrente1.saldo = 1000;
            contaCorrente1.cliente = alexandre;

            //Cria os objetos
            Cliente arthur = new Cliente();
            Conta contaCorrente2 = new Conta();

            //Seta os valores
            arthur.numero = 1;
            arthur.titular = "Arthur";
            contaCorrente2.saldo = 1000;
            contaCorrente2.cliente = arthur;

            Console.WriteLine("\nAntes das operacoes");
            Console.WriteLine("Saldo do" + contaCorrente1.cliente.titular + " é " + contaCorrente1.saldo);
            Console.WriteLine("Saldo do" + contaCorrente2.cliente.titular + " é " + contaCorrente2.saldo);

            Console.WriteLine("\nAntes das operacoes");
            contaCorrente1.Saca(100);
            contaCorrente2.Deposita(100);
            contaCorrente1.Transfere(400, contaCorrente2);

            Console.WriteLine("Antes das operacoes");
            Console.WriteLine("Saldo do" + contaCorrente1.cliente.titular + " é " + contaCorrente1.saldo);
            Console.WriteLine("Saldo do" + contaCorrente2.cliente.titular + " é " + contaCorrente2.saldo);

            Console.ReadKey();
        }
    }
}
