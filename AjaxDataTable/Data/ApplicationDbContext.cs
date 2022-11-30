using Data.App.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AjaxDataTable.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Banner> Banner { get; set; }

        public DbSet<About> About { get; set; }
        public DbSet<Appoinment> Appoinment { get; set; }
        public DbSet<CustomerSupport> CustomerSupport { get; set; }
        public DbSet<Doctors> Doctors { get; set; }
        public DbSet<DoctorsMain> DoctorsMain { get; set; }
        public DbSet<ParentServices> parentServices { get; set; }
        public DbSet<ServicesCard> ServicesCard { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Code to seed data
        }
    }
}