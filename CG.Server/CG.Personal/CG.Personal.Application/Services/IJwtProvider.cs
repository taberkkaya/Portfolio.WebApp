using CG.Personal.Application.Features.Auth.Login;
using CG.Personal.Domain.Entities;

namespace CG.Personal.Application.Services
{
    public interface IJwtProvider
    {
        Task<LoginCommandResponse> CreateToken(AppUser user);
    }
}
