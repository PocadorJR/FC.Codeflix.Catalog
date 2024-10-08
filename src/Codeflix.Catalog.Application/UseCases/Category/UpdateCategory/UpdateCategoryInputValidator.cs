using FluentValidation;

namespace Codeflix.Catalog.Application.UseCases.Category.UpdateCategory;

public class UpdateCategoryInputValidator : AbstractValidator<UpdateCategoryInput>
{
    public UpdateCategoryInputValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("'Id' must not be empty.");
    }
}
