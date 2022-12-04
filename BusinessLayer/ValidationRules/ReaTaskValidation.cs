using EntitiesLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ReaTaskValidation:AbstractValidator<ReaTask>
    {
        public ReaTaskValidation()
        {
            RuleFor(x => x.Title).NotNull().NotEmpty().WithMessage("Please enter the title as valid, it cannot be empty!").WithMessage("Please enter the title as valid, it cannot be empty!").
              MinimumLength(5).WithMessage("Title must have at least 5 characters!").
              MaximumLength(50).WithMessage("Title must have a maximum of 50 characters");
            RuleFor(x => x.Description).NotNull().NotEmpty().WithMessage("Please enter the description as valid, it cannot be empty!").WithMessage("Please enter the description as valid, it cannot be empty!").
                MinimumLength(10).WithMessage("Description must have at least 20 characters!").
                MaximumLength(200).WithMessage("Description must have at least 200 characters!");
        }
    }
}

