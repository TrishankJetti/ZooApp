using System.ComponentModel.DataAnnotations;

namespace ZooApp.Models
{
    public class Ticket
    {
        [Key] public int TicketId { get; set; }

        [Required(ErrorMessage = "Visitor is required.")]
        public int VisitorId { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfPurchase { get; set; }= DateTime.Now;

        [Required(ErrorMessage = "Event is required.")]
        public int EventId { get; set; }

        // Foreign key references
        public Event Event { get; set; }
        public Visitor Visitor { get; set; }
    }
}
