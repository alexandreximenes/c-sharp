using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListComObjetos
{
    class Aula : IComparable
    {
        private string titulo;
        private int duracao;

        public Aula(string titulo, int duracao)
        {
            Titulo = titulo;
            Duracao = duracao;

        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int Duracao { get => duracao; set => duracao = value; }

        public int CompareTo(object obj)
        {
            //Aula outro = (Aula)obj;
            // outra forma de cast
            Aula outro = obj as Aula;
            return this.titulo.CompareTo(outro.titulo);
        }

        public override string ToString()
        {
            return $"[Titulo : {titulo}, tempo : {duracao}]";
        }
    }
}
