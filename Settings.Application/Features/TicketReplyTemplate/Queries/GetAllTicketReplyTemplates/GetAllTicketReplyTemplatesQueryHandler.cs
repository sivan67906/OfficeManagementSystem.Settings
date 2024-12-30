using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TicketReplyTemplates.Queries.GetAllTicketReplyTemplates;

internal class GetAllTicketReplyTemplatesQueryHandler : IRequestHandler<GetAllTicketReplyTemplatesQuery, IEnumerable<TicketReplyTemplateDTO>>
{
    private readonly IGenericRepository<TicketReplyTemplate> _ticketReplyTemplateRepository;

    public GetAllTicketReplyTemplatesQueryHandler(
        IGenericRepository<TicketReplyTemplate> ticketReplyTemplateRepository)
    {
        _ticketReplyTemplateRepository = ticketReplyTemplateRepository;
    }

    public async Task<IEnumerable<TicketReplyTemplateDTO>> Handle(GetAllTicketReplyTemplatesQuery request, CancellationToken cancellationToken)
    {
        var ticketReplyTemplates = await _ticketReplyTemplateRepository.GetAllAsync();
        var ticketReplyTemplateList = ticketReplyTemplates.Select(x => new TicketReplyTemplateDTO
        {
            Id = x.Id,
            TicketReplyTemplateCode = x.TicketReplyTemplateCode,
            TicketReplyTemplateName = x.TicketReplyTemplateName
        }).ToList();

        return ticketReplyTemplateList;
    }
}








































