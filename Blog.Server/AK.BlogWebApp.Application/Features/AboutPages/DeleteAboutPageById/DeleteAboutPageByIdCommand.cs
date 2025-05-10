using MediatR;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.AboutPages.DeleteAboutPageById
{
    public sealed record DeleteAboutPageByIdCommand(Guid Id) : IRequest<Result<string>>;

}
