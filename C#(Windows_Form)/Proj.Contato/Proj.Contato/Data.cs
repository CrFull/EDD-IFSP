using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Contato
{
    public class Data
    {
 
        private int dia;
        private int mes;
        private int ano;

        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }

        public Data(int dia, int mes, int ano)
        {
            this.Dia = dia;
            this.Mes = mes;
            this.Ano = ano;
        }

        public override string ToString()
        {
            return $"{Dia:D2}/{Mes:D2}/{Ano}";
        }
    }
}
