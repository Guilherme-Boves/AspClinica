using AspClinica.Context;
using AspClinica.Models;
using AspClinica.Repositories.Interfaces;

namespace AspClinica.Repositories
{
    public class AdministradorRepository : IAdministradorRepository
    {
        public readonly AppDbContext _context;

        public AdministradorRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Administrador> Administradores => _context.Administradores;
    }
}
