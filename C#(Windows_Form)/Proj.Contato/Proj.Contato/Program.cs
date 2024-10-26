using System;

namespace Proj.Contato
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int opcao;
            Contatos c = new Contatos();
            do
            {
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Adicionar contato");
                Console.WriteLine("2. Pesquisar contato");
                Console.WriteLine("3. Alterar contato");
                Console.WriteLine("4. Remover contato");
                Console.WriteLine("5. Listar contatos");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarContato(c);
                        break;
                    case 2:
                        PesquisarContato(c);
                        break;
                    case 3:
                        AlterarContato(c);
                        break;
                    case 4:
                        RemoverContato(c);
                        break;
                    case 5:
                        ListarContatos(c);
                        break;
                }
            } while (opcao != 0);
        }

        static void AdicionarContato(Contatos contatos)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de Nascimento (dd mm aaaa): ");
            string[] data = Console.ReadLine().Split();
            Data dtNasc = new Data(int.Parse(data[0]), int.Parse(data[1]), int.Parse(data[2]));
            Contato novoContato = new Contato(email, nome, dtNasc);

            Console.Write("Telefone (Tipo): ");
            string tipo = Console.ReadLine();
            Console.Write("Número: ");
            string numero = Console.ReadLine();
            Console.Write("É o telefone principal? (s/n): ");
            bool principal = Console.ReadLine().ToLower() == "s";
            Telefone telefone = new Telefone(tipo, numero, principal);

            novoContato.AdicionarTelefone(telefone);
            contatos.Adicionar(novoContato);
        }

        static void PesquisarContato(Contatos contatos)
        {
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Contato pesquisa = new Contato(email, "", null);
            Contato resultado = contatos.Pesquisar(pesquisa);
            if (resultado != null)
            {
                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }
        }

        static void AlterarContato(Contatos contatos)
        {
            Console.Write("Email do contato a ser alterado: ");
            string email = Console.ReadLine();
            Contato pesquisa = new Contato(email, "", null);
            Contato contatoExistente = contatos.Pesquisar(pesquisa);

            if (contatoExistente != null)
            {
                Console.Write("Novo Nome: ");
                string novoNome = Console.ReadLine();
                Console.Write("Nova Data de Nascimento (dd mm aaaa): ");
                string[] data = Console.ReadLine().Split();
                Data novaData = new Data(int.Parse(data[0]), int.Parse(data[1]), int.Parse(data[2]));

                contatoExistente.Nome = novoNome;
                contatoExistente.DtNasc = novaData;
                contatos.Alterar(contatoExistente);
                Console.WriteLine("Contato alterado com sucesso!");
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }
        }

        static void RemoverContato(Contatos contatos)
        {
            Console.Write("Email do contato a ser removido: ");
            string email = Console.ReadLine();
            Contato pesquisa = new Contato(email, "", null);
            if (contatos.Remover(pesquisa))
            {
                Console.WriteLine("Contato removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }
        }

        static void ListarContatos(Contatos contatos)
        {
            foreach (Contato contato in contatos.Listar())
            {
                Console.WriteLine(contato);
            }
        }
    }
}
    
