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

        }
    }
    class treinamento {
        private string titulo;
        private int duracao;

        public treinamento(string titulo, int duracao)
        {
            Titulo = titulo;
            Duracao = duracao;

        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int Duracao { get => duracao; set => duracao = value; }
    }
}
