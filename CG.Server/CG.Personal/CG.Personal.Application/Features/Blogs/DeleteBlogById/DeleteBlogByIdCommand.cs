using MediatR;
using TS.Result;

namespace CG.Personal.Application.Features.Blogs.DeleteBlogById;

public sealed record DeleteBlogByIdCommand(Guid Id) : IRequest<Result<string>>;
