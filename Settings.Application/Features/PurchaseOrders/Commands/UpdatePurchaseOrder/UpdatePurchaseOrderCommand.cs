﻿using MediatR;

namespace Settings.Application.Features.PurchaseOrders.Commands.UpdatePurchaseOrder;
public class UpdatePurchaseOrderCommand : IRequest<Guid>
{
    public Guid Id { get; set; }
    public string? PurchaseOrderPrefix { get; set; }
    public string? PurchaseOrderNumberSeperater { get; set; }
    public string? PurchaseOrderNumberDigits { get; set; }
    public string? PurchaseOrderNumberExample { get; set; }
}
