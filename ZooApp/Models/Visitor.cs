using System.ComponentModel.DataAnnotations;

namespace ZooApp.Models
{
    public class Visitor
    {
        [Key] public int VisitorId { get; set; }

        public string Name { get; set; }

        public string? Email { get; set; }

        public string? Phone { get; set; }

        public string Address { get; set; }

        // Navigation properties
        public ICollection<VisitorLog> VisitorLogs { get; set; }
        public ICollection<Ticket> Tickets { get; set; }

        public ICollection<VisitorEventAttendance> EventAttendances { get; set; }
    }
}
