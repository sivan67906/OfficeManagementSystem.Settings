using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Applications.Queries.GetAllApplications;
public class GetAllApplicationQuery : IRequest<IEnumerable<ApplicationDTO>>
{
    
}
