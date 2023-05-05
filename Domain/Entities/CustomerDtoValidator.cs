using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Domain.Entities
{
    public class CustomerDtoValidator : AbstractValidator<Customer>
    {
        public CustomerDtoValidator() 
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Imię jest polem obowiązkowym");
            RuleFor(c => c.Name).MinimumLength(2).WithMessage("Minimalna długośc to 2 znaki");

            RuleFor(c => c.Surname) .NotEmpty().WithMessage("Nazwisko jest polem obowiązkowym");
            RuleFor(c => c.Surname).MinimumLength(3).WithMessage("Minimalna długośc to 3 znaki");

            RuleFor(c => c.PhoneNumber) .NotEmpty().WithMessage("Numer telefonu jest polem obowiązkowym");
            RuleFor(c => c.PhoneNumber).MinimumLength(9).WithMessage("Minimalna długośc to 9 znaków");

            //RuleFor(c => c.Address).NotEmpty();
        }
    }
}
