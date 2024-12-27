using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Settings.Domain.Entities;

public sealed class BusinessLocation
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string? Code { get; set; }
    public string? Name { get; set; }
    public int CompanyId { get; set; }
    public int AddressId { get; set; }
    public int CountryId { get; set; }
    public int StateId { get; set; }
    public int CityId { get; set; }
    public string? TaxName { get; set; }
    public string? TaxNumber { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; } = true;

    [ForeignKey(nameof(CompanyId))]
    public Company? Company { get; set; }
    [ForeignKey(nameof(AddressId))]
    public Address? Address { get; set; }
    [ForeignKey(nameof(CountryId))]
    public Country? Country { get; set; }
    [ForeignKey(nameof(StateId))]
    public State? State { get; set; }
    [ForeignKey(nameof(CityId))]
    public City? City { get; set; }
}

