using MediatR;

namespace Settings.Application.Feauters.LeadCategory.Commands.UpdateLeadCategory
{
    public class UpdateLeadCategoryCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }
    }
}


