using MediatR;

namespace Settings.Application.Feauters.LeadCategory.Commands.CreateLeadCategory
{
    public class CreateLeadCategoryCommand : IRequest<Guid>
    {
        
        public string? CategoryName { get; set; }
    }
}


