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
        private List<Treinamento> treinamento;
        private string nome;
        private string instrutor;

        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            this.treinamento = new List<Treinamento>();
        }

        //encapsulando a regra de adicionar
        internal void Adiciona(Treinamento t)
        {
            this.treinamento.Add(t);
        }

        // criando uma lista de somente leitura
        // trocar List com IList pois ReadOnlyCollection implementa IList

        public IList<Treinamento> Treinamento
        {
            get { return new ReadOnlyCollection<Treinamento>(treinamento); }
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
