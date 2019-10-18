using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    public class User : Entity
    {
        [Required(ErrorMessage = "Nome de usuário obrigatório.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Senha de usuário obrigatória.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Nome completo obrigatório.")]
        public string Fullname { get; set; }
        [Required(ErrorMessage = "E-mail de usuário obrigatório.")]
        public string Email { get; set; }

        public IList<PlayerTable> PlayerTables { get; set; }
        public IList<Card> Cards { get; set; }

        [NotMapped]
        public string Token { get; set; }
    }
}
