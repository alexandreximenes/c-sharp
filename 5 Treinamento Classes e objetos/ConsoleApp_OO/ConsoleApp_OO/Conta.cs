﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_OO
{
    class Conta
    {
        public double saldo;
        public Cliente cliente;


        public void Saca(double valor) {
            this.saldo -= valor;
        }

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public void Transfere(double valor, Conta destino) {
            this.Saca(valor);
            destino.Deposita(valor);
        }

        
    }
}
