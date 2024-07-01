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

        [ValidHireDate(ErrorMessage = "Hire date cannot be in the future or earlier than 20 years ago.")]
        [Required(ErrorMessage = "Hire date is required")]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

        
        public int? EnclosureId { get; set; }
        public Enclosure? Enclosure { get; set; }

        public ICollection<AnimalEmployee> AnimalEmployees { get; set; }

        public string ImageFileName { get; set; } 

        [NotMapped]
        public IFormFile ImageFile { get; set; } 



    }

    public enum RoleType
    {
        Zookeeper,
        Veterinarian,
        Admin,
        Manager

    }

    public class ValidHireDateAttribute : ValidationAttribute
    {
        private readonly DateTime _minDate;

        public ValidHireDateAttribute()
        {
            _minDate = DateTime.Now.AddYears(-20); // Set a 20-year limit for example
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime hireDate)
            {
                if (hireDate > DateTime.Now)
                {
                    return new ValidationResult("Hire date cannot be in the future.");
                }
                else if (hireDate < _minDate)
                {
                    return new ValidationResult($"Hire date cannot be earlier than {_minDate.ToShortDateString()}.");
                }
            }
            return ValidationResult.Success;
        }
    }
}
