using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeAdminPortal.Entity.Dto;
using FluentValidation;

namespace EmployeeAdminPortal.Entity.Validators
{
    public class AddEmployeeDtoValidator : AbstractValidator<AddEmployeeDto>
    {

        public AddEmployeeDtoValidator() {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required")
                .MaximumLength(50);

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is Required")
                .EmailAddress();

            RuleFor(x => x.Phone)
                .NotEmpty().WithMessage("Phone is Required")
                .Matches(@"^\d{10}$").WithMessage("Phone Must be 10 digits");


            RuleFor(x => x.Salary)
                .GreaterThan(0).WithMessage("phone is required");

            RuleFor(x => x.ManagerId)
                .Must(guid => guid == null || guid != Guid.Empty)
                .WithMessage("ManagerId must be a valid GUID if provided.");


        }

    }
}
