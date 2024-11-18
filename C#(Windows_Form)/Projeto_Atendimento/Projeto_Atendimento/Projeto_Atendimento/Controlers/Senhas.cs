using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Atendimento
{
    internal class Senhas
    {
        public int proximoAtendimento {  get; set; }
        public Queue<Senha> filaSenhas {  get; set; }

        public Senhas() { 
            this.filaSenhas = new Queue<Senha>();
            this.proximoAtendimento = 1;
        }
        public void gerar()
        {
            this.filaSenhas.Enqueue(new Senha(this.proximoAtendimento++));
        }
    }
}
