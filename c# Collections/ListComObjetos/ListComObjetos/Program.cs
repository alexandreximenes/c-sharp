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
            var aulaIntro = new Treinamento("Introducao a arrays", 20);
            var aulaMetodos = new Treinamento("Metodos auxiliares de arrays", 20);
            var aulaList = new Treinamento("trabalhando com List", 40);


            List<Treinamento> treinamento = new List<Treinamento>();
            treinamento.Add(aulaIntro);
            treinamento.Add(aulaMetodos);
            treinamento.Add(aulaList);

            treinamento.ForEach(t => Console.WriteLine(t) );
            Console.ReadKey();
        }


    }
    class Treinamento {
        private string titulo;
        private int duracao;

        public Treinamento(string titulo, int duracao)
        {
            Titulo = titulo;
            Duracao = duracao;

        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int Duracao { get => duracao; set => duracao = value; }
        public override string ToString()
        {
            return $"[Titulo : {titulo}, tempo : {duracao}]";
        }
    }
}
