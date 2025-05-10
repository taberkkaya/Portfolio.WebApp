using MediatR;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.Blogs.DeleteBlogById;

public sealed record DeleteBlogByIdCommand(Guid Id) : IRequest<Result<string>>;
