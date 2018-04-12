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
            cSharpCollections.Adiciona(new Treinamento("Introducao a arrays", 20));
            imprimirIList("imprimindo com IList", cSharpCollections.Treinamento);
            
            //Criando instancias de do objeto treinamento
            var aulaIntro = new Treinamento("Introducao a arrays", 20);
            var aulaMetodos = new Treinamento("Metodos auxiliares de arrays", 50);
            var aulaList = new Treinamento("trabalhando com List", 40);

            //Lista sem proteção
           // cSharpCollections.Treinamento.Add(aulaIntro);

            List<Treinamento> treinamento = new List<Treinamento>();
            treinamento.Add(aulaMetodos);
            treinamento.Add(aulaIntro);
            treinamento.Add(aulaList);

            //
            

            imprimir("treinamento com IComparable, ordenando por titulo : ", treinamento);
            
            //Ordenando titulo com ICamparable
            treinamento.Sort();

            //Ordenando duracao com Lambda
            treinamento.Sort( (este, outro) => este.Duracao.CompareTo(outro.Duracao) );
            imprimir("treinamento com lambda, ordenando por duração : ", treinamento);

        }

        private static void imprimirIList(string nome, IList<Treinamento> treinamento)
        {
            //IList não tem o metodo forEach
            Console.WriteLine("\n" + nome);
            foreach (var t in treinamento)
            {
                Console.WriteLine(t);
            }
        }

        private static void imprimir(string nome, List<Treinamento> treinamento)
        {
            Console.WriteLine("\n"+nome);
            treinamento.ForEach(t => Console.WriteLine(t));
            Console.ReadKey();
        }
    }
    class Treinamento : IComparable{
        private string titulo;
        private int duracao;

        public Treinamento(string titulo, int duracao)
        {
            Titulo = titulo;
            Duracao = duracao;

        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int Duracao { get => duracao; set => duracao = value; }

        public int CompareTo(object obj)
        {
           Treinamento outro = (Treinamento) obj;
           return this.titulo.CompareTo(outro.titulo);
        }

        public override string ToString()
        {
            return $"[Titulo : {titulo}, tempo : {duracao}]";
        }
    }
}
