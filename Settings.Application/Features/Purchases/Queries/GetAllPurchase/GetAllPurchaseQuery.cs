using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.Purchases.Queries.GetAllPurchase;
public class GetAllPurchaseQuery :  IRequest<IEnumerable<PurchaseDTO>>
{
}
