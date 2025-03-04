namespace Healthcare.Application.Contracts.Infrastructure;

public interface IEmailService
{
    Task SendOtpEmailAsync(string toEmail, string otpCode);

}