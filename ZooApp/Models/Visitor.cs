using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooApp.Models
{
    public class Visitor
    {
        [Key]
        public int VisitorId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Name must contain only letters and spaces")]
        public string Name { get; set; } // Name willk only accept proper words with spaces only no numbers or etc.

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email format")] // Email field, the vlaidaiton ensures to only accept email adresses.
        public string? Email { get; set; } 

        // This validaiton ensures that Phone number msut begin with +64 and then have hypen ("-") then 2 digits then another hyphen then 3 digits then another hyphen then another 4 digits..
        [RegularExpression(@"^\+64-\d{2}-\d{3}-\d{4}$", ErrorMessage = "Sorry, only New Zealand phone numbers in the format +64-00-000-0000 are supported currently.")]
        public string? Phone { get; set; }




        //Address and its validaitons. Made sure users may not enter special characters and just random numbers ans their address and made sure atleast one letter has to be written inorder for this to work.

        [Required(ErrorMessage = "Address is required")]
        [MinLength(5, ErrorMessage = "Address must be at least 5 characters long")]
        [RegularExpression(@"^(?=.*[a-zA-Z]).+$", ErrorMessage = "Address must contain at least one letter")]
        public string Address { get; set; }


        [Required]
        public string CreatedByUserId { get; set; }

        [ForeignKey("CreatedByUserId")]
        public ApplicationUser CreatedByUser { get; set; }

        // Navigation properties with initialization. Initialization prevents null reference errors but this can also be prevented with sample data in context or intitializer alternatively.
        public ICollection<VisitorLog> VisitorLogs { get; set; } = new List<VisitorLog>();
        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
        public ICollection<VisitorEventAttendance> EventAttendances { get; set; } = new List<VisitorEventAttendance>();
    }
}
