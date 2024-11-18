using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Atendimento
{
    internal class Senha
    {
        public int id {  get; set; }
        public DateTime dataGerac {  get; set; }
        public DateTime horaGerac { get; set; }
        public DateTime? dataAtend {  get; set; }
        public DateTime? horaAtend {  get; set; }

        public Senha(int id)
        {
            this.id = id;
            this.dataGerac = DateTime.Now;
            this.horaGerac = DateTime.Now; 
            this.dataAtend = null; 
            this.horaAtend = null; 
        }

        public String dadosParciais()
        {
            return $"Senha: {id} - {dataGerac:dd/MM/yyyy} - {horaGerac:HH:mm:ss}";
        }

        public String dadosCompletos()
        {
            string dataAtendStr = dataAtend.HasValue ? dataAtend.Value.ToString("dd/MM/yyyy") : "Não atendido";
            string horaAtendStr = horaAtend.HasValue ? horaAtend.Value.ToString("HH:mm:ss") : "Não atendido";
            return $"{dadosParciais()} - {dataAtendStr} - {horaAtendStr}";
        }
    }
}
