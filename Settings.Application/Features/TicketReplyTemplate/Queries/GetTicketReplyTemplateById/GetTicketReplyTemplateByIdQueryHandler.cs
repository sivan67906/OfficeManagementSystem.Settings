using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TicketReplyTemplates.Queries.GetTicketReplyTemplateById;

internal class GetTicketReplyTemplateByIdQueryHandler : IRequestHandler<GetTicketReplyTemplateByIdQuery, TicketReplyTemplateDTO>
{
    private readonly IGenericRepository<TicketReplyTemplate> _ticketReplyTemplateRepository;

    public GetTicketReplyTemplateByIdQueryHandler(
        IGenericRepository<TicketReplyTemplate> ticketReplyTemplateRepository) =>
        _ticketReplyTemplateRepository = ticketReplyTemplateRepository;

    public async Task<TicketReplyTemplateDTO> Handle(GetTicketReplyTemplateByIdQuery request, CancellationToken cancellationToken)
    {
        var ticketReplyTemplate = await _ticketReplyTemplateRepository.GetByIdAsync(request.Id);
        if (ticketReplyTemplate == null) return null;
        return new TicketReplyTemplateDTO
        {
            Id = ticketReplyTemplate.Id,
            TicketReplyTemplateCode = ticketReplyTemplate.TicketReplyTemplateCode,
            TicketReplyTemplateName = ticketReplyTemplate.TicketReplyTemplateName
        };
    }
}








































