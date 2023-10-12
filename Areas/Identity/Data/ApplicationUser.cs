using Microsoft.AspNetCore.Identity;

namespace Laboratorium7b.Areas.Identity.Data
{
    public class ApplicationUser : IdentityUser
    {
        public long CustomerId { get; set; }
    }
}
