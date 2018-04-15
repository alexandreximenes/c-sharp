using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Trabalhando com Sets
             */

            ISet<string> frases = new HashSet<string>();
            frases.Add("Não permitem duplicados");
            frases.Add("Não permitem duplicados");
            frases.Add("Sets não garantem ordenação");
            frases.Add("Sets são mais rapidos para pesquisa do que List");
            
            Console.WriteLine(string.Join(",\n", frases));
            Console.WriteLine("Tamanho: "+frases.Count);

            List<string> copiaFrases = new List<string>(frases);
            copiaFrases.Reverse();
            copiaFrases.ForEach(c => Console.WriteLine(c));
            
            

            Console.ReadKey();
        }
    }
}
