using MediatR;
using TS.Result;

namespace CG.Personal.Application.Features.AboutPages.DeleteAboutPageById
{
    public sealed record DeleteAboutPageByIdCommand(Guid Id) : IRequest<Result<string>>;

}
