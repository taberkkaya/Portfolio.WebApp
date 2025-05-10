using MediatR;
using Microsoft.AspNetCore.Http;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.Blogs.CreateBlog;

public sealed class CreateBlogCommand : IRequest<Result<string>>
{
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public IFormFile? CoverImgUrl { get; set; }
    public Guid BlogCategoryId { get; set; }
    public bool IsFeatured { get; set; }
}



