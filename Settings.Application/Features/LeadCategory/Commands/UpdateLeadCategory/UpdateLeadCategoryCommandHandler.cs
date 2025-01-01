using MediatR;
using Settings.Domain.Interfaces;
using Settings.Domain.Responses;

namespace Settings.Application.Feauters.LeadCategory.Commands.UpdateLeadCategory
{
    public class UpdateLeadCategoryCommandHandler : IRequestHandler<UpdateLeadCategoryCommand, ServerResponse>
    {
        private readonly IGenericRepository<Domain.Entities.LeadCategory> _repository;
        public UpdateLeadCategoryCommandHandler(IGenericRepository<Domain.Entities.LeadCategory> repository) => _repository = repository;

        public async Task<ServerResponse> Handle(UpdateLeadCategoryCommand request, CancellationToken cancellationToken)
        {
            return new ServerResponse(Message: "Not Implemented");
            //throw new NotImplementedException();
        }

        //public async Task<int> Handle(UpdateLeadCategoryCommand request, CancellationToken cancellationToken)
        //{
        //    var category = new Domain.Entities.LeadCategory
        //    {
        //        Id = request.Id,
        //        CategoryName = request.CategoryName

        //    };
        //    await _repository.UpdateAsync(category);
        //    return request.Id;
        //}
    }
}


