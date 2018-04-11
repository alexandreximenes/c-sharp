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

            //Criando uma lista - primeira forma
            List<string> treinamento = new List<string>
            {
                intro,
                listas,
            };

            // Adicionando elementos
            treinamento.Add("adicionando um novo item na lista");

            //tamanho da lista
            Console.WriteLine( "Tamanho da lista : "+ treinamento.Count() );


            imprimir(treinamento);
        }

        private static void imprimir(List<string> treinamento)
        {
            foreach (var t in treinamento)
            {
                //var t - auxiliar para percorrer List treinamento
                Console.WriteLine(t);
            }
            Console.ReadKey();
        }
    }
}
