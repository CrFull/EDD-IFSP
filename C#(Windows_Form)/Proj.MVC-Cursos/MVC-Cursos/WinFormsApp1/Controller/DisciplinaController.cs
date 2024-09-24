using WinFormsApp1.Model;

namespace WinFormsApp1.Controller
{
    public class DisciplinaController
    {
        private List<Disciplina> disciplinas;

        public DisciplinaController()
        {
            disciplinas = new List<Disciplina>();
        }

        public Disciplina criarDisciplina(int idDisciplina, String Descricao)
        {
            Disciplina dis = new Disciplina(idDisciplina, Descricao);
            return dis;
        }
        public bool MatricularAlunoNaDisciplina(Aluno aluno, Disciplina disciplina)
        {
            return disciplina.MatricularAluno(aluno);
        }

        public bool DesmatricularAlunoDaDisciplina(Aluno aluno, Disciplina disciplina)
        {
            return disciplina.DesmatricularAluno(aluno);
        }

        public Disciplina PesquisarDisciplinaPorId(int id)
        {
            return disciplinas.FirstOrDefault(d => d.Id == id);
        }
    }
}
