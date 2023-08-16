using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspClinica.Models
{    
    public class Administrador
    {
        [Key]
        public int AdministradorId { get; set; }
        [Required(ErrorMessage = "Informe o nome")]
        [StringLength(60,ErrorMessage="O nome deve ter entre 2 e 60 caracteres", MinimumLength = 2)]
        public string Nome { get; set; }
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
