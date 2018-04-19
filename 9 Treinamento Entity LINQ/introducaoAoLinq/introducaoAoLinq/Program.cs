using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introducaoAoLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var generos = new List<Genero>
            {
                new Genero{ Id = 1, Nome = "Rock"},
                new Genero{ Id = 2, Nome = "Reggae"},
                new Genero{ Id = 3, Nome = "Rock Progressivo"},
                new Genero{ Id = 4, Nome = "Punk Rock"},
                new Genero{ Id = 5, Nome = "Classica"}
            };

            var query = from g in generos
                        where g.Nome.Contains("Rock")
                        select g;

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
    class Genero
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return $"{Id}\t{Nome}";
        }
    }
}
