using CG.Personal.Domain.Entities;
using MediatR;
using TS.Result;

namespace CG.Personal.Application.Features.Blogs.GetBlogById;

public sealed record GetBlogByIdCommand(Guid Id): IRequest<Result<Blog>>;

