using MediatR;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.HeaderAreas.UpdateHeaderArea;

public sealed record UpdateHeaderAreaCommand(
    Guid Id,
    string FirstName,
    string LastName,
    string Profession
    ) : IRequest<Result<string>>;
