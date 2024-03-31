using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace ZooApp.Models
{
    public class Event
    {
        [Key] public int EventId { get; set; }

        public string Name { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public decimal TicketPrice { get; set; }

        // Navigation properties
        public ICollection<Ticket> Tickets { get; set; }

        public ICollection<VisitorEventAttendance> EventAttendances { get; set; }
    }
}
