using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooApp.Models
{
    public class VisitorLog
    {
        [Key]//THis is the priamry key field that is a unique identifier for each comment.
        public int VisitorLogId { get; set; }

        [Required(ErrorMessage = "VisitorId is required")]
        [Display(Name = "Visitor ID")]
        public int VisitorId { get; set; }
        //THis is the foreign key of the visitorid field from the VIsitor tables. It essentially creates a relationship between the log and the vistor intiating a one to many relation.

        [Required]
        [StringLength(200, ErrorMessage = "Comments must be less than 500 characters")]
        [Display(Name = "Comments")]
        public string Comments { get; set; } // This is the comments field that is a string data type for the comments that the visitors will be adding on my website from other visitors to view and learn from.

        [Required]
        [Display(Name = "How was your Experience?")]
        public ReviewType Review { get; set; } = ReviewType.Neutral; // Defualt vlaue of the Review is set to Neautral.

        

        // THis is the forrign key that links to the VisitorID field in the vistors table this means that one visitors may have many comments and many comments may belong to one vistor.
        [ForeignKey("VisitorId")]
        [Display(Name = "Visitor")]
        public Visitor Visitor { get; set; }// This is the proprty that is repsonsible for the navigation of the VistorID from the VIsitor table to link with a matching visitor log.


        [Required]
        [Display(Name = "Created On")]
        [DataType(DataType.Date)] // Making sure that the data type is date instead of date & time 
        public DateTime CreatedOn { get; set; } = DateTime.Now;


        [DataType(DataType.Date)] // Making sure that the data type is date instead of date & time 
        //This field is a field that indicates whether or not the field has been modifed and what date it has been modifed.
        public DateTime? ModifiedOn { get; set; }

    }

    // Enums for Review types that can be categorized for each comment.
    public enum ReviewType
    {
        Positive,
        Negative,
        Neutral
    }

 
   
}
