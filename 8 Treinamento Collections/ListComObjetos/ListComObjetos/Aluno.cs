namespace ListComObjetos
{
    class Aluno
    {
        private string nome;
        private int matricula;

        public Aluno(string nome, int matricula)
        {
            this.nome = nome;
            this.matricula = matricula;
        }

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public override bool Equals(object obj)
        {
            Aluno outro = obj as Aluno;
            if (outro == null)
            {
                return false;
            }
            return this.Matricula.Equals(outro.Matricula);
        }

        public override int GetHashCode()
        {
            return this.Nome.GetHashCode();
        }

        public override string ToString()
        {
            return $"[Aluno: {Nome}, matricula: {Matricula}]";
        }

    }
}