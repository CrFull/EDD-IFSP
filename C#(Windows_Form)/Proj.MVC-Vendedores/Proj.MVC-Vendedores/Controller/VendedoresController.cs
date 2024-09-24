using Proj.MVC_Vendedores.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.MVC_Vendedores.Controller
{
    public class VendedoresController
    {
        private Vendedores vendedores;

        public VendedoresController()
        {
            vendedores = new Vendedores(10);
        }

        public bool CadastrarVendedor(int id, string nome, double percComissao)
        {
            Vendedor vendedor = new Vendedor(id, nome, percComissao);
            bool isCreated = vendedores.AddVendedor(vendedor);
            return isCreated;
        }

        public Vendedor ConsultarVendedor(int id)
        {
            return vendedores.SearchVendedor(id);
        }

        public bool ExcluirVendedor(int id)
        {
            return vendedores.DelVendedor(id);
        }

        public bool RegistrarVenda(int id, int dia, int qtde, double valor)
        {
            Vendedor vendedor = vendedores.SearchVendedor(id);
            if (vendedor != null)
            {
                var venda = new Venda(qtde, valor);
                return vendedor.RegistrarVenda(dia, venda);
            }
            return false;
        }

        public IEnumerable<Vendedor> ListarVendedores()
        {
            return vendedores.OsVendedores.Where(v => v != null);
        }

        public double TotalVendas()
        {
            return vendedores.ValorVendas();
        }

        public double TotalComissoes()
        {
            return vendedores.ValorComissao();
        }
    }
}
