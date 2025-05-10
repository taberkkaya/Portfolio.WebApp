using AK.BlogWebApp.Domain.Entities;
using MediatR;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.Blogs.GetAllBlogs;

public sealed record GetAllBlogsQuery() : IRequest<Result<List<Blog>>>;
