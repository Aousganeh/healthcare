using Healthcare.Domain.Entities;

namespace Healthcare.Application.Contracts.Infrastructure;

public interface IOTPService
{
    Task<bool> UserExistsAsync(string email);

    OTP GenerateOTP(string email);

    Task SaveOTPAsync(string email, OTP otp);

    Task<OTP> GetOTPAsync(string email);

    bool ValidateOTP(string code, OTP otp);
}