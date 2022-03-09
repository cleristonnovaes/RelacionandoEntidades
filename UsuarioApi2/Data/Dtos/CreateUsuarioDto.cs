using System.ComponentModel.DataAnnotations;

namespace UsuarioApi.Data.Dtos
{
    public class CreateUsuarioDto
    {
        [Required]
        public string  Username { get; set; }
        [Required]
        public string Email { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Senha não estão iguais")]
        public string RePassword { get; set; }
    }
}
