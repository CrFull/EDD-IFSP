using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Biblioteca
{
    public class Exemplar
    {
        private int tombo;
        private List<Emprestimo> emprestimos;

        public int Tombo { get; private set; }
        public List<Emprestimo> Emprestimos;
        public Exemplar(int tombo)
        {
            Tombo = tombo;
            emprestimos = new List<Emprestimo>();
        }

        public bool Emprestar()
        {
            if (Disponivel())
            {
                emprestimos.Add(new Emprestimo(DateTime.Now));
                return true;
            }
            return false;
        }

        public bool Devolver()
        {
            var ultimoEmprestimo = emprestimos.FindLast(e => e.DtDevolucao == DateTime.MinValue);
            if (ultimoEmprestimo != null)
            {
                ultimoEmprestimo.DtDevolucao = DateTime.Now;
                return true;
            }
            return false;
        }

        public bool Disponivel()
        {
            return !emprestimos.Any() || emprestimos.Last().DtDevolucao != DateTime.MinValue;
        }

        public int QtdeEmprestimos()
        {
            return emprestimos.Count;
        }
    }
}
