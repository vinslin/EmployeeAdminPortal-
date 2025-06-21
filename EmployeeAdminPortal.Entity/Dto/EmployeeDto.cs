using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAdminPortal.Entity.Dto
{
    public class EmployeeDto
    {
        public Guid ID { get; set; }

        public required string Name { get; set; }
        //required is used for the nonnullable column

        public string Email { get; set; }
        public string? Phone { get; set; }
        // ? refers the non nullable one 
        public decimal Salary { get; set; }
        // Optional FK to Manager table
        // Optional foreign key to Manager
        public Guid? ManagerId { get; set; }

    }
}
