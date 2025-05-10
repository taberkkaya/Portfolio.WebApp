using AK.BlogWebApp.Domain.Abstractions;

namespace AK.BlogWebApp.Domain.Entities;

public sealed class HomePage : Entity
{
    public string HeaderTitle { get; set; } = string.Empty;
    public string HeaderContent { get; set; } = string.Empty;
    public string MainTitle { get; set; } = string.Empty;
    public string MainContent { get; set; } = string.Empty;
    public List<Blog>? FeaturedBlogs { get; set; }
    public List<Document>? FeaturedDocuments { get; set; }
}
