using EmployeeAdminPortal.Data.Models;

using System;

namespace EmployeeAdminPortal.Data.Interfaces
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAll();
        Employee? GetById(Guid id);
        bool Add(Employee employee);
        void Update(Employee employee);
        void Delete(Employee employee);
        List<Employee> GetByManagerId(Guid managerId);
    }
}
