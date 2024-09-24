using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Services;

namespace WinFormsApp1.Controller
{
    public class GlobalController
    {
        public AlunoController alunoController;
        public DisciplinaController disciplinaController;
        public CursoController cursoController;
        public EscolaController escolaController;
        public MatriculaService matriculaService;
        public GlobalController()
        {
            alunoController = new AlunoController();
            disciplinaController = new DisciplinaController();
            cursoController = new CursoController();
            escolaController = new EscolaController();
            matriculaService = new MatriculaService(alunoController, cursoController, disciplinaController);
        }

       
    }

}
