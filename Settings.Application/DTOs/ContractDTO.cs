namespace Settings.Application.DTOs;
public class ContractDTO
{
    public int Id { get; set; }
    public string? ContractPrefix { get; set; }
    public string? ContractNumberSeprator { get; set; }
    public int ContractNumberDigits { get; set; }
    public string? ContractNumberExample { get; set; }
}
