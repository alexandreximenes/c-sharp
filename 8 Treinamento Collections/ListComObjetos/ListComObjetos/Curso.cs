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
        private IDictionary<int, Aluno> dicionarioAlunos = new Dictionary<int, Aluno>();
        private ISet<Aluno> alunos = new HashSet<Aluno>();
        private string nome;
        private string instrutor;

        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            this.AulasTreinamento = new List<Aula>();
        }

        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }

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

        public int TempoTotal
        {
            get{
                //Usando LINQ - Language Integrated Query
                return AulasTreinamento.Sum(aulas => aulas.Duracao);

                /*int total = 0;
                foreach (var aula in AulasTreinamento)
                {
                    total += aula.Duracao;
                }
                return total;*/
            }
        }

        public void Matricular(Aluno aluno)
        {
            this.alunos.Add(aluno);
            this.dicionarioAlunos.Add(aluno.Matricula, aluno);
        }

        public Aluno matriculado(Aluno aluno)
        {
            //return alunos.Contains(aluno);
            Aluno aluno1 = null;
            this.dicionarioAlunos.TryGetValue(aluno.Matricula, out aluno1);
            return aluno1;
        }

        public override string ToString()
        {
            return $"[Curso: {nome}, tempo: {TempoTotal}, \nAulas: {string.Join(",", AulasTreinamento)}\n]";
        }
    }
}
