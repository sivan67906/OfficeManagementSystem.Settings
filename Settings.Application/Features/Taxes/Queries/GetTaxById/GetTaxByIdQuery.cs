﻿using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.Taxes.Queries.GetTaxById;
public class GetTaxByIdQuery : IRequest<TaxDTO>
{
    public Guid Id { get; set; }
}
