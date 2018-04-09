﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_OO_Encapsulamento
{
    class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Cliente { get; set; }
        
        public void Saca(double valor)
        {
            this.Saldo -= valor;
        }

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
