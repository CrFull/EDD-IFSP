using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.MVC_Vendedores.Model
{
    public class Vendedores
    {
        public Vendedor[] OsVendedores { get; set; }
        public int Max { get; set; }
        public int Qtde { get; set; }

        public Vendedores(int max)
        {
            Max = max;
            OsVendedores = new Vendedor[max];
            Qtde = 0;
        }

        public bool AddVendedor(Vendedor vendedor)
        {
            if (Qtde < Max)
            {
                OsVendedores[Qtde] = vendedor;
                Qtde++;
                return true;
            }
            return false;
        }

        public bool DelVendedor(int id)
        {
            for (int i = 0; i < Qtde; i++)
            {
                if (OsVendedores[i].Id == id && OsVendedores[i].ValorVendas() == 0)
                {
                    OsVendedores[i] = OsVendedores[Qtde - 1];
                    OsVendedores[Qtde - 1] = null;
                    Qtde--;
                    return true;
                }
            }
            return false;
        }

        public Vendedor SearchVendedor(int id)
        {
            return OsVendedores.FirstOrDefault(v => v?.Id == id);
        }

        public double ValorVendas()
        {
            return OsVendedores.Where(v => v != null).Sum(v => v.ValorVendas());
        }

        public double ValorComissao()
        {
            return OsVendedores.Where(v => v != null).Sum(v => v.ValorComissao());
        }
    }
}
