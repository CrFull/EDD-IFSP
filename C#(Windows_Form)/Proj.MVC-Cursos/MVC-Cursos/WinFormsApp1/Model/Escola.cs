using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1.Model
{
    public class Escola
    {
        private Curso[] cursos;
        private int cursoCount;

        public Escola()
        {
            cursos = new Curso[5];
            cursoCount = 0;
        }

        public bool AdicionarCurso(Curso curso)
        {
            if (cursoCount < 5)
            {
                cursos[cursoCount++] = curso;
                return true;
            }
            return false; 
        }

        public Curso PesquisarCurso(Curso curso)
        {
            return cursos.FirstOrDefault(c => c.Id == curso.Id);
        }

        public bool RemoverCurso(Curso curso)
        {
            for (int i = 0; i < cursoCount; i++)
            {
                if (cursos[i].Id == curso.Id )
                {
                    if (cursos[i].Disciplinas == null || cursos[i].Disciplinas.Length == 0)
                    { 
                        cursos[i] = cursos[--cursoCount]; 
                        return true;
                    }
                    return false; 
                }
            }
            return false; 
        }
    }

}
