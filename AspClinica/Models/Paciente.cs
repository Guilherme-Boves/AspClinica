using System.ComponentModel.DataAnnotations;

namespace AspClinica.Models
{
    public class Paciente
    {
        [Key]
        public int PacienteId { get; set; }
        [Required(ErrorMessage = "Informe o nome")]
        [StringLength(60, ErrorMessage = "O nome deve ter entre 2 e 60 caracteres", MinimumLength = 2)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe o CPF")]
        [StringLength(11, ErrorMessage = "CPF inválido")]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }
        [Required(ErrorMessage="Informe a data de nascimento")]
        [Display(Name = "Data de Nascimento")]
        //[DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        [Required(ErrorMessage = "Informe um número de telefone")]
        [StringLength(15, ErrorMessage = "O tamanho máximo é 15 caracteres")]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Informe um e-mail")]
        [StringLength(60, ErrorMessage = "O tamanho máximo é 60 caracteres")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]        
        public string Email { get; set; }
        [Required(ErrorMessage = "Informe uma senha")]
        [MinLength(6, ErrorMessage = "A senha é deve conter no mínimo 6 caracteres")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
