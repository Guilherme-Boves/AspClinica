using AspClinica.Models;

namespace AspClinica.Repositories.Interfaces
{
    public interface IPacienteRepository
    {
        IEnumerable<Paciente> Pacientes { get; }

        Paciente GetPacienteById(int pacienteId);
    }
}
