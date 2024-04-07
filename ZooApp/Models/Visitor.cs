using System.ComponentModel.DataAnnotations;

namespace ZooApp.Models
{

    public class Visitor
    {
        [Key]
        public int VisitorId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Name must contain only letters and spaces")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string? Email { get; set; }

        [RegularExpression(@"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$", ErrorMessage = "Invalid phone number format")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [MinLength(5, ErrorMessage = "Address must be at least 5 characters long")]
        public string Address { get; set; }

        // Navigation properties
        public ICollection<VisitorLog> VisitorLogs { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<VisitorEventAttendance> EventAttendances { get; set; }
    }

}