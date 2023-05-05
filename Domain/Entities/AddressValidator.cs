using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Domain.Entities
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator() 
        {
            RuleFor(c => c.Street).NotEmpty().WithMessage("ulica jest polem obowiązkowym")
                .MinimumLength(3).WithMessage("ulica musi posiadać minumum 3 znaki");

            RuleFor(c => c.NumberOf).NotEmpty().WithMessage("numer jest polem obowiązkowym")
                .MinimumLength(1).WithMessage("numer ulicy musi posiadać minumum 1 znak");

            RuleFor(c => c.City).NotEmpty().WithMessage("Miasto jest polem obowiąkowym")
                .MinimumLength(3).WithMessage("Miasto musi posiadać minimum 3 znaki"); 

            RuleFor(c => c.PostCode).NotEmpty().WithMessage("Kod pocztowy jest polem obowiązkowym")
                .MinimumLength(5).MaximumLength(5).WithMessage("Kod pocztowy musi mieć 5 znaków"); 
        }
    }
}
