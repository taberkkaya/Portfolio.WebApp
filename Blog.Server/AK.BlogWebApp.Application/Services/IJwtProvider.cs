using AK.BlogWebApp.Application.Features.Auth.Login;
using AK.BlogWebApp.Domain.Entities;

namespace AK.BlogWebApp.Application.Services
{
    public interface IJwtProvider
    {
        Task<LoginCommandResponse> CreateToken(AppUser user);
    }
}
