using AuthAPI_903.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthAPI_903.Data
{
    public class AppDBContext : IdentityDbContext<AppUser>
    {
        public  AppDBContext(DbContextOptions<AppDBContext> options ) : base(options) { }
    }
}
