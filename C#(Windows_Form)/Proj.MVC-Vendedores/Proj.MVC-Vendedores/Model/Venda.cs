﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.MVC_Vendedores.Model
{
    public class Venda
    {
        public int Qtde { get; set; }
        public double Valor { get; set; }

        public Venda(int qtde, double valor)
        {
            Qtde = qtde;
            Valor = valor;
        }

        public double ValorMedio()
        {
            return Valor / Qtde;
        }
    }
}
