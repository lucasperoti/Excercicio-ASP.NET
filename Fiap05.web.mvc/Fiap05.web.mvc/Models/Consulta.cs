using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap05.web.mvc.Models
{
    public class Consulta
    {
        public int ConsultaID { get; set; }
        public DateTime Data { get; set; }
        public int Consultorio { get; set; }

        //Relacionamentos

        public Medico Medico { get; set; }
        public int MedicoId { get; set; }
        public Paciente Paciente { get; set; }

    }
}