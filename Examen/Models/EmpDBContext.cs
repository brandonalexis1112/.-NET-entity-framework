using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Examen.Models
{
    public class EmpDBContext : DbContext
    {
        public EmpDBContext() : base("EmpBD")
        {

        }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Especialidad> Especialidad { get; set; }
        public DbSet<Historia> Historia { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
    }
}