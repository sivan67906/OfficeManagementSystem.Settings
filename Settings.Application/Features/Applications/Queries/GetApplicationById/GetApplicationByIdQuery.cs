﻿using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.Applications.Queries.GetApplicationById;
public class GetApplicationByIdQuery : IRequest<ApplicationDTO>
{
    public Guid Id { get; set; }
}
