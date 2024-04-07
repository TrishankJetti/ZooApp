using System.ComponentModel.DataAnnotations;

namespace ZooApp.Models
{
    public class VisitorLog
    {
        [Key]
        public int VisitorLogId { get; set; }

        [Required(ErrorMessage = "VisitorId is required")]
        public int VisitorId { get; set; }

        [Required(ErrorMessage = "DateVisited is required")]
        [DataType(DataType.DateTime)]
        public DateTime DateVisited { get; set; }

        [MaxLength(500, ErrorMessage = "Comments must be less than 500 characters")]
        public string Comments { get; set; }

        // Navigation properties
        public Visitor Visitor { get; set; }
    }

}
