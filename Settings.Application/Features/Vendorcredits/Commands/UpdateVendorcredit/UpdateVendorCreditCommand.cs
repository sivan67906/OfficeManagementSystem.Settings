﻿using MediatR;

namespace Settings.Application.Features.Vendorcredits.Commands.UpdateVendorcredit;
public class UpdateVendorCreditCommand : IRequest<Guid>
{
    public Guid Id { get; set; }
    public string? VendorCreditPrefix { get; set; }
    public string? VendorCreditNumberSeperater { get; set; }
    public string? VendorCreditNumberDigits { get; set; }
    public string? VendorCreditNumberExample { get; set; }
}
