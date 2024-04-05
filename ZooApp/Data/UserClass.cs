using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooApp.Data
{
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage = "Please provide a valid First Name please")]
        [PersonalData]
        [Column(TypeName="nvarchar(100)")]
        public string FirstName { get; set; }

        [Required(ErrorMessage ="Please provide a valid First Name please")]
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }
    }
}
