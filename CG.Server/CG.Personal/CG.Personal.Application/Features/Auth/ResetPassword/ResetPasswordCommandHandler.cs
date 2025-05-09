using CG.Personal.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using TS.Result;

namespace CG.Personal.Application.Features.Auth.ResetPassword;

public sealed class ResetPasswordCommandHandler(
    UserManager<AppUser> userManager
    ) : IRequestHandler<ResetPasswordCommand, Result<string>>
{
    public async Task<Result<string>> Handle(ResetPasswordCommand request, CancellationToken cancellationToken)
    {
        var user = await userManager.FindByEmailAsync(request.Email);
        if (user is null)
        {
            return Result<string>.Failure("Kullanıcı bulunamadı!!");
        }

        var token = await userManager.GeneratePasswordResetTokenAsync(user);
        var result = await userManager.ResetPasswordAsync(user, token, request.NewPassword);
        return "Şifre başarıyla sıfırlandı!!";
    }
}
