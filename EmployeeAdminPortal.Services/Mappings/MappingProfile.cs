
using AutoMapper;
using EmployeeAdminPortal.Data.Models.Entities; 

using EmployeeAdminPortal.Entity.Dto;
using EmployeeAdminPortal.Models.Entities;
using System.Runtime.InteropServices; // Assuming you have DTOs defined in this namespace


namespace EmployeeAdminPortal.Services.Mappings
{
     public class MappingProfile : Profile // Fix: Inherit from AutoMapper's Profile class
    {
        public MappingProfile() // Fix: Add a constructor to define mappings
        {
            CreateMap<Employee, AddEmployeeDto>().ReverseMap();// Fix: Place CreateMap inside the constructor
          //  CreateMap<AddEmployeeDto, Employee>();
            CreateMap<UpdateEmployeeDto, Employee>();
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<Employee, ShowEmployeeDto>();
        }
    }
}
