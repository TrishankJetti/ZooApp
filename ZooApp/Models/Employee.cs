using System.ComponentModel.DataAnnotations;

namespace ZooApp.Models
{
    public class Employee
    {
        [Key] public int EmployeeId { get; set; }

        public string Name { get; set; }

        public RoleType Role { get; set; }

        public string Phone { get; set; }

        public decimal Salary { get; set; }

        public DateTime HireDate { get; set; }


        public int EnclosureId { get; set; }
        public Enclosure? Enclosure { get; set; }

        public ICollection<AnimalEmployee> AnimalEmployees { get; set; }

    }

    public enum RoleType
    {
        Zookeeper,
        Veteranarian,
        Admin,
        Manager

    }
}
