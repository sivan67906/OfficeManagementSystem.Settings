using FluentValidation;
using Settings.Application.DTOs;

namespace Settings.Application.Feauters.LeadCategory.Commands.CreateLeadCategory;

public class CreateLeadCategoryCommandValidator : AbstractValidator<CreateLeadCategoryRequest>
{
    public CreateLeadCategoryCommandValidator()
    {
        RuleFor(x => x.CategoryName)
            .NotEmpty().WithMessage("Agent Name not empty")
            .MaximumLength(25).WithMessage("Agent Name must not exceed 25 Characters")
            .MinimumLength(3).WithMessage("Agent Name should not be less than 3 characters");

    }
}


