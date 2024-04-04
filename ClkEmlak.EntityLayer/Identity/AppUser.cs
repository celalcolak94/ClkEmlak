using Microsoft.AspNetCore.Identity;

namespace ClkEmlak.EntityLayer.Identity
{
    public class AppUser : IdentityUser<string>
    {
        public string Name { get; set; }
        public string SurName { get; set; }
    }
}
