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

            //Adicionando aulas no cSharpCollections
            cSharpCollections.Adiciona(aulaIntro);
            cSharpCollections.Adiciona(aulaMetodos);
            cSharpCollections.Adiciona(aulaList);

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

            //Copia da lista Aulas
            List<Aula> AulasCopiadas = new List<Aula>(Aulas);

            //Ordenando a AulasCopiadas por duração do tempo maior para o menor
            AulasCopiadas.Sort( (este, outro) => este.Duracao.CompareTo(outro.Duracao) );
            AulasCopiadas.Reverse();
            imprimir("treinamento com IComparable, ordenando a copia por titulo : ", AulasCopiadas);

            //Totalizar o tempo de duração do curso
            int TempoTotal = cSharpCollections.TempoTotal;
            Console.WriteLine("tempo total do curso : {0}", TempoTotal );

            //Imprimir o Curso
            Console.WriteLine("Imprimindo curso com ToString: "+cSharpCollections);
            

            Aluno a1 = new Aluno("Alexandre Ximenes", 123);
            Aluno a2 = new Aluno("Dayane Ximenes", 231);
            Aluno a3 = new Aluno("Arthur Ximenes", 321);
            Aluno a4 = new Aluno("Alexandre Ximenes", 123);

            //Adiciona os alunos no ISet alunos
            cSharpCollections.Matricular(a1);
            cSharpCollections.Matricular(a2);
            cSharpCollections.Matricular(a3);

            //Imprimir os alunos
            Console.WriteLine("\nImprimindo alunos");
            foreach (Aluno aluno in cSharpCollections.Alunos)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine($"O aluno {a1.Nome} esta matriculado :");
            Console.WriteLine(a1.Equals(a4));

            Console.ReadKey();

            //Limpando o console
            Console.Clear();

           

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
