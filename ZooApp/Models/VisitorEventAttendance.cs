using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooApp.Models
{
    
        public class VisitorEventAttendance
        {
            [Key]
            public int VisitorEventAttendanceId { get; set; } // Unique identifier for each VisitorEventAttendance record

            public int VisitorId { get; set; }
            [ForeignKey(nameof(VisitorId))]   // Gets the visitorid from the visitor table and keeps it as a foreign key.
            public Visitor Visitor { get; set; }

            public int EventId { get; set; }
            [ForeignKey(nameof(EventId))]
            public Event Event { get; set; }   // Gets the eventid from the events table and keeps it as a foreign key.
    } 

    
}
