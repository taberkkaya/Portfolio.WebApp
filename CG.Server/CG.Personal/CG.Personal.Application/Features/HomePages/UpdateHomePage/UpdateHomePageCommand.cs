using MediatR;
using TS.Result;

namespace CG.Personal.Application.Features.HomePages.UpdateHomePage;

public sealed record UpdateHomePageCommand(
    string HeaderTitle,
    string HeaderContent,
    string MainTitle,
    string MainContent
    ) : IRequest<Result<string>>;
