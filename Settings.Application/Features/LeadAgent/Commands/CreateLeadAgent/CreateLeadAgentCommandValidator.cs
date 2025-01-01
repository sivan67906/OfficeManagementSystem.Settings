﻿using FluentValidation;
using Settings.Application.DTOs;

namespace Settings.Application.Feauters.LeadAgent.Commands.CreateLeadAgent
{
    public class CreateLeadCategoryCommandValidator : AbstractValidator<CreateLeadAgentRequest>
    {
        public CreateLeadCategoryCommandValidator()
        {
            RuleFor(x => x.AgentName)
                .NotEmpty().WithMessage("Agent Name not empty")
                .MaximumLength(25).WithMessage("Agent Name must not exceed 25 Characters")
                .MinimumLength(3).WithMessage("Agent Name should not be less than 3 characters");

        }
    }
}


