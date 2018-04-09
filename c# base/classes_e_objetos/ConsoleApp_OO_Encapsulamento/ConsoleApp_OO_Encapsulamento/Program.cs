using System;

namespace ConsoleApp_OO_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n************** Conta ************** \n\n");

            //Cria os objetos
            Conta cc = new Conta();

            //Seta os valores
            cc.Deposita(1000000010);

            cc.Saca(5000);
            cc.Saca(45000);
            cc.Cliente = new Cliente();
            cc.Cliente.Titular = "Alexandre";

            Console.WriteLine("Saldo do " + cc.Cliente.Titular + " é " + cc.Saldo);
            
            Console.ReadKey();
        }
    }
}
