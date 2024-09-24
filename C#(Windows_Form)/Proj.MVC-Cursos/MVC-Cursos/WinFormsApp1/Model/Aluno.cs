using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    public class Aluno
    {
        private int id;
        private string nome;
        private Curso curso;

        public int Id { get => Id; set => Id = value; }
        public string Nome { get => Nome; set => Nome = value; }
        public Curso Curso { get => curso; set => curso = curso == null ? value : curso; }

        public Aluno(int id, string nome)
        {
            Id = id;
            Nome = nome;
  
        }

        public Aluno(int id, string nome, Curso curso)
        {
            Id = id;
            Nome = nome;
            this.Curso = curso;
        }

        public bool PodeMatricular(Curso novoCurso)
        {
            if (Curso != null)
            {
                return false; 
            }
            return true; 
        }

    }
     

}
