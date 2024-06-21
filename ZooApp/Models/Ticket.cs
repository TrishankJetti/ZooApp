using System.ComponentModel.DataAnnotations;

namespace ZooApp.Models
{
    public class Ticket
    {
        [Key] public int TicketId { get; set; }

        
        public int VisitorId { get; set; }

        public DateTime DateOfPurchase { get; set; }

        public int EventId { get; set; }

        // Navigation properties
        public Event Event { get; set; }
        public Visitor Visitor { get; set; }
    }
}
