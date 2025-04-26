using Healthcare.Application.Contracts.Infrastructure;

namespace Healthcare.Application.Contracts.Identity;

public interface IUserService
{
    Task<bool> UserExistsByEmailAsync(string email);
    Task<bool> ResetPasswordAsync(string email, string newPassword, string otpCode, IOTPService otpService);

}