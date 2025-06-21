using Dapper;
using EmployeeAdminPortal.Data.Data;
using EmployeeAdminPortal.Data.Interfaces;
using EmployeeAdminPortal.Data.Models.Entities;
using EmployeeAdminPortal.Entity.Dto;
using EmployeeAdminPortal.Models.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EmployeeAdminPortal.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IConfiguration _config;
        
        //contructoor for get the data of the database
        public EmployeeRepository(ApplicationDbContext dbContext, IConfiguration config)
        {
            this.dbContext = dbContext;
            _config = config;
        }

        public List<Employee> GetAll()
        {

            try
            {
                return dbContext.Employees.ToList();
            }
            catch (Exception ex) { 
                throw new Exception("problem in GetALL() orgin",ex); 
            }
           
        }
        public Employee? GetById(Guid id) =>
        dbContext.Employees.FirstOrDefault(e => e.ID == id);

        public bool Add(Employee employee)
        {
            dbContext.Employees.Add(employee);
            dbContext.SaveChanges(); 
             return true;
        }

        public void Update(Employee employee) => dbContext.Employees.Update(employee);

        public void Delete(Employee employee) { dbContext.Employees.Remove(employee);
            dbContext.SaveChanges();
        }

        public List<Employee> GetByManagerId(Guid managerId) =>
      dbContext.Employees.Where(e => e.ManagerId == managerId).ToList();
        public List<ShowEmployeeDto> GetEmployeeWithManagerRepo()
        {
            using var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));

            var sql = @"
  SELECT 
            e.ID,
            e.Name,
            e.Email,
            e.Phone,
            e.Salary,
            e.ManagerId,
            m.Name AS ManagerName
        FROM Employees e
        LEFT JOIN Managers m ON e.ManagerId = m.ManagerId;";

            var result = connection.Query<ShowEmployeeDto>(sql)
                .ToList();
            return result;
        }

    }
}
