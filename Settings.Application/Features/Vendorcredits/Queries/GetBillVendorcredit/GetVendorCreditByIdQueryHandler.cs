﻿using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Vendorcredits.Queries.GetBillVendorcredit;
public class GetVendorCreditByIdQueryHandler : IRequestHandler<GetVendorCreditByIdQuery, VendorCreditDTO>
{
    private readonly IGenericRepository<VendorCredit> _repository;
    public GetVendorCreditByIdQueryHandler(IGenericRepository<VendorCredit> repository)
    {
        _repository = repository;
    }

    public async Task<VendorCreditDTO> Handle(GetVendorCreditByIdQuery request, CancellationToken cancellationToken)
    {
        var vendor = await _repository.GetByIdAsync(request.Id);
        if (vendor == null) return null;
        return new VendorCreditDTO
        {
            Id = vendor.Id,
            VendorCreditPrefix = vendor.VendorCreditPrefix,
            VendorCreditNumberSeperater = vendor.VendorCreditNumberSeperater,
            VendorCreditNumberDigits = vendor.VendorCreditNumberDigits,
            VendorCreditNumberExample = vendor.VendorCreditNumberExample,
        };
    }
}
