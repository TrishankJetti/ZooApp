using System.ComponentModel.DataAnnotations;

namespace ZooApp.Models
{

    public class Enclosure
    {
        [Key] public int EnclosureId { get; set; }

        [Required]
        [StringLength(100)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "Name has to begin with capital letter and must not include any special characters or numbers.")]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "Name has to begin with capital letter and must not include any special characters or numbers.")]
        public string Habitat { get; set; }

        public int Capacity { get; set; }

        

        public ICollection<Animal> Animals { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
