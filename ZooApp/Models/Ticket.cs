using System.ComponentModel.DataAnnotations;

namespace ZooApp.Models
{
    public class Ticket
    {
        [Key] public int TicketId { get; set; }

        
        public int VisitorId { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfPurchase { get; set; }= DateTime.Now;

        public int EventId { get; set; }

        // Navigation properties
        public Event Event { get; set; }
        public Visitor Visitor { get; set; }
    }
}
