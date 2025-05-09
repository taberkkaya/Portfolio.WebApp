using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using TS.Result;

namespace CG.Personal.Application.Features.Auth.ResetPassword;

public sealed record ResetPasswordCommand(
    string Email,
    string NewPassword
    ) : IRequest<Result<string>>;
