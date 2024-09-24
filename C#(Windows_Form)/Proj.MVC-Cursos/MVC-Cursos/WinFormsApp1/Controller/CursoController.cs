using WinFormsApp1.Model;

namespace WinFormsApp1.Controller
{
    public class CursoController
    {
        private List<Curso> cursos;

        public CursoController()
        {
            cursos = new List<Curso>();
        }

        public Curso pesquisarCursoPorId( int id)
        {
            return cursos.FirstOrDefault(c => c.Id == id);
        }

        public Curso criarCurso(int id, string desc)
        {
            Curso curso = new Curso(id, desc);
            return curso;
        }
        public Curso criarCurso(int id)
        {
            Curso curso = new Curso(id);
            return curso;
        }
    }
}
