using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComLIST
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usando Collections List
            string intro = "introducao a array simples";
            string listas = "trabalhando com List e seus metodos auxiliares";
            string lambdas = "trabalhando com lambdas";

            //Criando uma lista - primeira forma
            List<string> treinamento = new List<string>
            {
                intro,
                listas,
                lambdas,
            };

            // Adicionando elementos
            treinamento.Add("adicionando um novo item na lista");

            //tamanho da lista
            Console.WriteLine("Tamanho da lista : " + treinamento.Count());

            //imprimindo a primeira posicao do array
            Console.WriteLine("primeira posicao da lista : " + treinamento.First());

            //imprimindo a primeira posicao do array
            Console.WriteLine("ultima posicao da lista : " + treinamento.Last());

            //Verificando se existe um item no array
            Console.WriteLine("Verificando se existe um item no array :  " + treinamento.Contains(intro));


            try
            {
                //trabalhando com expressoes lambda
                //procura a primeira ocorrencia dentro do array com a palavra 'trabalhando'
                Console.WriteLine("A PRIMEIRA ocorrencia da palavra 'trabalhando' é :  "
                                    + treinamento.First(t => t.Contains("trabalhando")));

                //procura a ultima ocorrencia dentro do array com a palavra 'trabalhando'
                Console.WriteLine("A ULTIMA ocorrencia da palavra 'trabalhando' é :  "
                                    + treinamento.Last(t => t.Contains("trabalhando")));
            }
            catch (Exception) { /*tratamento da exceção */}

            //procura a primeira ocorrencia ou DEFAULT dentro do array com a palavra 'trabalhando'
            Console.WriteLine("A PRIMEIRA OU DEFAULT (VAZIO) ocorrencia da palavra 'trabalhando' é : "
                                + treinamento.FirstOrDefault(t => t.Contains("textoNaoEncontrado")));

            //Invertendo a lista
            treinamento.Reverse();

            //Removendo o ultimo item da lista
            treinamento.RemoveAt(treinamento.Count() - 1);

            //tamanho da lista
            Console.WriteLine("\nTamanho da lista : " + treinamento.Count());

            //Ordenando a lista
            treinamento.Sort();

            //Trabalhando com Lambdas
            treinamento.ForEach(t => Console.WriteLine(t));

            //Fazendo uma copia
            /*
             * Copiando elementos, passando tamanho do elemento, 
             * pegando o penultimo elemento
             * e pegar 2 elementos 
             */
            var tamanhoTreinamento = treinamento.Count();
            List<string> copia = treinamento.GetRange(tamanhoTreinamento - 2, 2);

            imprimirComLambda("copia", copia);

            //Clonando uma lista
            List<string> clone = new List<string>(treinamento);
            imprimirComLambda("clone", clone);

            //Removendo um intervalo especifico da lista
            clone.RemoveRange(clone.Count - 2, 2);
            imprimirComLambda("clone", clone);

            //imprimir(treinamento);

            Console.ReadKey();
        }

        private static void imprimirComLambda(string nomeLista, List<string> copia)
        {

            //imprimindo copia
            Console.WriteLine("\nimprimindo "+nomeLista+  " do array");
            copia.ForEach(c => Console.WriteLine(c));
        }

        private static void imprimirForTradicional(List<string> treinamento)
        {
            // 1 modo antigo
            for (var i = 0; i < treinamento.Count(); i++)
            {
                Console.WriteLine(treinamento[i]);
            }
        }

        private static void imprimir(List<string> treinamento)
        {
            //2 modo
            foreach (var t in treinamento)
            {
                //var t - auxiliar para percorrer List treinamento
                Console.WriteLine(t);
            }
            
        }

    }
}
