using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = " “Se continuarmos desenvolvendo nossa tecnologia sem sabedoria ou prudência, " +
                             "nosso servo pode acabar se tornando nosso carrasco”. ";

            string autor = "Omar Bradley – general do exército dos EUA";

            //imprime concatenando as frases
            Console.WriteLine("Frase : {0} \n Autor : {1}", frase, autor);


            //Quebrando a string num array
            string[] token = frase.Split(' ');
            foreach (string s in token) {
                //transforma em letras MAIUSCULAS
                Console.WriteLine(s.ToUpper());
            }
            
            //Substituindo caracteres com replace
            string novaFrase = frase.Replace('a', 'X');
            Console.WriteLine("\nNOVA FRASE : \n{0}", novaFrase);

            //Tamanho de uma string
            int tamanho = frase.Length;
            Console.WriteLine("\nTAMANHO : \n{0}", tamanho);

            //Pegando parte de uma string
            string parteDeUmaString = frase.Substring(0, frase.Length - 10);
            Console.WriteLine("\nParte de uma string : \n{0}", parteDeUmaString);

            //Capturando o indice de uma palavra
            int indexOF = frase.IndexOf("n");
            Console.WriteLine("\nindice de uma string : \n{0}", indexOF);

            Console.ReadKey();
        }
    }
}
