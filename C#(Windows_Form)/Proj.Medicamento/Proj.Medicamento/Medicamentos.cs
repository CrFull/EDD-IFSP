using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Medicamento
{
    class Medicamentos
    {
        private List<Medicamento> listaMedicamento;
        internal List<Medicamento> ListaMedicamento { get => listaMedicamento; set => listaMedicamento = value; }

        public Medicamentos()
        {
            listaMedicamento = new List<Medicamento>();
        }


        public void adicionar(Medicamento medicamento)
        {
            ListaMedicamento.Add(medicamento);
        }
        public bool deletar(Medicamento medicamento)
        {
            bool temMedicamento = medicamento.qtdeDisponivel() > 0 ? true : false;
            bool medicamentoExisteNaLista = pesquisar(medicamento).Id != 0 ? true : false;
            if (temMedicamento && medicamentoExisteNaLista)
                ListaMedicamento.Remove(medicamento);
            
            return temMedicamento && medicamentoExisteNaLista;
        }
        public Medicamento pesquisar(Medicamento medicamento)
        {
            return ListaMedicamento.FirstOrDefault(m => m.Id == medicamento.Id) ?? new Medicamento();
        }

    }
}
