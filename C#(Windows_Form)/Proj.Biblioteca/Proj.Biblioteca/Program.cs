using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Biblioteca
{
    using System;

    class Program
    {
        static Livros acervo = new Livros();

        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Adicionar livro");
                Console.WriteLine("2. Pesquisar livro (sintético)");
                Console.WriteLine("3. Pesquisar livro (analítico)");
                Console.WriteLine("4. Adicionar exemplar");
                Console.WriteLine("5. Registrar empréstimo");
                Console.WriteLine("6. Registrar devolução");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarLivro();
                        break;
                    case 2:
                        PesquisarLivroSintetico();
                        break;
                    case 3:
                        PesquisarLivroAnalitico();
                        break;
                    case 4:
                        AdicionarExemplar();
                        break;
                    case 5:
                        RegistrarEmprestimo();
                        break;
                    case 6:
                        RegistrarDevolucao();
                        break;
                }
            } while (opcao != 0);
        }
        static void AdicionarLivro()
        {
            Console.Write("ISBN: ");
            int isbn = int.Parse(Console.ReadLine());
            Console.Write("Título: ");
            string titulo = Console.ReadLine();
            Console.Write("Autor: ");
            string autor = Console.ReadLine();
            Console.Write("Editora: ");
            string editora = Console.ReadLine();

            Livro novoLivro = new Livro(isbn, titulo, autor, editora);
            acervo.Adicionar(novoLivro);

            Console.WriteLine("Livro adicionado com sucesso!");
        }

        static void PesquisarLivroSintetico()
        {
            Console.Write("Digite o ISBN do livro: ");
            int isbn = int.Parse(Console.ReadLine());

            Livro livro = acervo.Pesquisar(isbn);

            if (livro != null)
            {
                Console.WriteLine(livro.ToString());
                Console.WriteLine($"Quantidade de Exemplares: {livro.QtdeExemplares()}");
                Console.WriteLine($"Exemplares Disponíveis: {livro.QtdeDisponiveis()}");
                Console.WriteLine($"Total de Empréstimos: {livro.QtdeEmprestimos()}");
                Console.WriteLine($"Percentual de Disponibilidade: {livro.PercDisponibilidade():F2}%");
            }
            else
            {
                Console.WriteLine("Livro não encontrado.");
            }
        }

        static void PesquisarLivroAnalitico()
        {
            Console.Write("Digite o ISBN do livro: ");
            int isbn = int.Parse(Console.ReadLine());

            Livro livro = acervo.Pesquisar(isbn);

            if (livro != null)
            {
                Console.WriteLine(livro.ToString());
                Console.WriteLine($"Quantidade de Exemplares: {livro.QtdeExemplares()}");
                Console.WriteLine($"Exemplares Disponíveis: {livro.QtdeDisponiveis()}");
                Console.WriteLine($"Total de Empréstimos: {livro.QtdeEmprestimos()}");
                Console.WriteLine($"Percentual de Disponibilidade: {livro.PercDisponibilidade():F2}%");

                foreach (var exemplar in livro.Exemplares)
                {
                    Console.WriteLine($"Exemplar Tombo: {exemplar.Tombo}, Disponível: {exemplar.Disponivel()}, Empréstimos: {exemplar.QtdeEmprestimos()}");
                    foreach (Emprestimo emprestimo in exemplar.Emprestimos)
                    {
                        Console.WriteLine($"- Empréstimo: {emprestimo.DtEmprestimo}, Devolução: {(emprestimo.DtDevolucao == DateTime.MinValue ? "Não devolvido" : emprestimo.DtDevolucao.ToString())}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Livro não encontrado.");
            }
        }

        static void AdicionarExemplar()
        {
            Console.Write("Digite o ISBN do livro: ");
            int isbn = int.Parse(Console.ReadLine());

            Livro livro = acervo.Pesquisar(isbn);

            if (livro != null)
            {
                Console.Write("Digite o tombo do novo exemplar: ");
                int tombo = int.Parse(Console.ReadLine());

                Exemplar novoExemplar = new Exemplar(tombo);
                livro.AdicionarExemplar(novoExemplar);

                Console.WriteLine("Exemplar adicionado com sucesso!");
            }
            else
            {
                Console.WriteLine("Livro não encontrado.");
            }
        }

        static void RegistrarEmprestimo()
        {
            Console.Write("Digite o ISBN do livro: ");
            int isbn = int.Parse(Console.ReadLine());

            Livro livro = acervo.Pesquisar(isbn);

            if (livro != null)
            {
                Console.Write("Digite o tombo do exemplar: ");
                int tombo = int.Parse(Console.ReadLine());

                Exemplar exemplar = livro.Exemplares.Find(e => e.Tombo == tombo);

                if (exemplar != null && exemplar.Emprestar())
                {
                    Console.WriteLine("Empréstimo registrado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Exemplar indisponível para empréstimo.");
                }
            }
            else
            {
                Console.WriteLine("Livro não encontrado.");
            }
        }

        static void RegistrarDevolucao()
        {
            Console.Write("Digite o ISBN do livro: ");
            int isbn = int.Parse(Console.ReadLine());

            Livro livro = acervo.Pesquisar(isbn);

            if (livro != null)
            {
                Console.Write("Digite o tombo do exemplar: ");
                int tombo = int.Parse(Console.ReadLine());

                Exemplar exemplar = livro.Exemplares.Find(e => e.Tombo == tombo);

                if (exemplar != null && exemplar.Devolver())
                {
                    Console.WriteLine("Devolução registrada com sucesso!");
                }
                else
                {
                    Console.WriteLine("Exemplar não está emprestado.");
                }
            }
            else
            {
                Console.WriteLine("Livro não encontrado.");
            }
        }

    }

}
