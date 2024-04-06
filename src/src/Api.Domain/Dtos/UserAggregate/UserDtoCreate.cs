using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Dtos.UserAggregate
{
    // Este DTO é usado para C
    public class UserDtoCreate
    {
        [Required(ErrorMessage = "Nome é um campo obrigatório")]
        [StringLength(30, ErrorMessage = "Nome deve ter no máximo {1} caracteres.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Sobrenome é um campo obrigatório")]
        [StringLength(60, ErrorMessage = "Sobrenome deve ter no máximo {1} caracteres.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email é um campo obrigatório")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido.")]
        [StringLength(200, ErrorMessage = "Email deve ter no máximo {1} caracteres.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Data de Nascimento é um campo obrigatório")]
        public string DateBirth { get; set; }

        [Required(ErrorMessage = "Senha é um campo obrigatório")]
        [StringLength(maximumLength: 16, MinimumLength = 6, ErrorMessage = "A senha deve conter de 6 a 16 caracteres.")]
        public string Password { get; set; }
    }
}
