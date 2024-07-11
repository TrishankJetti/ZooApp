using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class ApplicationUser : IdentityUser
{
    // FirstName property
    [Required(ErrorMessage = "Please provide a valid First Name.")]
    [PersonalData] // Marks this property as personal data for GDPR purposes
    [RegularExpression(@"^[A-Z][a-z\s]*$", ErrorMessage = "Name must begin with a capital letter and must not include special characters or numbers.")]
    [Column(TypeName = "nvarchar(100)")] // Specifies database column type
    public string FirstName { get; set; }

    // LastName property
    [Required(ErrorMessage = "Please provide a valid Last Name.")]
    [PersonalData] // Marks this property as personal data for GDPR purposes
    [RegularExpression(@"^[A-Z][a-z\s]*$", ErrorMessage = "Name must begin with a capital letter and must not include special characters or numbers.")]
    [Column(TypeName = "nvarchar(100)")] // Specifies database column type
    public string LastName { get; set; }

    // Age property
    [Required(ErrorMessage = "Please provide a valid age.")]
    [Range(13, int.MaxValue, ErrorMessage = "You must be at least 13 years old to register.")]
    [Display(Name = "Age")] // Display name for UI
    public int Age { get; set; }
}
