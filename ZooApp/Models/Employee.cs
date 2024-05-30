using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooApp.Models
{
    public class Employee
    {
        [Key] public int EmployeeId { get; set; }

        [Required]
        [StringLength(100)]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Employee Name has to begin with capital letter and must not include any special characters or numbers.")]
        public string Name { get; set; }

        [Required]
        public RoleType Role { get; set; }


        [RegularExpression(@"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$", ErrorMessage = "Invalid phone number format")]
        public string Phone { get; set; }


        [Required]
        [Range(30000, 90000 , ErrorMessage = "Invalid Employee Salary.")]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = "Please enter a date pelase.")]
        public DateTime HireDate { get; set; }


        public int EnclosureId { get; set; }
        public Enclosure? Enclosure { get; set; }

        public ICollection<AnimalEmployee> AnimalEmployees { get; set; }

       

    }

    public enum RoleType
    {
        Zookeeper,
        Veterinarian,
        Admin,
        Manager

    }
}
