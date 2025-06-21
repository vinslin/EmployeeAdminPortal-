using EmployeeAdminPortal.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Data.Data
{
    public class ApplicationDbContext : DbContext
    {
        //ctro type panna constructor create ahagum
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        //prop for creATE A PROPERTY
        public DbSet<Employee> Employees{ get; set; }
        public DbSet<Manager> Managers { get; set; }

        public DbSet<User> Users { get; set; }

    }
}
