using AK.BlogWebApp.Domain.Entities;
using MediatR;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.Blogs.GetBlogById;

public sealed record GetBlogByIdCommand(Guid Id): IRequest<Result<Blog>>;

