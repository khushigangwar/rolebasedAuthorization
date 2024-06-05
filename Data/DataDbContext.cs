using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace rolebasedAuthorization.Data
{
    public class DataDbContext :IdentityDbContext<IdentityUser>
    {
        public DataDbContext(DbContextOptions options) :base(options) { }
    }
}
