using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class applicationDbContext : IdentityDbContext<Users>
    {
        public applicationDbContext(DbContextOptions options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            var admin = new IdentityRole("admin");
            admin.NormalizedName = "admin";

            var RegularUser = new IdentityRole("user");
            RegularUser.NormalizedName = "user";

            var doctor = new IdentityRole("doctor");
            doctor.NormalizedName = "doctor";

            var manager = new IdentityRole("manager");
            manager.NormalizedName = "manager";

            builder.Entity<IdentityRole>().HasData(admin,RegularUser,doctor,manager);

        }
    }
}
