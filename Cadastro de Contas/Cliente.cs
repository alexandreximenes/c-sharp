using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasContas
{
    class Cliente
    {
        public int Numero { get; }
        public string Nome { get; }

        public Cliente(int numero, string nome)
        {
            try
            {
                this.Numero = numero;
                this.Nome = nome;
            }
            catch (Exception e)
            {
                Console.WriteLine("Não foi possivel capturar os campos do cliente");
            }
        
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            Cliente outro = obj as Cliente;

            if (outro.Nome.Equals(outro.Nome))
            {
                return true;        
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.Nome.GetHashCode();
        }


    }
}
