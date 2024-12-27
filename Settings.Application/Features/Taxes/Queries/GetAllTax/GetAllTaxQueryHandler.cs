﻿using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Taxes.Queries.GetAllTax;
public class GetAllTaxQueryHandler : IRequestHandler<GetAllTaxQuery, IEnumerable<TaxDTO>>
{
    private readonly IGenericRepository<Tax> _repository;
    public GetAllTaxQueryHandler(IGenericRepository<Tax> repository) => _repository = repository;
    

    public async Task<IEnumerable<TaxDTO>> Handle(GetAllTaxQuery request, CancellationToken cancellationToken)
    {
        var clients = await _repository.GetAllAsync();

        var clientlist = clients.Select(x => new TaxDTO
        {
            Id = x.Id,
            Name = x.Name,
            Rate = x.Rate
        }).ToList();

        return clientlist;
    }
}
