using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySimples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando um array implicitamente;

            /*string posicao0 = "introducao á collections no C#";
            string posicao1 = "trabalhando com arrays simples";
            string posicao2 = "trabalhando com array explicitamente";

            string[] meuArray = new string[]
            {
                    posicao0,
                    posicao1,
                    posicao2,
            };*/

            // Criando um array explicitamente;

            string[] meuArray = new string[3];
            meuArray[0] = "introducao á collections no C#";
            meuArray[1] = "trabalhando com arrays simples";
            meuArray[2] = "trabalhando com array explicitamente";

            imprimirArray(meuArray);
            Console.WriteLine(meuArray[0]);
            Console.ReadKey();
        }

        private static void imprimirArray(string[] meuArray)
        {
            foreach (var array in meuArray)
            {
                Console.WriteLine(array);
            }
        }
    }
}
