using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Acesso
{
    class Ambiente
    {
        private int id;
        private string nome;
        private Queue<Log> logs;

        public Ambiente(int id, string nome, Queue<Log> logs)
        {
            this.id = id;
            this.nome = nome;
            this.logs = logs;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        internal Queue<Log> Logs { get => logs; set => logs = value; }
        
        public void registrarLogs(Log log)
        {
            if(Logs.Count >= 100)
                Logs.Dequeue();
            Logs.Enqueue(log);
        }
    }
}
