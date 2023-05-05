using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Domain.Entities
{
    public class MaterialValidator : AbstractValidator<Material>
    {
        public MaterialValidator() 
        {
            RuleFor(c => c.Name).NotEmpty().MinimumLength(2).WithMessage("Minumalna długośc pola nazwa to 2 znaki");
            RuleFor(c => c.Price).NotEmpty().WithMessage("Pole cena musi byc wypełnione");
        }
    }
}
