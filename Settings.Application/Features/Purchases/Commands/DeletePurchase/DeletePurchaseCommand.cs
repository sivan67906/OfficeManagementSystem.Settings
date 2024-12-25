using MediatR;

namespace Settings.Application.Features.Purchases.Commands.DeletePurchase;
public class DeletePurchaseCommand : IRequest
{
    public int Id { get; set; }
}
