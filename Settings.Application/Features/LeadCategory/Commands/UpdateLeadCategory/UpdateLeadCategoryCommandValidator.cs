using FluentValidation;
using Settings.Application.DTOs;

namespace Settings.Application.Feauters.LeadCategory.Commands.CreateLeadCategory;

public class UpdateLeadCategoryCommandValidator : AbstractValidator<UpdateLeadCategoryRequest>
{
    public UpdateLeadCategoryCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Category Id should not be empty")
            .LessThan(0).WithMessage("Category Id must be greater than zero");
        RuleFor(x => x.CategoryName)
            .NotEmpty().WithMessage("Category Name should not be empty")
            .MaximumLength(25).WithMessage("Category Name must not exceed 25 Characters")
            .MinimumLength(3).WithMessage("Category Name should not be less than 3 characters");

    }
}


