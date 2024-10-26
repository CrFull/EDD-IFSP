using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Biblioteca
{
    public class Livro
    {
        private int isbn;
        private String titulo;
        private String autor;
        private String editora;
        private List<Exemplar> exemplares;
        public int Isbn { get; private set; }
        public String Titulo { get; private set; }
        public String Autor { get; private set; }
        public String Editora { get; private set; }
        public List<Exemplar> Exemplares{ get; private set; }
    public Livro(int isbn, string titulo, string autor, string editora)
        {
            Isbn = isbn;
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
            exemplares = new List<Exemplar>();
        }

        public void AdicionarExemplar(Exemplar exemplar)
        {
            exemplares.Add(exemplar);
        }

        public int QtdeExemplares()
        {
            return exemplares.Count;
        }

        public int QtdeDisponiveis()
        {
            return exemplares.Count(e => e.Disponivel());
        }

        public int QtdeEmprestimos()
        {
            return exemplares.Sum(e => e.QtdeEmprestimos());
        }

        public double PercDisponibilidade()
        {
            if (exemplares.Count == 0) return 0;
            return (double)QtdeDisponiveis() / QtdeExemplares() * 100;
        }

        public override string ToString()
        {
            return $"ISBN: {Isbn}, Título: {Titulo}, Autor: {Autor}, Editora: {Editora}";
        }

    }
}
