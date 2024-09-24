using Proj.MVC_Vendedores.Controller;
using Proj.MVC_Vendedores.Model;
using System.Text;

namespace Proj.MVC_Vendedores
{
    public partial class Form1 : Form
    {
        private VendedoresController controller;
        public Form1()
        {
            InitializeComponent();
            this.controller = controller;
        }
        private void btnRegistrarVenda_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdVendedor.Text);
            int dia = int.Parse(txtDia.Text);
            int qtde = int.Parse(txtQtde.Text);
            double valor = double.Parse(txtValor.Text);

            bool sucesso = controller.RegistrarVenda(id, dia, qtde, valor);
            if (sucesso)
            {
                MessageBox.Show("Vendedor cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar. Limite de vendedores atingido.");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdVendedor.Text);

            Vendedor vendedor = controller.ConsultarVendedor(id);
            if (vendedor != null)
            {

                double totalDiasComVendas = vendedor.AsVendas.Count(v => v != null);

                string message = $"Nome: {vendedor.Nome}\n" +
                                 $"Valor Total de Vendas: {vendedor.ValorVendas().ToString("C")}\n" +
                                 $"Comissão: {vendedor.ValorComissao().ToString("C")}\n" +
                                 $"Valor Médio das Vendas Diárias: {(totalDiasComVendas > 0 ? (vendedor.ValorVendas() / totalDiasComVendas).ToString("C") : "Sem vendas")}";
                MessageBox.Show(message, "Informações do Vendedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vendedor não encontrado.");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdVendedor.Text);

            bool sucesso = controller.ExcluirVendedor(id);
            if (sucesso)
            {
                MessageBox.Show("Vendedor excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao excluir. O vendedor pode ter vendas registradas ou não foi encontrado.");
            }
        }

        private void btnListarVendedores_Click_1(object sender, EventArgs e)
        {
            IEnumerable<Vendedor> vendedores = controller.ListarVendedores();

            if (vendedores.Any())
            {
                StringBuilder message = new StringBuilder();
                double valorDeVendasDeTodosOsVendedores = 0;
                foreach (Vendedor vendedor in vendedores)
                {
                    message.AppendLine($"ID: {vendedor.Id}");
                    message.AppendLine($"Nome: {vendedor.Nome}");
                    message.AppendLine($"Valor Total de Vendas: {vendedor.ValorVendas().ToString("C")}");
                    valorDeVendasDeTodosOsVendedores += vendedor.ValorVendas();
                    message.AppendLine($"Comissão: {vendedor.ValorComissao().ToString("C")}");
                    message.AppendLine(new string('-', 30));
                }

                MessageBox.Show(message.ToString() + valorDeVendasDeTodosOsVendedores.ToString(), "Lista de Vendedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nenhum vendedor cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdVendedor.Text);
            string nome = txtNomeVendedor.Text;
            double percComissao = double.Parse(txtComissao.Text);

            bool sucesso = controller.CadastrarVendedor(id, nome, percComissao);
            if (sucesso)
            {
                MessageBox.Show("Vendedor cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar. Limite de vendedores atingido.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
