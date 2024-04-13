using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Dtos.CustomerAggregate
{
    public class CustomerDtoCreate
    {
        [Required(ErrorMessage = "Nome é um campo obrigatório")]
        [StringLength(30, ErrorMessage = "Nome deve ter no máximo {1} caracteres.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Sobrenome é um campo obrigatório")]
        [StringLength(60, ErrorMessage = "Sobrenome deve ter no máximo {1} caracteres.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email é um campo obrigatório")]
        [StringLength(200, ErrorMessage = "Email deve ter no máximo {1} caracteres.")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Documento é um campo obrigatório")]
        [StringLength(20, ErrorMessage = "Documento deve ter no máximo {1} caracteres.")]
        public string Document { get; set; }

        [Required(ErrorMessage = "Data de Nascimento é um campo obrigatório")]
        public string DateBirth { get; set; }

        [Required(ErrorMessage = "Nascionalidade é um campo obrigatório")]
        public Guid NationalityId { get; set; }
        public Guid? CareerId { get; set; }

        [Required(ErrorMessage = "Código do País é um campo obrigatório")]
        [StringLength(3, ErrorMessage = "Código do País deve ter no máximo {1} caracteres.")]
        public string CountryCode { get; set; }

        [Required(ErrorMessage = "DDD é um campo obrigatório")]
        [StringLength(3, ErrorMessage = "DDD deve ter no máximo {1} caracteres.")]
        public string DDD { get; set; }

        [Required(ErrorMessage = "Número do Telefone é um campo obrigatório")]
        [StringLength(20, ErrorMessage = "Número do Telefone deve ter no máximo {1} caracteres.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Tipo do Telefone é um campo obrigatório")]
        public int TypePhone { get; set; }

        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
    }
}
