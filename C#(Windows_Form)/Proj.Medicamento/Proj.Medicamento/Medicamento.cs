using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Medicamento
{
     class Medicamento
    {
        private int id;
        private string nome;
        private string laboratorio;
        private Queue<Lote> lotes;

        public Medicamento():this(0,"","", new Queue<Lote>())
        {

        }
        public Medicamento(int id, string nome, string laboratorio, Queue<Lote> lotes)
        {
            this.id = id;
            this.nome = nome;
            this.laboratorio = laboratorio;
            this.lotes = lotes;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Laboratorio { get => laboratorio; set => laboratorio = value; }
        internal Queue<Lote> Lotes { get => lotes; set => lotes = value; }

        private bool existeLote()
        {
            return Lotes.Count > 0;
        }
        public int qtdeDisponivel()
        {
            int qtdDisponivel = 0;
            if (existeLote())
            {
                foreach (Lote lote in this.lotes)
                {
                    if (lote.Venc > DateTime.Now && lote.Qtde > 0)
                        qtdDisponivel++;
                }
            }
            return qtdDisponivel;
        }

        public void comprar(Lote lote)
        {
            Lotes.Enqueue(lote);
        }
        public bool vender(int qtde)
        {
            bool isVendido = false;
            Lote loteAtual;
            while(qtde > 0 && existeLote())
            {
                loteAtual = Lotes.Peek();
                if (loteAtual.Qtde >= qtde)
                {
                    loteAtual.Qtde -= qtde;
                    qtde = 0;
                    if (loteAtual.Qtde < 1)
                    {
                        Lotes.Dequeue();
                    }
                    isVendido = true;
                }
                else
                {
                    qtde -= loteAtual.Qtde;
                    Lotes.Dequeue();
                }
            }
            return isVendido;
        }

        public string toString()
        {
            return Id + "-" + nome + "-" + Laboratorio + "-" + qtdeDisponivel();
        }

        override
        public bool Equals(object obj)
        {
            return obj.Equals(Id);
        }


    }
}
