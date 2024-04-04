using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooApp.Models
{
    public enum Sex
    {
        Male,
        Female,
        Unidentified
    }

    public enum DietType
    {
        Carnivore,
        Omnivore,
        Herbivore,
        Pescatarian
    }

    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }

        [Required]
        [StringLength(100)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage ="Name has to begin with capital letter and must not include any special characters or numbers.")]
        
        public string Name { get; set; }

        [Required (ErrorMessage = "You must specify a Species type to submit.")]
        [StringLength(100 , ErrorMessage ="Please enter a valid Species name.")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "Species has to begin with capital letter and must not include any special characters or numbers.")]
        public string Species { get; set; }

        [Range(1, 300, ErrorMessage = "Please enter a valid age above 0.")]
        public int Age { get; set; }

        [Required]
        public Sex Sex { get; set; }

        [Required]
        public DietType? Diet { get; set; }
        
       
        public int EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        [Required(ErrorMessage = "You must select an Employee to create Animal.")]
        public Employee Employee { get; set; }


        public int EnclosureId { get; set; }
        [ForeignKey(nameof(EnclosureId))]
        [Required(ErrorMessage = "You must select an Enclosure to assign Animal to.")]
        public Enclosure Enclosure { get; set; }

        public ICollection<AnimalEmployee> AnimalZooEmployees { get; set; }
    }
}