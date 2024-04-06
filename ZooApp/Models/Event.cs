using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace ZooApp.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [RegularExpression(@"^[A-Z][a-zA-Z\s]*$", ErrorMessage = "Name has to begin with a capital letter and must not include any special characters or numbers.")]
        public string Name { get; set; }

        [FutureDate(ErrorMessage = "Date must be in the future")]
        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Ticket price is required")]
        [Range(0, double.MaxValue, ErrorMessage = "Ticket price must be a positive number")]
        public decimal TicketPrice { get; set; }
    }

    public class FutureDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var date = (DateTime)value;

            if (date.Date < DateTime.Now.Date)
            {
                return new ValidationResult(ErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
}
