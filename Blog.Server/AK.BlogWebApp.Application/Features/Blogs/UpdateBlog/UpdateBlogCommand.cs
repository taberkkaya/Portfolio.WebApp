using MediatR;
using Microsoft.AspNetCore.Http;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.Blogs.UpdateBlog;

public sealed class UpdateBlogCommand : IRequest<Result<string>>
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public string? ImgUrl { get; set; } = string.Empty;
    public IFormFile? NewImg { get; set; } 
    public Guid BlogCategoryId { get; set; }
    public bool IsFeatured { get; set; }
}
