﻿using MediatR;

namespace Settings.Application.Features.Vendorcredits.Commands.CreateVendorcredit;
public class CreateVendorCreditCommand : IRequest<int>
{
    public int Id { get; set; }
    public string? VendorCreditPrefix { get; set; }
    public string? VendorCreditNumberSeperater { get; set; }
    public string? VendorCreditNumberDigits { get; set; }
    public string? VendorCreditNumberExample { get; set; }
}
