using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    public class Disciplina
    {
        private int id;
        private string descricao;
        private Aluno[] alunos;
        private int alunoCount;

        public Disciplina(int id, string descricao)
        {
            this.id = id;
            this.descricao = descricao;
            alunos = new Aluno[15];
            alunoCount = 0;
        }

        public int Id
        {
            get => id;
            private set => id = value; 
        }

        public string Descricao
        {
            get => descricao;
            set => descricao = value; 
        }

        public Aluno[] Alunos
        {
            get => alunos.Take(alunoCount).ToArray();
        }

        public bool MatricularAluno(Aluno aluno)
        {
            if (alunoCount < 15)
            {
                alunos[alunoCount++] = aluno;
                return true;
            }
            return false;
        }

        public bool DesmatricularAluno(Aluno aluno)
        {
            for (int i = 0; i < alunoCount; i++)
            {
                if (alunos[i] == aluno)
                {
                    alunos[i] = alunos[--alunoCount]; 
                    return true;
                }
            }
            return false; 
        }

        public Aluno[] ObterAlunosMatriculados()
        {
            return alunos.Take(alunoCount).ToArray(); 
        }

     
    }


}
