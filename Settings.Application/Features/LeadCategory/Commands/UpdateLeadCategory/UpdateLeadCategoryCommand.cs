using MediatR;

namespace Settings.Application.Feauters.LeadCategory.Commands.UpdateLeadCategory
{
    public class UpdateLeadCategoryCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public string? CategoryName { get; set; }
    }
}


