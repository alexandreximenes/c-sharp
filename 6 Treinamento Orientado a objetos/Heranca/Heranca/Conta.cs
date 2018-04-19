using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    // Definindo a classe conta como generica para não ser instanciada.
    abstract class Conta
    {
        public int Numero { get; set; }
        //Nivel de acesso protected para ser acessado pelas contas que herdam dessa Conta
        public double Saldo { get; protected set; }
        public Cliente Cliente { get; set; }

        public abstract void Saca(double valor);
        //{
          //  this.Saldo -= valor;
        //}

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }
    }
}
