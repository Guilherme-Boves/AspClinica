using AspClinica.Models;
using Microsoft.EntityFrameworkCore;

namespace AspClinica.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Psicologo> Psciologos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
    }
}
