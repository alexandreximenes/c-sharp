using System;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Simulação da soma de salario anual com FOR
            double salario = 1000.00;
            for (int i = 0; i < 12; i++) {
                Console.WriteLine("Salario do mês "+ (i+1) + " é : " + salario);
                salario += 1000.00;
            }


            Console.WriteLine();
            //WHILE
            int j = 0;
            while (j < 12)
            {
                Console.WriteLine("Salario do mês " + (j + 1) + " é : " + salario);
                j++;
            }


            //DO WHILE
            Console.WriteLine();
            int k = 0;
            do
            {
                Console.WriteLine("Salario do mês " + (k + 1) + " é : " + salario);
                k++;
            } while (k < 12);

            
            //MULTIPLO DE 3
            Console.WriteLine();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("O número " + i + " é um múltiplo de 3");
                }
            }

            //FATORIAL
            Console.WriteLine("\nFATORIAL *******");
            int fatorial = 1;
            for (int n = 1; n <= 10; n++)
            {
                fatorial = fatorial * n;
                Console.WriteLine("fatorial(" + n + ") = " + fatorial);
            }

            //FIBONACCI
            Console.WriteLine("\nFIBONACCI *******");
            string serieFibonacci = "";
            int anterior = 0;
            int atual = 1;
            while (atual <= 100)
            {
                serieFibonacci += atual + " ";
                int proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
            }
            Console.WriteLine("A série de Fibonacci até 100: " + serieFibonacci);

            Console.ReadKey();
        }
    }
}
