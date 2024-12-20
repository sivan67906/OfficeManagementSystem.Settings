namespace Settings.Application.DTOs;
public class PaymentDTO
{
    public int Id { get; set; }
    public string? Method { get; set; }
    public string? Description { get; set; }
    public bool Status { get; set; } = true;
}
