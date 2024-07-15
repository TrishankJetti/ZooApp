using System.ComponentModel.DataAnnotations;

namespace ZooApp.Models
{
    public class Ticket
    {
        [Key] public int TicketId { get; set; } // Unique identifier for each ticket

        [Required(ErrorMessage = "Visitor is required.")] //The priamry key from the visitors table
        public int VisitorId { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfPurchase { get; set; }= DateTime.Now; // date of purchase field indicating when the particular ticket was bought

        [Required(ErrorMessage = "Event is required.")]
        public int EventId { get; set; } // Eventid that is derived from the Events table's priamry key, Event ID

        // Foreign key references
        public Event Event { get; set; }
        public Visitor Visitor { get; set; }
    }
}
