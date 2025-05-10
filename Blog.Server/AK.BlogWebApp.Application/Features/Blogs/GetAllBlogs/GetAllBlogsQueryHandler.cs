using AK.BlogWebApp.Domain.Entities;
using AK.BlogWebApp.Domain.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.Blogs.GetAllBlogs;

public sealed class GetAllBlogsQueryHandler(
    IBlogRepository blogRepository) : IRequestHandler<GetAllBlogsQuery, Result<List<Blog>>>
{
    public async Task<Result<List<Blog>>> Handle(GetAllBlogsQuery request, CancellationToken cancellationToken)
    {
        List<Blog> blogs = await blogRepository
            .GetAll()
            .OrderByDescending(p => p.CreatedDate)
            .ToListAsync();
        if (blogs is null || blogs.Count == 0)
        {
            return Result<List<Blog>>.Failure("Henüz paylaşılan blog yok.!!");
        }
        return blogs;
    }
}
