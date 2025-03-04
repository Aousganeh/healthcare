namespace Healthcare.Domain.Entities;

public class OTP
{
    public string Email { get; set; }
    public string Code { get; set; }
    public DateTime ExpirationTime { get; set; } 
    public bool IsUsed { get; set; }
}