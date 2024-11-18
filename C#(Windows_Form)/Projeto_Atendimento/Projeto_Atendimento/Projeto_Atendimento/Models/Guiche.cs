using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Atendimento
{
    internal class Guiche
    {
       public int id {  get; set; }
       public Queue<Senha> atendimentos {  get; set; }
        
        public Guiche(int id)
        {
            this.id = id;
            this.atendimentos= new Queue<Senha>();
        }
        public Guiche(): this(0){ }
        public Boolean Chamar(Queue<Senha> filaSenhas)
        {
            bool podeChamar = (filaSenhas.Count > 0);
            if (podeChamar)
            {
                Senha atendimento = filaSenhas.Dequeue();
                atendimento.dataAtend = DateTime.Now; 
                atendimento.horaAtend = DateTime.Now; 
                this.atendimentos.Enqueue(atendimento);
            }
            return podeChamar;
        }
    }
}
