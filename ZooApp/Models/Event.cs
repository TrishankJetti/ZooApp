using System.ComponentModel.DataAnnotations;
using System;

namespace ZooApp.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [RegularExpression(@"^[A-Z][a-zA-Z\s]*$", ErrorMessage = "Name has to begin with a capital letter and must not include any special characters or numbers.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [RegularExpression(@"^[A-Z][a-zA-Z\s]*$", ErrorMessage = "Description has to begin with a capital letter and must not include any special characters or numbers.")]
        [MaxLength(500, ErrorMessage = "Description must be less than 500 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Ticket price is required")]
        [Range(5, double.MaxValue, ErrorMessage = "Ticket price must be above $5.")]
        public decimal TicketPrice { get; set; }

        
    }
}
