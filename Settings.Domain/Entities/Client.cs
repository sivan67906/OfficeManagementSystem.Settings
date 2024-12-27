using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using System.ComponentModel.Design;

namespace Settings.Domain.Entities
{
    public sealed class Client
    {
        public int Id { get; set; }
        public string? ClientCode { get; set; }
        public string? ClientName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Description { get; set; }
        public int AddressId { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public int ZipCode { get; set; }

        [ForeignKey(nameof(AddressId))]
        public Address? Address { get; set; }
        [ForeignKey(nameof(CountryId))]
        public Country? Country { get; set; }
        [ForeignKey(nameof(StateId))]
        public State? State { get; set; }
        [ForeignKey(nameof(CityId))]
        public City? City { get; set; }

    }
}
