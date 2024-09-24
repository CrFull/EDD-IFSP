using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Model;

namespace WinFormsApp1.Controller
{
    public class EscolaController
    {
        private Escola escola;

        public EscolaController()
        {
            escola = new Escola();
        }

        public bool AdicionarCurso(Curso curso)
        {
            return escola.AdicionarCurso(curso);
        }

        public Curso PesquisarCurso(Curso curso)
        {
            return escola.PesquisarCurso(curso);
        }

        public bool RemoverCurso(Curso curso)
        {
            return escola.RemoverCurso(curso);
        }

    }
}
