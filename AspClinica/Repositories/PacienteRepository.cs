using AspClinica.Context;
using AspClinica.Models;
using AspClinica.Repositories.Interfaces;

namespace AspClinica.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        public readonly AppDbContext _context;

        public PacienteRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Paciente> Pacientes => _context.Pacientes;

        public Paciente GetPacienteById(int pacienteId) => _context.Pacientes.FirstOrDefault(p => p.PacienteId == pacienteId);
    }
}
