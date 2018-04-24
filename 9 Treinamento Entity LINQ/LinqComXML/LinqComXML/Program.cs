using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqComXML
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement root = XElement.Load(@"Tunes.xml");

            var queryXML = from g in root.Element("Generos").Elements("Genero")
                           select g;
            
            foreach (var genero in queryXML) {
                Console.WriteLine(genero.Element("GeneroId").Value +"\t"+ genero.Element("Nome").Value);
            }

            var query = from g in root.Element("Generos").Elements("Genero")
                        join m in root.Element("Musicas").Elements("Musica")
                        on g.Element("GeneroId").Value equals m.Element("GeneroId").Value
                        select new
                        {
                            Musica = m.Element("Nome").Value,
                            Genero = g.Element("Nome").Value
                        };

            Console.WriteLine();
            foreach (var mg in query)
            {
                Console.WriteLine("{0}\t{1}",mg.Musica, mg.Genero);
            }

            Console.ReadKey();
        }
    }
}
