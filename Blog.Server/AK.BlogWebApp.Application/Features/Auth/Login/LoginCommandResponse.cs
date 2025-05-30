﻿namespace AK.BlogWebApp.Application.Features.Auth.Login
{
    public sealed record LoginCommandResponse(
        string Token,
        string RefreshToken,
        DateTime RefreshTokenExpires);
}
