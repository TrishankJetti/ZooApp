using System.ComponentModel.DataAnnotations;

namespace ZooApp.Models
{
    public class VisitorEventAttendance
    {
        [Key] public int VisitorId { get; set; }

        public int EventId { get; set; }


        public Visitor Visitor { get; set; }

        public Event Event { get; set; }
    }
}
