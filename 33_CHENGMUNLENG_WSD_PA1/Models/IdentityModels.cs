using Microsoft.AspNet.Identity.EntityFramework;

namespace _33_CHENGMUNLENG_WSD_PA1.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}