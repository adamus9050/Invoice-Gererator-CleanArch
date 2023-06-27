using FluentValidation;


namespace Application.Dto.Material.MaterialCommand.Add
{
    public class MaterialSaveCommandValidator : AbstractValidator<MaterialSaveCommand>
    {
        public MaterialSaveCommandValidator()
        {
            RuleFor(c => c.Name).NotEmpty().MinimumLength(2).WithMessage("Minumalna długośc pola nazwa to 2 znaki");
            RuleFor(c => c.Price).NotEmpty().WithMessage("Pole cena musi byc wypełnione");
        }

    }
}
