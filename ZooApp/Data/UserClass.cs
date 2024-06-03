using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using ZooApp.Data;

public class ApplicationUser : IdentityUser
{
    [Required(ErrorMessage = "Please provide a valid First Name please")]
    [PersonalData]
    [RegularExpression(@"^[A-Z][a-z\s]*$", ErrorMessage = " Name has to begin with capital letter and must not include any special characters or numbers.")]
    [Column(TypeName = "nvarchar(100)")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Please provide a valid Last Name please")]
    [PersonalData]
    [RegularExpression(@"^[A-Z][a-z\s]*$", ErrorMessage = "Name has to begin with capital letter and must not include any special characters or numbers.")]
    [Column(TypeName = "nvarchar(100)")]
    public string LastName { get; set; }


    [Required]
    [Range(13, int.MaxValue, ErrorMessage = "You must be at least 13 years old to register.")]
    [Display(Name = "Age")]
    public int Age { get; set; }
   
}


