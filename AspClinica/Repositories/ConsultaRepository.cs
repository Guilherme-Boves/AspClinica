using AspClinica.Context;
using AspClinica.Models;
using AspClinica.Repositories.Interfaces;

namespace AspClinica.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        public readonly AppDbContext _context;

        public ConsultaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Consulta> Consultas => _context.Consultas;

        public Consulta GetConsultaById(int consultaId) => _context.Consultas.FirstOrDefault(c => c.ConsultaId == consultaId);
    }
}
