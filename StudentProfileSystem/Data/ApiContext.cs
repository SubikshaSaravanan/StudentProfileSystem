using Microsoft.EntityFrameworkCore;
using StudentProfileSystem.Models.Entity;
using StudentProfileSystem.Data;

namespace StudentProfileSystem.Data
{
    
        public class ApiContext : DbContext
        {
            protected readonly IConfiguration Configuration;

            public ApiContext(IConfiguration configuration)
            {
                Configuration = configuration;
            }

            protected override void OnConfiguring(DbContextOptionsBuilder options)
            {

                options.UseNpgsql(Configuration.GetConnectionString("StAdmin"));
            }
            public DbSet<StuRec> StuInfo{ get; set; }
            public DbSet<StuDep>Department{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StuDep>()
                .HasKey(d => d.DID); // Primary key configuration

            // Configure relationships if needed
            modelBuilder.Entity<StuDep>()
                .HasMany(d => d.Students)
                .WithOne(e => e.StuDep)
                .HasForeignKey(e => e.DID);

            // Seed initial data
            modelBuilder.Entity<StuDep>().HasData(
                new StuDep { DID = 1, DepartmentName = "Tamil" },
                new StuDep { DID = 2, DepartmentName = "English" },
                new StuDep { DID = 3, DepartmentName = "Electronics" },
                new StuDep { DID = 4, DepartmentName = "Accounts" },
                new StuDep { DID = 5, DepartmentName = "Physics" }
            );

            base.OnModelCreating(modelBuilder);
        }


    }


}


