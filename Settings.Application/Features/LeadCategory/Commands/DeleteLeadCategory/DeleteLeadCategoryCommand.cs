using MediatR;

namespace Settings.Application.Feauters.LeadCategory.Commands.DeleteLeadCategory
{
    public class DeleteLeadCategoryCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}


