using MediatR;

namespace Settings.Application.Features.BusinessTypes.Commands.DeleteBusinessType
{
    public class DeleteBusinessTypeCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}






