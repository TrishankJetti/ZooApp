using System.ComponentModel.DataAnnotations;

namespace ZooApp.Models
{

    public class Enclosure
    {
        [Key] public int EnclosureId { get; set; }

        [Required]
        [StringLength(100)]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Name has to begin with a capital letter and must not include any special characters or numbers.")]

        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Name has to begin with capital letter and must not include any special characters or numbers.")]
        public string Habitat { get; set; }

        [Required(ErrorMessage ="Please enter a Capacity for your Enclosure please.")]
        [Range(1,30)]
        public int Capacity { get; set; }

        

        public ICollection<Animal> Animals { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
