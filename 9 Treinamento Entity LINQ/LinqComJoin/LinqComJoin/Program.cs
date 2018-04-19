using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqComJoin
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
            
            var Musicas = new List<Musica>
            {
                new Musica{ Id = 1, Nome = "Rock", GeneroId = 1},
                new Musica{ Id = 2, Nome = "Reggae", GeneroId = 2},
                new Musica{ Id = 3, Nome = "Rock Progressivo", GeneroId = 3},
                new Musica{ Id = 4, Nome = "Punk Rock", GeneroId = 4},
                new Musica{ Id = 5, Nome = "Classica", GeneroId = 5}
            };

            var queryMusica = from m in Musicas
                              join g in generos on m.GeneroId equals g.Id
                              select new { m, g };

            Console.WriteLine();
            foreach (var musica in queryMusica)
            {
                Console.WriteLine("\t{0}\t{1}\t{2}", musica.m.Id, musica.m.Nome, musica.g.Nome);
            }


            Console.ReadKey();

        }

    }
    }

    class Genero
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return $"\t{Id}\t{Nome}";
        }
    }

    class Musica
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int GeneroId { get; set; }
    
    }
