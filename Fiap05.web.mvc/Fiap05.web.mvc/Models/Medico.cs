using System.Collections.Generic;

namespace Fiap05.web.mvc.Models
{
    public class Medico
    {
        public int MedicoId { get; set; }

        public string Nome { get; set; }


        //relacionamentos

        public Especialidade Especialidade { get; set; }

        public int EspecialidadeId { get; set; }

        public virtual List<Consulta> Consultas { get; set; }
    }
}