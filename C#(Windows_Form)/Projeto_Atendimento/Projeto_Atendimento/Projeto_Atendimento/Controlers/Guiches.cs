﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Atendimento
{
    internal class Guiches
    {

        public List<Guiche> listaGuiches {  get; set; }

        public Guiches(int id){
            listaGuiches = new List<Guiche>();
        }
        public void adicionar(Guiche guiche) { 
            this.listaGuiches.Add(guiche);
        }
    }
}
