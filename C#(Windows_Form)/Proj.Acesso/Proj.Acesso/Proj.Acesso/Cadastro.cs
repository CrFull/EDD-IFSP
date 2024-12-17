using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Proj.Acesso
{
    class Cadastro
    {
        private readonly MySqlConnection _connection;
        private List<Usuario> usuarios;
        private List<Ambiente> ambientes;

        internal List<Usuario> Usuarios { get => usuarios; set => usuarios = value; }
        internal List<Ambiente> Ambientes { get => ambientes; set => ambientes = value; }

        public Cadastro(string connectionString)
        {
            Usuarios = new List<Usuario>();
            Ambientes = new List<Ambiente>();
            _connection = new MySqlConnection(connectionString);
        }

        public void AdicionarUsuario(Usuario usuario)
        {
            if (!Usuarios.Contains(usuario))
            {
                Usuarios.Add(usuario);
            }
        }

        public bool RemoverUsuario(Usuario usuario)
        {
            return Usuarios.Remove(usuario);
        }

        public Usuario PesquisarUsuario(Usuario usuario)
        {
            return Usuarios.Find(u => u.Id == usuario.Id);
        }

        public void AdicionarAmbiente(Ambiente ambiente)
        {
            if (!Ambientes.Contains(ambiente))
            {
                Ambientes.Add(ambiente);
            }
        }

        public bool RemoverAmbiente(Ambiente ambiente)
        {
            return Ambientes.Remove(ambiente);
        }

        public Ambiente PesquisarAmbiente(Ambiente ambiente)
        {
            return Ambientes.Find(a => a.Id == ambiente.Id);
        }



        public void Upload()
        {
            _connection.Open();

            foreach (var usuario in Usuarios)
            {
                string queryUsuario = "INSERT INTO usuarios (id, nome) VALUES (@id, @nome) " +
                                      "ON DUPLICATE KEY UPDATE nome = @nome";
                var cmdUsuario = new MySqlCommand(queryUsuario, _connection);
                cmdUsuario.Parameters.AddWithValue("@id", usuario.Id);
                cmdUsuario.Parameters.AddWithValue("@nome", usuario.Name);
                cmdUsuario.ExecuteNonQuery();

            }


            foreach (var ambiente in Ambientes)
            {
                try
                {
                    string queryAmbiente = "INSERT INTO ambientes (id, nome) VALUES (@id, @nome) " +
                                           "ON DUPLICATE KEY UPDATE nome = @nome";
                    var cmdAmbiente = new MySqlCommand(queryAmbiente, _connection);
                    cmdAmbiente.Parameters.AddWithValue("@id", ambiente.Id);
                    cmdAmbiente.Parameters.AddWithValue("@nome", ambiente.Nome);
                    cmdAmbiente.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao inserir ambiente: {ex.Message}");
                }

                foreach (var log in ambiente.Logs)
                {
                    try
                    {
                        string queryLog = "INSERT INTO logs (dt_acesso, usuario_id, ambiente_id, tipo_acesso) " +
                                          "VALUES (@dtAcesso, @usuarioId, @ambienteId, @tipoAcesso)";
                        var cmdLog = new MySqlCommand(queryLog, _connection);
                        cmdLog.Parameters.AddWithValue("@dtAcesso", log.DtAcesso);
                        cmdLog.Parameters.AddWithValue("@usuarioId", log.Usuario.Id);
                        cmdLog.Parameters.AddWithValue("@ambienteId", ambiente.Id);
                        cmdLog.Parameters.AddWithValue("@tipoAcesso", log.TipoAcesso);
                        cmdLog.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro ao inserir log: {ex.Message}");
                    }
                }
            }

        }

        public void Download()
        {
            _connection.Open();

            string queryUsuarios = "SELECT * FROM usuarios";
            var cmdUsuarios = new MySqlCommand(queryUsuarios, _connection);
            var readerUsuarios = cmdUsuarios.ExecuteReader();
            while (readerUsuarios.Read())
            {
                var usuario = new Usuario(
                    readerUsuarios.GetInt32("id"),
                    readerUsuarios.GetString("nome"),
                    new List<Ambiente>() 
                );
                Usuarios.Add(usuario);
            }
            readerUsuarios.Close();


            string queryAmbientes = "SELECT * FROM ambientes";
            var cmdAmbientes = new MySqlCommand(queryAmbientes, _connection);
            var readerAmbientes = cmdAmbientes.ExecuteReader();
            while (readerAmbientes.Read())
            {
                var ambiente = new Ambiente(
                    readerAmbientes.GetInt32("id"),
                    readerAmbientes.GetString("nome"),
                    new Queue<Log>() 
                );
                Ambientes.Add(ambiente);
            }
            readerAmbientes.Close();

           
            string queryLogs = "SELECT * FROM logs";
            var cmdLogs = new MySqlCommand(queryLogs, _connection);
            var readerLogs = cmdLogs.ExecuteReader();
            while (readerLogs.Read())
            {
                var log = new Log(
                    readerLogs.GetDateTime("dt_acesso"),
                    Usuarios.Find(u => u.Id == readerLogs.GetInt32("usuario_id")),
                    readerLogs.GetBoolean("tipo_acesso")
                );

                var ambiente = Ambientes.Find(a => a.Id == readerLogs.GetInt32("ambiente_id"));
                ambiente?.Logs.Enqueue(log); 
            }
            readerLogs.Close();

            _connection.Close();
        }

    }

}
