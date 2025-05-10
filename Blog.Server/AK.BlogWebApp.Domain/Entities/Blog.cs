using AK.BlogWebApp.Domain.Abstractions;

namespace AK.BlogWebApp.Domain.Entities;

public sealed class Blog : Entity
{
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public string? CoverImgUrl { get; set; } = string.Empty;
    public Guid BlogCategoryId { get; set; }
    public BlogCategory? BlogCategory { get; set; }
    public bool IsFeatured { get; set; }
}
