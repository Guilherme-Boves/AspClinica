using AspClinica.Models;

namespace AspClinica.Repositories.Interfaces
{
    public interface IAdministradorRepository
    {
        IEnumerable<Administrador> Administradores { get; }
    }
}
