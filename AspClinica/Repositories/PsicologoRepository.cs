using AspClinica.Context;
using AspClinica.Models;
using AspClinica.Repositories.Interfaces;

namespace AspClinica.Repositories
{
    public class PsicologoRepository : IPsicologoRepository
    {
        public readonly AppDbContext _context;

        public PsicologoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Psicologo> Psicologos => _context.Psciologos;

        public Psicologo GetPsicologoById(int psicologoId) => _context.Psciologos.FirstOrDefault(p => p.PsicologoId == psicologoId);

    }
}
