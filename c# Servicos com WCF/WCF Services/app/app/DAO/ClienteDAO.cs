using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DAO
{
    class ClienteDAO
    {
        private static List<Cliente> clientes = new List<Cliente>(0);

        public void add(Cliente c) {
            ClienteDAO.clientes.Add(c);
        }

        public Cliente buscar(string nome) {
            //trazer somente 1 resultado
            var resultado = ClienteDAO.clientes.Where(c => c.Nome.Equals(nome)).FirstOrDefault();
            //var resultado = from c in clientes where c.nome.Equals(nome) select c;
            return (Cliente) resultado;
        }
    }
}
