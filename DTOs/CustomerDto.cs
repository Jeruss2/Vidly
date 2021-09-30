using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using vidly.Models;

namespace vidly.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Customer's name is required.")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedtoNewsLetter { get; set; }

        public byte MembershipTypeId { get; set; }

        //[Min18YearsIfAMemeber]
        public DateTime? Birthdate { get; set; }
    }
}