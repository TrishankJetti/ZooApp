using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooApp.Models
{
    public class VisitorLog
    {
        [Key]
        public int VisitorLogId { get; set; }

        [Required(ErrorMessage = "VisitorId is required")]
        [Display(Name = "Visitor ID")]
        public int VisitorId { get; set; }


        [Required]
        [StringLength(500, ErrorMessage = "Comments must be less than 500 characters")]
        [Display(Name = "Comments")]
        public string Comments { get; set; }

        [Required]
        [Display(Name = "How was your Experience?")]
        public ReviewType Review { get; set; } = ReviewType.Neutral; // Default to Neutral

        

        // Navigation properties
        [ForeignKey("VisitorId")]
        [Display(Name = "Visitor")]
        public Visitor Visitor { get; set; }


        [Required]
        [Display(Name = "Created On")]
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        
    }

    // Enum for Review Type
    public enum ReviewType
    {
        Positive,
        Negative,
        Neutral
    }

 
   
}
