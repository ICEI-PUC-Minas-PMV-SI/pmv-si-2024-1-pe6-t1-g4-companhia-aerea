using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.ReserveAggregate
{
    public class ReserveDtoCreate
    {
        [Required(ErrorMessage ="O campo código da reserva é obrigatório!")]
        public string ReserveCode { get; set; }
        [Required(ErrorMessage ="O campo status da reserva é obrigatório")]
        public string ReserveStatus {  get; set; }
        [Required(ErrorMessage = "O campo bagagem extra é obrigatório!")]
        public bool ExtraLuggage { get; set; }
        [Required(ErrorMessage = "O campo de cliente é obrigatório!")]
        public Guid CustomerId { get; set; }
        [Required(ErrorMessage = "O campo de voo é obrigatório!")]
        public Guid FlightId { get; set; }
    }
}
