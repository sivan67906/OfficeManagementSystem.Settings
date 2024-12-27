using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Configuration.Application.Features.Countries.Commands.DeleteCountry;

internal class DeleteCountryCommandHandler : IRequestHandler<DeleteCountryCommand>
{
    private readonly IGenericRepository<Country> _countryRepository;

    public DeleteCountryCommandHandler(
        IGenericRepository<Country> countryRepository) =>
        _countryRepository = countryRepository;
    public async System.Threading.Tasks.Task Handle(DeleteCountryCommand request, CancellationToken cancellationToken)
    {
        await _countryRepository.DeleteAsync(request.Id);
    }
}












