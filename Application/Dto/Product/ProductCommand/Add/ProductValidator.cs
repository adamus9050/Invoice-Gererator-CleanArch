using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Application.Dto.Product.ProductCommand.Add
{
    public class ProductValidator : AbstractValidator<AddProductCommand>
    {
        public ProductValidator() 
        {
            RuleFor(c => c.ProductName)
            .NotEmpty().WithMessage("Imię jest polem obowiązkowym");
            RuleFor(c => c.ProductName).MinimumLength(3).WithMessage("Minimalna długośc to 3 znaki");

            RuleFor(c => c.Type).NotEmpty().WithMessage("Nazwisko jest polem obowiązkowym");
            RuleFor(c => c.Type).MinimumLength(4).WithMessage("Minimalna długośc to 3 znaki");
        }
    }
}
