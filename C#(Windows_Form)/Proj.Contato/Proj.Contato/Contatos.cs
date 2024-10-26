using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Contato
{
    public class Contatos
    {
            private readonly List<Contato> agenda = new List<Contato>();

            public bool Adicionar(Contato c)
            {
                if (!agenda.Any(contato => contato.Equals(c)))
                {
                    agenda.Add(c);
                    return true;
                }
                return false;
            }

            public Contato Pesquisar(Contato c)
            {
                return agenda.FirstOrDefault(contato => contato.Equals(c));
            }

            public bool Alterar(Contato c)
            {
                Contato contatoExistente = Pesquisar(c);
                if (contatoExistente != null)
                {

                    contatoExistente.Nome = c.Nome;
                    contatoExistente.Telefone = c.Telefone;
                    contatoExistente.DtNasc = c.DtNasc;
                    return true;
                }
                return false;
            }

            public bool Remover(Contato c)
            {
                return agenda.Remove(Pesquisar(c));
            }

            public List<Contato> Listar()
            {
                return agenda;
            }
        }
}
