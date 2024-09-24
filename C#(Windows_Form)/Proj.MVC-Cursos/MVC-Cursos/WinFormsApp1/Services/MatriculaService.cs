using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Controller;
using WinFormsApp1.Model;

namespace WinFormsApp1.Services
{

    public class MatriculaService
    {
        private AlunoController alunoController;
        private CursoController cursoController;
        private DisciplinaController disciplinaController;

        public MatriculaService(AlunoController alunoCtrl, CursoController cursoCtrl, DisciplinaController disciplinaCtrl)
        {
            alunoController = alunoCtrl;
            cursoController = cursoCtrl;
            disciplinaController = disciplinaCtrl;
        }

        public bool MatricularAlunoEmDisciplina(Aluno aluno, Curso curso, Disciplina disciplina)
        {

            if (aluno != null && curso != null && disciplina != null && aluno.PodeMatricular(curso))
            {
                return disciplinaController.MatricularAlunoNaDisciplina(aluno, disciplina);
            }
            return false;
        }

        public bool DesmatricularAlunoDeDisciplina(Aluno aluno, Disciplina disciplina)
        {

            if (aluno != null && disciplina != null)
            {
                return disciplinaController.DesmatricularAlunoDaDisciplina(aluno, disciplina);
            }
            return false;
        }
    }
}

