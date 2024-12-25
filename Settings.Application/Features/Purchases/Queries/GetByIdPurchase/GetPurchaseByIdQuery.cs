﻿using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.Purchases.Queries.GetByIdPurchase;
public class GetPurchaseByIdQuery : IRequest<PurchaseDTO>
{
    public int Id { get; set; }
}
