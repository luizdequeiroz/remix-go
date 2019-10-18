using System.ComponentModel.DataAnnotations;

namespace api.DTOs
{
    public class UserDTO
    {
        [Required(ErrorMessage = "Nome de usuário obrigatório.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Senha de usuário obrigatória.")]
        public string Password { get; set; }
    }
}
