using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Module35
{
    public class ApplicationDbContext: IdentityDbContext<User>
    {

        public ApplicationDbContext(DbContextOptions <ApplicationBuilder> options): base(options)
        {
            Database.EnsureCreated();
        }
    }
}
