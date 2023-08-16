namespace AspClinica.Models
{
    public class Consulta
    {
        public int ConsultaId { get; set; }
        public int PsicologoId { get; set; }
        public int PacienteId { get; set; }
        public DateTime HorarioInicial { get; set; }
        public DateTime HorarioFinal { get; set; }
        public virtual Psicologo Psicologo { get; set; }
        public virtual Paciente Paciente { get; set; }
    }
}
