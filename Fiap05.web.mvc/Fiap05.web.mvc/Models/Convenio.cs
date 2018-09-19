﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap05.web.mvc.Models
{
    public class Convenio
    {
        public int ConvenioId { get; set; }
        public string Nome { get; set; }

        //Relacionamentos
        public virtual List<Paciente> Pacientes{ get; set; }


    }
}