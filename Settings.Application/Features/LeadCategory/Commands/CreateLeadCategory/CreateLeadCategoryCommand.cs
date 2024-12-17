using MediatR;

namespace Settings.Application.Feauters.LeadCategory.Commands.CreateLeadCategory
{
    public class CreateLeadCategoryCommand : IRequest<int>
    {
        
        public string? CategoryName { get; set; }
    }
}


