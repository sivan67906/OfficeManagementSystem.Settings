using Settings.Application.DTOs;
using MediatR;

namespace Settings.Application.Features.ProjectReminderPersons.Queries.GetProjectReminderPersonById
{
    public class GetProjectReminderPersonByIdQuery : IRequest<ProjectReminderPersonDTO>
    {
        public Guid Id { get; set; }
    }
}
























