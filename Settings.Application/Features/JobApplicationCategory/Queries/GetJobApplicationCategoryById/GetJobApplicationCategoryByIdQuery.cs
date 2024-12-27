//using Settings.Application.DTOs;
using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.JobApplicationCategories.Queries.GetJobApplicationCategoryById
{
    public class GetJobApplicationCategoryByIdQuery : IRequest<JobApplicationCategoryDTO>
    {
        public int Id { get; set; }
    }
}
























