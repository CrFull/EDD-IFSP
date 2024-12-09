using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Acesso
{
    class Usuario
    {
        private int id;
        private string name;
        private List<Ambiente> ambientes;

        public Usuario(int id, string name, List<Ambiente> ambientes)
        {
            this.id = id;
            this.name = name;
            this.ambientes = ambientes;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        internal List<Ambiente> Ambientes { get => ambientes; set => ambientes = value; }
        
        public bool concederPermissao(Ambiente ambiente)
        {

        }
        public bool revogarPermissao(Ambiente ambiente)
        {

        }
    }
}
