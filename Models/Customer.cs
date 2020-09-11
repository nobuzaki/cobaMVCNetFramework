using System;
using System.ComponentModel.DataAnnotations;

namespace CobaMVCNetFramework.Models
{
    public class Customer
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Please enter customer's name.")]
        [StringLength(255)]
        public String Name { get; set; }
                
        public bool IsSubscribedToNewsletter { get; set; }
        
        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membersip Type")]
        public byte MembershipTypeId { get; set; }
        
        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }
    }
}