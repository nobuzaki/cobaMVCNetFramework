using System;
using System.ComponentModel.DataAnnotations;

namespace CobaMVCNetFramework.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public String Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
        [Display(Name = "Date of Birth")]
        public DateTime? BirthDate { get; set; }
    }
}