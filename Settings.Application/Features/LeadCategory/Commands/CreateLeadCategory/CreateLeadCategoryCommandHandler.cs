using FluentValidation;
using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Interfaces;
using Settings.Domain.Responses;

namespace Settings.Application.Feauters.LeadCategory.Commands.CreateLeadCategory;

internal class CreateLeadCategoryCommandHandler : IRequestHandler<CreateLeadCategoryCommand, ServerResponse>
{
    private readonly IGenericRepository<Domain.Entities.LeadCategory> _repository;
    private readonly IValidator<CreateLeadCategoryRequest> _validator;
    public CreateLeadCategoryCommandHandler(
        IValidator<CreateLeadCategoryRequest> validator,
        IGenericRepository<Domain.Entities.LeadCategory> repository)
    {
        _validator = validator;
        _repository = repository;
    }

    public async Task<ServerResponse> Handle(CreateLeadCategoryCommand request, CancellationToken cancellationToken)
    {
        var validate = await _validator.ValidateAsync(request.LeadCategory);
        if (!validate.IsValid)
        {
            var errorList = string.Join("; ", validate.Errors.Select(error => error.ErrorMessage));
            return new ServerResponse(Message: errorList);
        }
        var product = new Domain.Entities.LeadCategory
        {
            CategoryName = request.LeadCategory.CategoryName
        };

        await _repository.CreateAsync(product);
        return new ServerResponse(IsSuccess: true, Message: "Lead Category Created Succcessfully", Data: product);
    }
}


