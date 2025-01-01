using AutoMapper;
using Settings.Application.DTOs.Lead;
using Settings.Application.DTOs.LeadCategory;
using Settings.Domain.Entities;

namespace Settings.Application.Common.AutoMapper;
public class MapperConfig : Profile
{
    public MapperConfig()
    {
        CreateMap<CreateLeadCategoryRequest, LeadCategory>();
        CreateMap<UpdateLeadCategoryRequest, LeadCategory>();
        CreateMap<LeadCategory, GetLeadCategory>();
    }
}

