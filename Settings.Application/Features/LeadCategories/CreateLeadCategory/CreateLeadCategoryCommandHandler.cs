using AutoMapper;
using FluentValidation;
using MediatR;
using Settings.Application.DTOs.Lead;
using Settings.Domain.Contracts;
using Settings.Domain.Contracts.Lead;
using Settings.Domain.Entities;
using Settings.Domain.Responses;

namespace Settings.Application.Features.LeadCategories.CreateLeadCategory;

internal class CreateLeadCategoryCommandHandler(IValidator<CreateLeadCategoryRequest> validator,
    ILeadCategory _leadCategoryRepository, IUnitOfWork _unitOfWork, IMapper mapper)
    : IRequestHandler<CreateLeadCategoryCommand, ServerResponse>
{
    public async Task<ServerResponse> Handle(CreateLeadCategoryCommand request, CancellationToken cancellationToken)
    {
        var validate = await validator.ValidateAsync(request.LeadCategory);
        if (!validate.IsValid)
        {
            var errorList = string.Join("; ", validate.Errors.Select(error => error.ErrorMessage));
            return new ServerResponse(Message: errorList);
        }

        //var product = new Domain.Entities.LeadCategory
        //{
        //    CategoryName = request.LeadCategory.CategoryName
        //};

        // mapper.Map<output.DomainEntiy>(input.DTO);
        var leadCategoryEntity = mapper.Map<LeadCategory>(request.LeadCategory);

        try
        {
            _leadCategoryRepository.Add(leadCategoryEntity);
            await _unitOfWork.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            return new ServerResponse(Message: "Error Occured: " + ex.Message.ToString());
        }

        return new ServerResponse(IsSuccess: true, Message: "Lead Category Created Succcessfully", Data: leadCategoryEntity);
    }
}


