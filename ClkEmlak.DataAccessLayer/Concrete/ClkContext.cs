using ClkEmlak.EntityLayer.Entities;
using ClkEmlak.EntityLayer.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ClkEmlak.DataAccessLayer.Concrete
{
    public class ClkContext : IdentityDbContext<AppUser,AppRole, string>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=ClkDb;Trusted_Connection=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Estate> Estates { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}
