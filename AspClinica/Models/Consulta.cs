using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspClinica.Models
{
    public class Consulta
    {        
        public String ConsultaId { get; set; } // Guid
        public string PsicologoId { get; set; } // Guid    
        public string PacienteId { get; set; } // Guid

        [Required(ErrorMessage = "Informe o preço da consulta")]
        [Display(Name = "Preço da Consulta")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Informe o Horário inicial da Consulta")]
        [Display(Name = "Horário Inicial")]
        [DataType(DataType.Date)]
        public DateTime HorarioInicial { get; set; }

        [Required(ErrorMessage = "Informe o Horário Final")]
        [Display(Name = "Horário Final")]
        [DataType(DataType.Date)]
        public DateTime HorarioFinal { get; set; }

        //public virtual Psicologo Psicologo { get; set; }
        //public virtual Paciente Paciente { get; set; }
        public IdentityUser Paciente { get; set; }
        public IdentityUser Psicologo { get; set; }
    }
}
