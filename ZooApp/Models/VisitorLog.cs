using System.ComponentModel.DataAnnotations;

namespace ZooApp.Models
{
    public class VisitorLog
    {
        [Key] public int VisitorLogId { get; set; }

        public int VisitorId { get; set; }

        public DateTime DateVisited { get; set; }

        public string Comments { get; set; }


        // Navigation properties
        public Visitor Visitor { get; set; }
    }
}
