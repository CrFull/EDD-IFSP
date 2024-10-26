using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Biblioteca
{
    public class Livros
    {
        private List<Livro> acervo = new List<Livro>();

        public void Adicionar(Livro livro)
        {
            acervo.Add(livro);
        }

        public Livro Pesquisar(int isbn)
        {
            return acervo.Find(l => l.Isbn == isbn);
        }
    }
}
