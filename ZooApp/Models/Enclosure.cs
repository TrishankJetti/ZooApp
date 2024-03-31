using System.ComponentModel.DataAnnotations;

namespace ZooApp.Models
{

    public class Enclosure
    {
        [Key] public int EnclosureId { get; set; }

        public string Name { get; set; }

        public string Habitat { get; set; }

        public int Capacity { get; set; }


        public ICollection<Animal> Animals { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
