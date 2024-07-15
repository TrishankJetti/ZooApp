using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooApp.Models
{
    public class Employee
    {
        // Primary Key for the Employee table
        [Key]
        public int EmployeeId { get; set; } // Unique Identifier

        // Employee name, required, maximum length of 100 characters, must only contain letters and spaces
        [Required]
        [StringLength(100)]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Employee Name has to begin with capital letter and must not include any special characters or numbers.")]
        public string Name { get; set; }

        // Employee role, required, must be one of the values in the RoleType enum
        [Required]
        public RoleType Role { get; set; }

        // Phone number, optional, must match the given regular expression pattern
        [RegularExpression(@"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$", ErrorMessage = "Invalid phone number format")]
        public string Phone { get; set; }

        // Employee salary, required, must be within the range of 30000 to 90000
        [Required]
        [Range(30000, 90000, ErrorMessage = "Invalid Employee Salary.")]
        public decimal Salary { get; set; }

        // Date when the employee was hired, required, must be a valid date
        [Required(ErrorMessage = "Hire date is required")]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

        // Optional foreign key referencing the Enclosure entity
        public int? EnclosureId { get; set; }
        public Enclosure? Enclosure { get; set; }

        // Navigation property for the many-to-many relationship with AnimalEmployee
        public ICollection<AnimalEmployee> AnimalEmployees { get; set; }

        // Name of the image file associated with the employee
        public string ImageFileName { get; set; }

        // Image file, not mapped to the database
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }

    // Enum representing different roles an employee can have
    public enum RoleType
    {
        Zookeeper,
        Veterinarian,
        Admin,
        Manager
    }
}
