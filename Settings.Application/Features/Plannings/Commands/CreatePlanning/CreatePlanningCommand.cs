﻿using MediatR;

namespace Settings.Application.Features.Plannings.Commands.CreatePlanning;
public class CreatePlanningCommand : IRequest<Guid>
{
    public string? Name { get; set; }
    public float PlanPrice { get; set; }
    public int Validity { get; set; }
    public int Employee { get; set; }
    public int Designation { get; set; }
    public int Department { get; set; }
    public int Company { get; set; }
    public int Roles { get; set; }
    public int Permission { get; set; }
    public string? Description { get; set; }
}
