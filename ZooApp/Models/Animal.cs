using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using ZooApp.Models;

namespace ZooApp.Models
{
    public enum Sex // The possible Genders for an animal are defined here.
    {
        Male,
        Female,
        Unidentified
    }

    public enum DietType // The possible Dietypes for an animal are defined here.
    {
        Carnivore,
        Omnivore,
        Herbivore,
        Pescatarian
    }

    public class Animal
    {

        //Foreign Key (Unique IDentifier for each record in table)
        [Key]
        public int AnimalId { get; set; }

        //Name field of the Animal string length can around 100 characters long, can't have numbers
        //or special characters and required field.
        [StringLength(100)]
        [RegularExpression(@"^[A-Z][a-zA-Z\s]*$", ErrorMessage = "Name has to begin with a capital letter and must not include any special characters or numbers.")]
        [Required(ErrorMessage = "The Name field is required.")]
        public string Name { get; set; }

        //Species is a required field, with the maxiumum of 100 characters length. CAn't have special characters or numbers.
        [Required (ErrorMessage = "You must specify a Species type to submit.")]
        [StringLength(100 , ErrorMessage ="Please enter a valid Species name.")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Species has to begin with capital letter and must not include any special characters or numbers.")]
        public string Species { get; set; }

        //The Age is required field, and can span from 0 to 100 years.
        [Required(ErrorMessage ="Please provide an age.")]
        [Range(1, 100, ErrorMessage = "Please enter a valid age above 0, and less than 100")]
        public int Age { get; set; }

        //Sex or Gender is an Enum, where there are predefined Values that users can select from a drop downlist 
        //of values defined below.
        [Required]
        public Sex Sex { get; set; }

        //The diet field is also an enum like the Sex field.
        [Required]
        public DietType? Diet { get; set; }

        // Foreign Keys
        //This is the Employees that take care of the particular Animal
        [Required(ErrorMessage ="Must provide an Employee to take care of this Animal.")]
        public int? EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        [Required(ErrorMessage = "You must select an Employee to create Animal.")]
        public Employee Employee { get; set; }

      
        //This is the Enclosures that houses each Animal.
        public int? EnclosureId { get; set; }
        [ForeignKey(nameof(EnclosureId))]
        public Enclosure Enclosure { get; set; }


        // Property to store the file name
        
        public string ImageFileName { get; set; }

        // Property to store the uploaded file (not mapped to the database)
        
        [NotMapped]
        public IFormFile ImageFile { get; set; }

        // This is a junction table the Animal's table is related with which brings both the animal and employees in a relationship
        // but since SQL SERVER doesnt allow many to many relationships we must use a junction table inorder to make the relationship.
        public ICollection<AnimalEmployee> AnimalZooEmployees { get; set; }
    }
}
