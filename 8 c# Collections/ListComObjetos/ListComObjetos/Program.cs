using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListComObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso cSharpCollections = new Curso("C# Collections", "Alexandre Ximenes");
            cSharpCollections.Adiciona(new Aula("Introducao a arrays", 20));
            imprimirIList("imprimindo com IList", cSharpCollections.Aulas);
            
            //Criando instancias de do objeto treinamento
            var aulaIntro = new Aula("Introducao a arrays", 20);
            var aulaMetodos = new Aula("Metodos auxiliares de arrays", 50);
            var aulaList = new Aula("trabalhando com List", 40);

            //Lista sem proteção
           // cSharpCollections.Treinamento.Add(aulaIntro);

            List<Aula> Aulas = new List<Aula>();
            Aulas.Add(aulaMetodos);
            Aulas.Add(aulaIntro);
            Aulas.Add(aulaList);

            //Ordenando titulo com ICamparable
            Aulas.Sort();
            imprimir("treinamento com IComparable, ordenando por titulo : ", Aulas);
            
            //Ordenando duracao com Lambda
            Aulas.Sort( (este, outro) => este.Duracao.CompareTo(outro.Duracao) );
            imprimir("treinamento com lambda, ordenando por duração : ", Aulas);

        }

        private static void imprimirIList(string nome, IList<Aula> treinamento)
        {
            //IList não tem o metodo forEach
            Console.WriteLine("\n" + nome);
            foreach (var t in treinamento)
            {
                Console.WriteLine(t);
            }
        }

        private static void imprimir(string nome, List<Aula> treinamento)
        {
            Console.WriteLine("\n"+nome);
            treinamento.ForEach(t => Console.WriteLine(t));
            Console.ReadKey();
        }
    }
    
}
