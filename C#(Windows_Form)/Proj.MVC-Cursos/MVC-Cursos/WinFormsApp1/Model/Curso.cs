using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    public class Curso
    {
        private int id;
        private string descricao;
        private Disciplina[] disciplinas;
        private int disciplinaCount;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public Disciplina[] Disciplinas
        {
            get { return disciplinas; }
        }
        public Curso(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
            disciplinas = new Disciplina[12];
            disciplinaCount = 0;
        }

        public Curso(int id)
        {
            Id = id;
        }

        public bool AdicionarDisciplina(Disciplina disciplina)
        {
            if (disciplinaCount < 12)
            {
                disciplinas[disciplinaCount++] = disciplina;
                return true;
            }
            return false; 
        }

        public Disciplina PesquisarDisciplina(Disciplina disciplina)
        {
            return disciplinas.FirstOrDefault(d => d.Id == disciplina.Id);
        }

        public bool RemoverDisciplina(Disciplina disciplina)
        {
            for (int i = 0; i < disciplinaCount; i++)
            {
                if (disciplinas[i] == disciplina)
                {
                    if (disciplinas[i].ObterAlunosMatriculados().Length == 0) 
                    {
                        disciplinas[i] = disciplinas[--disciplinaCount]; 
                        return true;
                    }
                    return false; 
                }
            }
            return false; 
        }

        public override string ToString()
        {
            if (disciplinaCount == 0)
            {
                return $"Curso: {Descricao} (ID: {Id}) - Nenhuma disciplina cadastrada.";
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Curso: {Descricao} (ID: {Id})");
            sb.AppendLine("Disciplinas:");

            for (int i = 0; i < disciplinaCount; i++)
            {
                sb.AppendLine($"- {disciplinas[i].Descricao} (ID: {disciplinas[i].Id})");
            }

            return sb.ToString();
        }
    }

}
