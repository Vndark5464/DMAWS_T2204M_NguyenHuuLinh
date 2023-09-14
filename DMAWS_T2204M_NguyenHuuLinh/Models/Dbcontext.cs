using Microsoft.EntityFrameworkCore;

namespace DMAWS_T2204M_NguyenHuuLinh.Models
{    
        public class Dbcontext : DbContext
        {
            public Dbcontext(DbContextOptions options) : base(options)
            {
            }
            public DbSet<Employee> Employees { get; set; }

            public DbSet<Project> Projects { get; set; }

            public DbSet<ProjectEmployee> ProjectEmployees { get; set; }
        }
    }


