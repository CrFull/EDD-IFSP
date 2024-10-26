using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Contato
{
    public class Contato
    {
        private string email;
        private string nome;
        private Data dtNasc;
        private List<Telefone> telefones;

        public string Email { get; set; }
        public string Nome { get; set; }
        public Data DtNasc { get; set; }

        public List<Telefone> Telefone {  get; set; }

        public Contato(string email, string nome, Data dtNasc)
            {
                this.Email = email;
                this.Nome = nome;
                this.DtNasc = dtNasc;
                this.telefones = new List<Telefone>();
            }

            public int GetIdade()
            {
                DateTime hoje = DateTime.Today;
                int idade = hoje.Year - this.DtNasc.Ano;
                if (hoje.Month < this.DtNasc.Mes || (hoje.Month == this.DtNasc.Mes && hoje.Day < this.DtNasc.Dia))
                {
                    idade--;
                }
                return idade;
            }

            public void AdicionarTelefone(Telefone telefone)
            {
                this.telefones.Add(telefone);
            }

            public string GetTelefonePrincipal()
            {
                return  "" + telefones.FirstOrDefault(t => t.Principal);
            }

            public override string ToString()
            {
                return $"Nome: {Nome}, Email: {Email}, Data de Nascimento: {DtNasc}, Telefone Principal: {GetTelefonePrincipal()}";
            }

            public override bool Equals(object obj)
            {
                if (obj is Contato contato)
                {
                    return this.Email.Equals(contato.Email);
                }
                return false;
            }
        }
    }

