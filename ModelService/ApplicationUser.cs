using Microsoft.AspNetCore.Identity;

namespace ModelService
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserRole { get; set; }
        public bool isAdmin { get; set; }
    }
}
