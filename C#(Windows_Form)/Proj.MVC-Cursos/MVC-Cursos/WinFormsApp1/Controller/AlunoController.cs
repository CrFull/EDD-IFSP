using WinFormsApp1.Model;

namespace WinFormsApp1.Controller
{
    public class AlunoController
    {
        private List<Aluno> alunos;

        public AlunoController()
        {
            alunos = new List<Aluno>();
        }

        public bool AdicionarAluno(Aluno aluno)
        {
            alunos.Add(aluno);
            return true;
        }

        public Aluno PesquisarAlunoPorId(int id)
        {
            return alunos.FirstOrDefault(a => a.Id == id);
        }
    }
}
