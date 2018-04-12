using System;
using System.Collections.Generic;
using System.Text;

namespace app
{
    class Cliente
    {
        public String Nome { private get; set; }
        public int Idade { get; set; }
        public bool EEmancipado { get; set; }
        public string Cpf { get; set; }
        public const int IDADE_MINIMA = 18;

        public Cliente(String nome, int idade, bool EEmancipado, string cpf)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.EEmancipado = EEmancipado;
            this.Cpf = cpf;
        }


        public bool PodeAbrirConta() {
            //Tipagem implicita -> var
            var maiorDeIdade = (this.Idade >= IDADE_MINIMA);
            var EEmancipado = (this.EEmancipado);
            // verifica se o valor NÃO é nulo ou vazio
            var temCpf = !string.IsNullOrEmpty(this.Cpf);

            return (maiorDeIdade || EEmancipado) && temCpf;
        }

    }
}
