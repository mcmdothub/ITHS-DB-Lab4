using Microsoft.AspNetCore.Identity;

namespace ITHS_DB_Lab4.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
