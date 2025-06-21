using System.ComponentModel.DataAnnotations;

namespace EmployeeAdminPortal.Data.Models
{
    public class Manager
    {
        // [Key]
        public Guid ManagerId { get; set; }

        public required string Name { get; set; } = string.Empty;



    }
}
