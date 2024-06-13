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

                options.UseNpgsql(Configuration.GetConnectionString("StuAdmin"));
            }
            public DbSet<StuRec> StudentInfoHub { get; set; }

        }
    }

