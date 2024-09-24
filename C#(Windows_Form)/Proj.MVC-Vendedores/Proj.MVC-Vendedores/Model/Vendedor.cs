using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.MVC_Vendedores.Model
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double PercComissao { get; set; }
        public Venda[] AsVendas { get; set; }

        public Vendedor(int id, string nome, double percComissao)
        {
            Id = id;
            Nome = nome;
            PercComissao = percComissao;
            AsVendas = new Venda[31];
        }

        public bool RegistrarVenda(int dia, Venda venda)
        {
            if (dia >= 1 && dia <= 31)
            {
                AsVendas[dia - 1] = venda;
                return true;
            }
            return false;
        }

        public double ValorVendas()
        {
            double total = 0;
            foreach (Venda venda in AsVendas)
            {
                if (venda != null)
                {
                    total += venda.Valor;
                }
            }
            return total;
        }

        public double ValorComissao()
        {
            return ValorVendas() * PercComissao / 100;
        }
    }
}
