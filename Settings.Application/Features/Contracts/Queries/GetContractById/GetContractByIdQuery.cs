﻿using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.Contracts.Queries.GetContractById;
public class GetContractByIdQuery : IRequest<ContractDTO>
{
    public int Id { get; set; }
}
