using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooApp.Models
{
    
        public class VisitorEventAttendance
        {
            [Key]
            public int VisitorEventAttendanceId { get; set; }

            public int VisitorId { get; set; }
            [ForeignKey(nameof(VisitorId))]
            public Visitor Visitor { get; set; }

            public int EventId { get; set; }
            [ForeignKey(nameof(EventId))]
            public Event Event { get; set; }
        }

    
}
