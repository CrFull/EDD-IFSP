using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace projCoisaMVC
{
    internal class Coisas
    {
        #region Atributos
        private Coisa[] asCoisas;
        private int max;
        private int qtde;
        #endregion

        #region Propriedades
        public int Max { get => max; }
        public int Qtde { get => qtde; }
        internal Coisa[] AsCoisas { get => asCoisas; }
        #endregion

        #region Construtores
        public Coisas(int max)
        {
            this.max = max;
            this.qtde = 0;
            this.asCoisas = new Coisa[max];
            for(int i=0; i<this.max; i++)
            {
                this.asCoisas[i] = new Coisa(-1,"");
            }
        }
        #endregion

        #region Métodos
        public string mostrar()
        {
            string ret = "";
            foreach(Coisa co in this.asCoisas)
            {
                if (co.Id != -1)
                {
                    ret += co.ToString();
                }
            }
            /*
            for(int i=0; i<this.qtde; ++i)
            {
                ret += this.AsCoisas[i].ToString();
            }
            */
            return ret;
        }
        public bool adicionar(Coisa c)
        {
            bool podeAdicionar = (this.qtde < this.max);
            if (podeAdicionar)
            {
                this.asCoisas[this.qtde] = c;
                this.qtde++;
            }
            return podeAdicionar;
        }

        public Coisa pesquisar(Coisa c)
        {
            Coisa coisaAchada = new Coisa(-1,"");
            /*
            int i = 0;
            while (i < this.max && this.asCoisas[i].Id != c.Id)
            {
                i++;
            }
            if (i<this.max)
            {
                coisaAchada = this.asCoisas[i];
            }
            */
            foreach (Coisa co in this.asCoisas)
            {
                if (co.Equals(c))
                {
                    coisaAchada = co;
                    break;
                }
            }
            return coisaAchada;
        }

        public int acharPòsicaoDaCoisaNasCoisas(Coisa c)
        {
            int posicao = -1;
            for (int i = 0; i < this.qtde; i++)
            {
                if (asCoisas[i].Id == c.Id)
                {
                    posicao = i;
                    break;
                }
            }
            return posicao;
        }

        public bool remover(Coisa c)
        {
            int posicao = acharPòsicaoDaCoisaNasCoisas(c);

            if (posicao == -1)
            {
                Console.WriteLine("Coisa não encontrada");
                return false;
            }

            for (int i = posicao; i < this.qtde - 1; i++)
            {
                asCoisas[i] = asCoisas[i + 1];
                asCoisas[i].Id--;
            }
            asCoisas[qtde - 1] = new Coisa(-1, "");
            qtde--;

            Console.WriteLine("Coisa {0} removida!  Novo asCoisas:", c.Id);
            Console.WriteLine(mostrar());

            return true;
        }



        #endregion




    }
}
