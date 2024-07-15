using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooApp.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; } // This is the Event's Unique Identifier

        [Required(ErrorMessage = "Name is required")]
        [RegularExpression(@"^[A-Z][a-zA-Z\s]*$", ErrorMessage = "Name has to begin with a capital letter and must not include any special characters or numbers.")]
        public string Name { get; set; } //Name field that is string and has a custom validaiton.

        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date)] // THis is set to data type: date to make sure the time part is cut of. I have chosen to add frontend valdiaiton as the validaiton in the back end with the datetime doesnt work as expected.
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [RegularExpression(@"[A-Z][a-zA-Z\s,\.]*", ErrorMessage = "Description has to begin with a capital letter and can include letters, spaces, commas, and periods. No special characters or numbers allowed.")]
        [MaxLength(500, ErrorMessage = "Description must be less than 500 characters")]
        public string Description { get; set; } // Description is a string field that allow letters, commas and fullstops. But no sdpecial characters or anything else sadly.

        [Required(ErrorMessage = "Ticket price is required")]
        [Range(5, double.MaxValue, ErrorMessage = "Ticket price must be above $5.")]
        public decimal TicketPrice { get; set; }

        // Property to store the file name
        public string ImageFileName { get; set; }

        // Property to store the uploaded file (not mapped to the database)
        [NotMapped]
        public IFormFile ImageFile { get; set; }



    }

}
