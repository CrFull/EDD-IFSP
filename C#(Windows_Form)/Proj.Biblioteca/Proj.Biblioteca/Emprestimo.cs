using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Biblioteca
{
    public class Emprestimo
    {
        public DateTime DtEmprestimo { get; private set; }
        public DateTime DtDevolucao { get; set; }

        public Emprestimo(DateTime dtEmprestimo)
        {
            DtEmprestimo = dtEmprestimo;
            DtDevolucao = DateTime.MinValue; 
        }
    }
}
