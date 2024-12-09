using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Medicamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Medicamentos listaMedicamentos = new Medicamentos();
            bool sair = false;

            while (!sair)
            {
               
                Console.Clear();
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("0. Finalizar processo");
                Console.WriteLine("1. Cadastrar medicamento");
                Console.WriteLine("2. Consultar medicamento (sintético)");
                Console.WriteLine("3. Consultar medicamento (analítico)");
                Console.WriteLine("4. Comprar medicamento (cadastrar lote)");
                Console.WriteLine("5. Vender medicamento (abater do lote mais antigo)");
                Console.WriteLine("6. Listar medicamentos (informando dados sintéticos)");
                Console.Write("Opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "0":
                        sair = true;
                        break;

                    case "1":
                        CadastrarMedicamento(listaMedicamentos);
                        break;

                    case "2":
                        ConsultarMedicamentoSintetico(listaMedicamentos);
                        break;

                    case "3":
                        ConsultarMedicamentoAnalitico(listaMedicamentos);
                        break;

                    case "4":
                        ComprarMedicamento(listaMedicamentos);
                        break;

                    case "5":
                        VenderMedicamento(listaMedicamentos);
                        break;

                    case "6":
                        ListarMedicamentosSinteticos(listaMedicamentos);
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

        static void CadastrarMedicamento(Medicamentos listaMedicamentos)
        {
            Console.WriteLine("\nCadastro de Medicamento");
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Laboratório: ");
            string laboratorio = Console.ReadLine();

            Medicamento medicamento = new Medicamento(id, nome, laboratorio, new Queue<Lote>());
            listaMedicamentos.adicionar(medicamento);

            Console.WriteLine($"Medicamento {nome} cadastrado com sucesso!");
            Console.WriteLine("\n\nPressione  enter para continuar...");
            Console.ReadLine();
        }
        static void ConsultarMedicamentoSintetico(Medicamentos listaMedicamentos)
        {
            Console.WriteLine("\nConsultar Medicamento (Sintético)");
            Console.Write("Informe o ID do medicamento: ");
            int id = int.Parse(Console.ReadLine());
            Medicamento medicamento = listaMedicamentos.pesquisar(new Medicamento { Id = id });

            if (medicamento.Id != 0)
            {
                Console.WriteLine($"Medicamento encontrado: {medicamento.toString()}");
            }
            else
            {
                Console.WriteLine("Medicamento não encontrado.");
            }
            Console.WriteLine("\n\nPressione  enter para continuar...");
            Console.ReadLine();
        }

        static void ConsultarMedicamentoAnalitico(Medicamentos listaMedicamentos)
        {
            Console.WriteLine("\nConsultar Medicamento (Analítico)");
            Console.Write("Informe o ID do medicamento: ");
            int id = int.Parse(Console.ReadLine());
            Medicamento medicamento = listaMedicamentos.pesquisar(new Medicamento { Id = id });

            if (medicamento.Id != 0)
            {
                Console.WriteLine($"Medicamento encontrado: {medicamento.toString()}");

                Console.WriteLine("\nLotes:");
                foreach (Lote lote in medicamento.Lotes)
                {
                    Console.WriteLine($"ID: {lote.Id}, Qtde: {lote.Qtde}, Vencimento: {lote.Venc.ToShortDateString()}");
                }
            }
            else
            {
                Console.WriteLine("Medicamento não encontrado.");
            }
            Console.WriteLine("\n\nPressione  enter para continuar...");
            Console.ReadLine();
        }

        static void ComprarMedicamento(Medicamentos listaMedicamentos)
        {
            Console.WriteLine("\nComprar Medicamento (Cadastrar Lote)");
            Console.Write("Informe o ID do medicamento: ");
            int id = int.Parse(Console.ReadLine());
            Medicamento medicamento = listaMedicamentos.pesquisar(new Medicamento { Id = id });

            if (medicamento.Id != 0)
            {
                Console.Write("Informe o ID do lote: ");
                int loteId = int.Parse(Console.ReadLine());
                Console.Write("Informe a quantidade do lote: ");
                int qtde = int.Parse(Console.ReadLine());
                Console.Write("Informe a data de vencimento (dd/MM/yyyy): ");
                DateTime vencimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                Lote lote = new Lote(loteId, qtde, vencimento);
                medicamento.comprar(lote);

                Console.WriteLine("Lote cadastrado com sucesso.");
            }
            else
            {
                Console.WriteLine("Medicamento não encontrado.");
            }
            Console.WriteLine("\n\nPressione  enter para continuar...");
            Console.ReadLine();
        }
        static void VenderMedicamento(Medicamentos listaMedicamentos)
        {
            Console.WriteLine("\nVender Medicamento (Abater do Lote Mais Antigo)");
            Console.Write("Informe o ID do medicamento: ");
            int id = int.Parse(Console.ReadLine());
            Medicamento medicamento = listaMedicamentos.pesquisar(new Medicamento { Id = id });

            if (medicamento.Id != 0)
            {
                Console.Write("Informe a quantidade a ser vendida: ");
                int qtde = int.Parse(Console.ReadLine());

                bool vendido = medicamento.vender(qtde);

                if (vendido)
                {
                    Console.WriteLine("Medicamento vendido com sucesso.");
                }
                else
                {
                    Console.WriteLine("Não foi possível vender o medicamento.");
                }
            }
            else
            {
                Console.WriteLine("Medicamento não encontrado.");
            }
            Console.WriteLine("\n\nPressione  enter para continuar...");
            Console.ReadLine();
        }

        static void ListarMedicamentosSinteticos(Medicamentos listaMedicamentos)
        {
            Console.WriteLine("\nListar Medicamentos (Sintéticos)");
            foreach (var medicamento in listaMedicamentos.ListaMedicamento)
            {
                Console.WriteLine(medicamento.toString());
            }
            Console.WriteLine("\n\nPressione enter para continuar...");
            Console.ReadLine();
        }
    }
}
