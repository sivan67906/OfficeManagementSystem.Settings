using MediatR;

namespace Settings.Application.Features.JobApplicationCategories.Commands.UpdateJobApplicationCategory;

public class UpdateJobApplicationCategoryCommand : IRequest
{
    public Guid Id { get; set; }
    public string? JACategoryCode { get; set; }
    public string? JACategoryName { get; set; }
}
























