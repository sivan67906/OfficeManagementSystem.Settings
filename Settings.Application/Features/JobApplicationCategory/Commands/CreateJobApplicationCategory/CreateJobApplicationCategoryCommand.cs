using MediatR;

namespace Settings.Application.Features.JobApplicationCategories.Commands.CreateJobApplicationCategory;

public class CreateJobApplicationCategoryCommand : IRequest
{
    public string? JACategoryCode { get; set; }
    public string? JACategoryName { get; set; }
}
























