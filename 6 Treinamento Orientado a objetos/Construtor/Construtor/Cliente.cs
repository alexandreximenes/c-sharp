﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Construtor
{
    class Cliente
    {
        public String nome { get; set; }
        public Cliente(String nome)
        {
            this.nome = nome;
        }
    }
}
