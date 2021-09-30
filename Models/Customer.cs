using System;
using System.ComponentModel.DataAnnotations;

namespace vidly.Models
{
    public class Customer
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Customer's name is required.")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedtoNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        [Required(ErrorMessage = "Membership Type is required")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMemeber]
        public DateTime? Birthdate { get; set; }
    }
}