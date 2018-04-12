using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alexandre.Cliente
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


    }
}
