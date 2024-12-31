﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Settings.Domain.Entities;
public sealed class Employee
{
    public int Id { get; set; }
    public int EmployeeCode { get; set; }
    public string? EmployeeName { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Description { get; set; }

    [ForeignKey(nameof(DepartmentId))]
    public int DepartmentId { get; set; }
    public Department? Department { get; set; }

    [ForeignKey(nameof(CompanyId))]
    public int CompanyId { get; set; }
    public Company? Company { get; set; }

    [ForeignKey(nameof(AddressId))]
    public int AddressId { get; set; }
    public Address? Address { get; set; }

    [ForeignKey(nameof(CountryId))]
    public int CountryId { get; set; }
    public Country? Country { get; set; }

    [ForeignKey(nameof(StateId))]
    public int StateId { get; set; }
    public State? State { get; set; }

    [ForeignKey(nameof(CityId))]
    public int CityId { get; set; }
    public City? City { get; set; }
}