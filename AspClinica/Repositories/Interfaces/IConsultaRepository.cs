using AspClinica.Models;

namespace AspClinica.Repositories.Interfaces
{
    public interface IConsultaRepository
    {
        IEnumerable<Consulta> Consultas { get; }

        Consulta GetConsultaById(int consultaId);
    }
}
