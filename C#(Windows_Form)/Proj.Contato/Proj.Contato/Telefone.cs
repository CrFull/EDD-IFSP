using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Contato
{
   public class Telefone
    {

        private string tipo;
        private string numero;
        private bool principal;

        public string Tipo { get; set; }
        public string Numero { get; set; }
        public bool Principal { get; set; }

        public Telefone(string tipo, string numero, bool principal)
        {
            this.Tipo = tipo;
            this.Numero = numero;
            this.Principal = principal;
        }

        public override string ToString()
        {
            return $"{Tipo}: {Numero} {(Principal ? "(Principal)" : "")}";
        }
    }
}
