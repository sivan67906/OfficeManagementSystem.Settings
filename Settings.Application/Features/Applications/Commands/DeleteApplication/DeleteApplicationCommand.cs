using MediatR;

namespace Settings.Application.Features.Applications.Commands.DeleteApplication;
public class DeleteApplicationCommand : IRequest
{
    public int Id { get; set; }
}
