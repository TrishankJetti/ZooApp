using System.ComponentModel.DataAnnotations;

namespace ZooApp.Models
{
    public class Ticket
    {
        [Key] public int TicketId { get; set; }

        public string VisitorId { get; set; }

        public string TicketType { get; set; }

        public DateTime DateOfPurchase { get; set; }

        public decimal Price { get; set; }

        public int EventId { get; set; }

        // Navigation properties
        public Event Event { get; set; }
        public Visitor Visitor { get; set; }
    }
}
