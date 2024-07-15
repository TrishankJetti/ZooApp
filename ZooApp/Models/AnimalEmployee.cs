using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooApp.Models
{
    public class AnimalEmployee // Junction table
    {
        [Key]
        public int AnimalEmployeeId { get; set; } // junction table's unique identitifer for each record 

        public int EmployeeId { get; set; } // foreign key from employee table 
        [ForeignKey(nameof(EmployeeId))]
        public Employee? Employee { get; set; }

        public int AnimalId { get; set; }
        [ForeignKey(nameof(AnimalId))]
        public Animal? Animal
        {
            get; set; // foreign key from animal table 
        }
    }
}
