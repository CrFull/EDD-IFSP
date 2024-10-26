using WinFormsApp1.Controller;
using WinFormsApp1.Model;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        GlobalController globalController;
        public Form1()
        {
            InitializeComponent();
            globalController = new GlobalController();
        }

        private void atualizarComboBoxDeCursos()
        {

        }

        private void btnAdicionarCurso_Click(object sender, EventArgs e)
        {
            int IdCurso = int.Parse(txtIdCurso.Text);
            if (globalController.escolaController.AdicionarCurso(globalController.cursoController.criarCurso(IdCurso, txtDescCurso.Text)))
                MessageBox.Show("Curso adicionado com sucesso!");
            else
                MessageBox.Show("Falha ao adicionar o curso!");
        }

        private void btnPesquisarCurso_Click(object sender, EventArgs e)
        {
            int IdCurso = int.Parse(txtIdCurso.Text);
            MessageBox.Show(globalController.escolaController.PesquisarCurso(globalController.cursoController.criarCurso(IdCurso)).ToString());
        }

        private void btnRemoverCurso_Click(object sender, EventArgs e)
        {
            int IdCurso = int.Parse(txtIdCurso.Text);
            if (globalController.escolaController.RemoverCurso(globalController.escolaController.PesquisarCurso(globalController.cursoController.criarCurso(IdCurso))))
                MessageBox.Show("Curso removido com sucesso!");
            else
                MessageBox.Show("Falha ao remover Curso!");
            atualizarComboBoxDeCursos();
        }

        private void btnAdicionarDisciplinaNoCurso_Click(object sender, EventArgs e)
        {
            int idCurso = int.Parse(txtIdCurso.Text);
            int idDisciplina = int.Parse(txtIdDisciplina.Text);
            if (globalController.cursoController.criarCurso(idCurso).AdicionarDisciplina(globalController.disciplinaController.criarDisciplina(idDisciplina, txtIdCurso.Text)))
                MessageBox.Show("Disciplina adicionada com sucesso!");
            else
                MessageBox.Show("Falha ao adicionadar Disciplina!");

        }

        private void btnRemoverDisciplinaDoCurso_Click(object sender, EventArgs e)
        {
            int idCurso = int.Parse(txtIdCurso.Text);
            int idDisciplina = int.Parse(txtIdDisciplina.Text);
            if (globalController.cursoController.criarCurso(idCurso).RemoverDisciplina(globalController.disciplinaController.criarDisciplina(idDisciplina, txtIdCurso.Text)))
                MessageBox.Show("Disciplina removida com sucesso!");
            else
                MessageBox.Show("Falha ao remover Disciplina!");
        }

        private void btnPesquisarDisciplina_Click(object sender, EventArgs e)
        {
            int idCurso = int.Parse(txtIdCurso.Text);
            int idDisciplina = int.Parse(txtIdDisciplina.Text);
            MessageBox.Show(globalController.cursoController.criarCurso(idCurso).PesquisarDisciplina(globalController.disciplinaController.criarDisciplina(idDisciplina, txtIdCurso.Text)).ToString());

        }

        private void btnMatricularAlunoNaDisciplina_Click(object sender, EventArgs e)
        {
            int idAluno = int.Parse(textIdAluno.Text);
            int idCurso = int.Parse(txtIdCurso.Text);
            int idDisciplina = int.Parse(txtIdDisciplina.Text);
            if (globalController.matriculaService.MatricularAlunoEmDisciplina(globalController.alunoController.PesquisarAlunoPorId(idAluno), globalController.cursoController.pesquisarCursoPorId(idCurso), globalController.disciplinaController.PesquisarDisciplinaPorId(idDisciplina)))
                MessageBox.Show("Matriculado com sucesso!");
            else
                MessageBox.Show("Falha ao  Matricular!");
        }

        private void btnRemoverAlunoDaDisciplina_Click(object sender, EventArgs e)
        {
            int idAluno = int.Parse(textIdAluno.Text);
            int idDisciplina = int.Parse(txtIdDisciplina.Text);
            if (globalController.matriculaService.DesmatricularAlunoDeDisciplina(globalController.alunoController.PesquisarAlunoPorId(idAluno), globalController.disciplinaController.PesquisarDisciplinaPorId(idDisciplina)))
                MessageBox.Show("Removido com sucesso!");
            else
                MessageBox.Show("Falha ao  remover!");
        }

        private void btnPesquisarAluno_Click(object sender, EventArgs e)
        {
            int idAluno = int.Parse(textIdAluno.Text);
            MessageBox.Show(globalController.alunoController.PesquisarAlunoPorId(idAluno).Nome + "\n" + globalController.alunoController.PesquisarAlunoPorId(idAluno).Curso.Disciplinas.ToString());
        }
    }
}
