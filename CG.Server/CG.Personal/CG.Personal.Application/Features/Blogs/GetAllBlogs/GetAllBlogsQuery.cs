using CG.Personal.Domain.Entities;
using MediatR;
using TS.Result;

namespace CG.Personal.Application.Features.Blogs.GetAllBlogs;

public sealed record GetAllBlogsQuery() : IRequest<Result<List<Blog>>>;
