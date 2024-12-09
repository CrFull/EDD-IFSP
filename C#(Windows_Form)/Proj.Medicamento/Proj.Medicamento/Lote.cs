using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Medicamento
{
    class Lote
    {
        private int id;
        private int qtde;
        private DateTime venc;

        public Lote(): this(0,0, DateTime.MinValue)
        {
            
        }
        public Lote(int id, int qtde, DateTime venc)
        {
            this.id = id;
            this.qtde = qtde;
            this.venc = venc;
        }

        public int Id { get => id; set => id = value; }
        public int Qtde { get => qtde; set => qtde = value; }
        public DateTime Venc { get => venc; set => venc = value; }
    }
}
