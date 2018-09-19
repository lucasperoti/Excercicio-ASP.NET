using Fiap05.web.mvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap05.web.mvc.Perssistencia
{
    public class HospitalContext : DbContext
    {
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Consulta> consultas { get; set; }
        public DbSet<Prontuario> Prontuarios { get; set; }
        public DbSet<Convenio> convenios { get; set; }

    }
}