using AspClinica.Models;

namespace AspClinica.Repositories.Interfaces
{
    public interface IPsicologoRepository
    {
        IEnumerable<Psicologo> Psicologos { get; }
        Psicologo GetPsicologoById(int psicologoId);
        
    }
}
