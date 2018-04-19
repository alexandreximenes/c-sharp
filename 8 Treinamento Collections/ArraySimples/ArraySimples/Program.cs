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

            string[] meuArray = new string[4];
            meuArray[0] = "introducao á collections no C#";
            meuArray[1] = "trabalhando com arrays simples";
            meuArray[2] = "trabalhando com array explicitamente";
            meuArray[3] = "trabalhando com arrays simples";
            
            //imprimindo a primeira posicao do array
            Console.WriteLine("\n"+meuArray[0]);

            //Procurando o indice do array
            Console.WriteLine("Trabalhando com array simples esta no indice "+ Array.IndexOf(meuArray, "trabalhando com arrays simples"));

            // Procurando a ultima ocorrencia da string procurada
            Console.WriteLine("\nTrabalhando com array simples esta no indice " + Array.LastIndexOf(meuArray, "trabalhando com arrays simples"));

            // invertendo o array
            Array.Reverse(meuArray);


            //Redimencionando o array
            Array.Resize(ref meuArray, 2);


            //Ordenando um array
            Console.WriteLine("\n\nOrdenando meu array");
            Array.Sort(meuArray);

            //Copiando um array
            string[] copia = new string[meuArray.Length];

            /*
             * param meuArray - arrayReferencia
             * param 1 posicao inicial da copia
             * param copia - array que tera a copia
             * param 0, 2 - posicao inicial e final do array copia
             */
            Array.Copy(meuArray, 1, copia, 0, 2);
            imprimirArray(copia);

            //Clonar um array
            string[] clone = copia.Clone() as string[];
            imprimirArray(clone);

            //limpando um array, com as posicoes especificadas
            Array.Clear(clone, 1,2)
            imprimirArray(clone);


            //imprime o array
            Console.WriteLine("\n\n");
            imprimirArray(meuArray);


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
