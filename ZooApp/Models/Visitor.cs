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
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string? Email { get; set; }

        [RegularExpression(@"^(\+?64|0) ?[2-9]\d{7,9}$", ErrorMessage = "Invalid phone number format. Please enter a")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [MinLength(5, ErrorMessage = "Address must be at least 5 characters long")]
        public string Address { get; set; } 

        [Required]
        public string CreatedByUserId { get; set; }

        [ForeignKey("CreatedByUserId")]
        public ApplicationUser CreatedByUser { get; set; }

        // Navigation properties
        public ICollection<VisitorLog> VisitorLogs { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<VisitorEventAttendance> EventAttendances { get; set; }
    }
}
