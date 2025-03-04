using Healthcare.Application.Models.Identity;

namespace Healthcare.Application.Contracts.Identity;

public interface IAuthService
{
    Task<AuthResponse> Login(AuthRequest request);
    Task<RegistrationResponse> Register(RegistrationRequest request);
}
