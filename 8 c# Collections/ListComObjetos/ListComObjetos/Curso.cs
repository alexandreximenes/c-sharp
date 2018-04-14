using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListComObjetos
{
    class Curso
    {
        private List<Aula> AulasTreinamento;
        private string nome;
        private string instrutor;

        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            this.AulasTreinamento = new List<Aula>();
        }

        //encapsulando a regra de adicionar
        internal void Adiciona(Aula t)
        {
            this.AulasTreinamento.Add(t);
        }

        // criando uma lista de somente leitura
        // trocar List com IList pois ReadOnlyCollection implementa IList

        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(AulasTreinamento); }
            //set { treinamento = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }



    }
}
