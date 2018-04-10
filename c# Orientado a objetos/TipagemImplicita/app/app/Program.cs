using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nâo funciona, lado direto tem que ser algo concreto para ser implicito
            //var nula = null;

            var alexandre = new Cliente("Alexandre", 18, true, "123456-58");

            string podeAbrirConta = (alexandre.PodeAbrirConta() ? "Sim" : "Não");

            Console.WriteLine("Cliente pode abrir conta :" + (podeAbrirConta));
            Console.ReadKey();
        }
    }
}
