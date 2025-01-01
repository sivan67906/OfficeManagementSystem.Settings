using FluentValidation;
using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Interfaces;
using Settings.Domain.Responses;

namespace Settings.Application.Feauters.LeadCategory.Commands.UpdateLeadCategory
{
    public class UpdateLeadCategoryCommandHandler : IRequestHandler<UpdateLeadCategoryCommand, ServerResponse>
    {
        private readonly IGenericRepository<Domain.Entities.LeadCategory> _repository;
        private readonly IValidator<UpdateLeadCategoryRequest> _validator;

        public UpdateLeadCategoryCommandHandler(IValidator<UpdateLeadCategoryRequest> validator, IGenericRepository<Domain.Entities.LeadCategory> repository)
        {
            _validator = validator;
            _repository = repository;
        }

        public async Task<ServerResponse> Handle(UpdateLeadCategoryCommand request, CancellationToken cancellationToken)
        {
            var validate = await _validator.ValidateAsync(request.LeadCategory);
            if (!validate.IsValid)
            {
                var erroList = string.Join("; ", validate.Errors.Select(error => error.ErrorMessage));
                return new ServerResponse(Message: erroList);
            }
            var category = new Domain.Entities.LeadCategory
            {
                Id = request.LeadCategory.Id,
                CategoryName = request.LeadCategory.CategoryName

            };
            await _repository.UpdateAsync(category);
            return new ServerResponse(IsSuccess: true, Message: "Lead Category Updated Succcessfully", Data: category);
        }
    }
}