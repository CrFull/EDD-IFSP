using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Acesso
{
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Script para criação da base em Mysql no arquivo mysql.txt. O usuario padrão usado para a conexão será o root. ");
                Console.Write("Digite o nome da database: ");
                string databaseName = Console.ReadLine();

                Console.Write("Digite a senha do banco de dados: ");
                string password = Console.ReadLine();

                
                string connectionString = $"Server=localhost;Database={databaseName};User Id=root;Password={password};";

                var cadastro = new Cadastro(connectionString);


                cadastro.Download();
                Console.WriteLine("Dados carregados com sucesso!");

                bool executando = true;

                while (executando)
                {
                    Console.WriteLine("\n--- MENU ---");
                    Console.WriteLine("0. Sair");
                    Console.WriteLine("1. Cadastrar ambiente");
                    Console.WriteLine("2. Consultar ambiente");
                    Console.WriteLine("3. Excluir ambiente");
                    Console.WriteLine("4. Cadastrar usuário");
                    Console.WriteLine("5. Consultar usuário");
                    Console.WriteLine("6. Excluir usuário");
                    Console.WriteLine("7. Conceder permissão de acesso ao usuário");
                    Console.WriteLine("8. Revogar permissão de acesso ao usuário");
                    Console.WriteLine("9. Registrar acesso");
                    Console.WriteLine("10. Consultar logs de acesso");
                    Console.Write("Escolha uma opção: ");

                    if (int.TryParse(Console.ReadLine(), out int opcao))
                    {
                        switch (opcao)
                        {
                            case 0:
                                Console.WriteLine("Salvando dados...");
                                cadastro.Upload();
                                Console.WriteLine("Dados salvos com sucesso. Encerrando...");
                                executando = false;
                                break;

                            case 1:
                                Console.Write("Digite o nome do ambiente: ");
                                string nomeAmbiente = Console.ReadLine();
                                int idAmbiente = cadastro.Ambientes.Count + 1;
                                var novoAmbiente = new Ambiente(idAmbiente, nomeAmbiente, new Queue<Log>());
                                cadastro.AdicionarAmbiente(novoAmbiente);
                                Console.WriteLine("Ambiente cadastrado com sucesso!");
                                break;

                            case 2:
                                Console.Write("Digite o ID do ambiente: ");
                                if (int.TryParse(Console.ReadLine(), out int idConsultaAmbiente))
                                {
                                    var ambiente = cadastro.Ambientes.Find(a => a.Id == idConsultaAmbiente);
                                    if (ambiente != null)
                                    {
                                        Console.WriteLine($"Ambiente encontrado: ID={ambiente.Id}, Nome={ambiente.Nome}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ambiente não encontrado.");
                                    }
                                }
                                break;

                            case 3:
                                Console.Write("Digite o ID do ambiente para exclusão: ");
                                if (int.TryParse(Console.ReadLine(), out int idExcluirAmbiente))
                                {
                                    var ambiente = cadastro.Ambientes.Find(a => a.Id == idExcluirAmbiente);
                                    if (ambiente != null && cadastro.RemoverAmbiente(ambiente))
                                    {
                                        Console.WriteLine("Ambiente excluído com sucesso.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Falha ao excluir o ambiente.");
                                    }
                                }
                                break;

                            case 4:
                                Console.Write("Digite o nome do usuário: ");
                                string nomeUsuario = Console.ReadLine();
                                int idUsuario = cadastro.Usuarios.Count + 1;
                                var novoUsuario = new Usuario(idUsuario, nomeUsuario, new List<Ambiente>());
                                cadastro.AdicionarUsuario(novoUsuario);
                                Console.WriteLine("Usuário cadastrado com sucesso!");
                                break;

                            case 5:
                                Console.Write("Digite o ID do usuário: ");
                                if (int.TryParse(Console.ReadLine(), out int idConsultaUsuario))
                                {
                                    var usuario = cadastro.Usuarios.Find(u => u.Id == idConsultaUsuario);
                                    if (usuario != null)
                                    {
                                        Console.WriteLine($"Usuário encontrado: ID={usuario.Id}, Nome={usuario.Name}");
                                        Console.WriteLine("Permissões:");
                                        usuario.Ambientes.ForEach(a => Console.WriteLine($"- {a.Nome}"));
                                    }
                                    else
                                    {
                                        Console.WriteLine("Usuário não encontrado.");
                                    }
                                }
                                break;

                            case 6:
                                Console.Write("Digite o ID do usuário para exclusão: ");
                                if (int.TryParse(Console.ReadLine(), out int idExcluirUsuario))
                                {
                                    var usuario = cadastro.Usuarios.Find(u => u.Id == idExcluirUsuario);
                                    if (usuario != null && cadastro.RemoverUsuario(usuario))
                                    {
                                        Console.WriteLine("Usuário excluído com sucesso.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Falha ao excluir o usuário.");
                                    }
                                }
                                break;

                            case 7:
                                Console.Write("Digite o ID do usuário: ");
                                if (int.TryParse(Console.ReadLine(), out int idUsuarioPermissao))
                                {
                                    var usuario = cadastro.Usuarios.Find(u => u.Id == idUsuarioPermissao);
                                    if (usuario != null)
                                    {
                                        Console.Write("Digite o ID do ambiente: ");
                                        if (int.TryParse(Console.ReadLine(), out int idAmbientePermissao))
                                        {
                                            var ambiente = cadastro.Ambientes.Find(a => a.Id == idAmbientePermissao);
                                            if (ambiente != null && usuario.concederPermissao(ambiente))
                                            {
                                                Console.WriteLine("Permissão concedida com sucesso.");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Falha ao conceder permissão.");
                                            }
                                        }
                                    }
                                }
                                break;

                            case 8:
                                Console.Write("Digite o ID do usuário: ");
                                if (int.TryParse(Console.ReadLine(), out int idUsuarioRevogar))
                                {
                                    var usuario = cadastro.Usuarios.Find(u => u.Id == idUsuarioRevogar);
                                    if (usuario != null)
                                    {
                                        Console.Write("Digite o ID do ambiente: ");
                                        if (int.TryParse(Console.ReadLine(), out int idAmbienteRevogar))
                                        {
                                            var ambiente = cadastro.Ambientes.Find(a => a.Id == idAmbienteRevogar);
                                            if (ambiente != null && usuario.revogarPermissao(ambiente))
                                            {
                                                Console.WriteLine("Permissão revogada com sucesso.");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Falha ao revogar permissão.");
                                            }
                                        }
                                    }
                                }
                                break;

                            case 9:
                                Console.Write("Digite o ID do usuário: ");
                                if (int.TryParse(Console.ReadLine(), out int idUsuarioLog))
                                {
                                    var usuario = cadastro.Usuarios.Find(u => u.Id == idUsuarioLog);
                                    if (usuario != null)
                                    {
                                        Console.Write("Digite o ID do ambiente: ");
                                        if (int.TryParse(Console.ReadLine(), out int idAmbienteLog))
                                        {
                                            var ambiente = cadastro.Ambientes.Find(a => a.Id == idAmbienteLog);
                                            if (ambiente != null)
                                            {
                                                bool autorizado = usuario.Ambientes.Contains(ambiente);
                                                var log = new Log(DateTime.Now, usuario, autorizado);
                                                ambiente.registrarLogs(log);
                                                Console.WriteLine(autorizado ? "Acesso autorizado." : "Acesso negado.");
                                            }
                                        }
                                    }
                                }
                                break;

                            case 10:
                                Console.Write("Digite o ID do ambiente: ");
                                if (int.TryParse(Console.ReadLine(), out int idAmbienteLogs))
                                {
                                    var ambiente = cadastro.Ambientes.Find(a => a.Id == idAmbienteLogs);
                                    if (ambiente != null)
                                    {
                                        Console.WriteLine("Filtrar logs por:");
                                        Console.WriteLine("1. Autorizados");
                                        Console.WriteLine("2. Negados");
                                        Console.WriteLine("3. Todos");
                                        if (int.TryParse(Console.ReadLine(), out int filtroLogs))
                                        {
                                        List<Log> logs;

                                        switch (filtroLogs)
                                        {
                                            case 1:
                                                logs = ambiente.Logs.Where(l => l.TipoAcesso).ToList();
                                                Console.WriteLine("Exibindo apenas logs autorizados:");
                                                break;
                                            case 2:
                                                logs = ambiente.Logs.Where(l => !l.TipoAcesso).ToList();
                                                Console.WriteLine("Exibindo apenas logs negados:");
                                                break;
                                            default:
                                                logs = ambiente.Logs.ToList();
                                                Console.WriteLine("Exibindo todos os logs:");
                                                break;
                                        }

                                        if (logs.Count > 0)
                                        {
                                            logs.ForEach(l =>
                                                Console.WriteLine(
                                                    $"{l.DtAcesso:G} - {(l.TipoAcesso ? "Autorizado" : "Negado")} - Usuário: {l.Usuario.Name}")
                                            );
                                        }
                                        else
                                        {
                                            Console.WriteLine("Nenhum log encontrado para o filtro selecionado.");
                                        }
                                    }
                                    }
                                }
                                break;

                            default:
                                Console.WriteLine("Opção inválida.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Tente novamente.");
                    }
                }
            }
        }

    }
