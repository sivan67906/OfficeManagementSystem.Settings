//using Settings.Application.DTOs;
using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.NotificationMains.Queries.GetNotificationMainById
{
    public class GetNotificationMainByIdQuery : IRequest<NotificationMainDTO>
    {
        public int Id { get; set; }
    }
}

































