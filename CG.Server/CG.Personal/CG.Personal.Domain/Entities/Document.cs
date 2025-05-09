using CG.Personal.Domain.Abstractions;

namespace CG.Personal.Domain.Entities;

public sealed class Document : Entity
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Guid DocumentCategoryId { get; set; }
    public DocumentCategory? DocumentCategory { get; set; }
    public string CoverImgUrl { get; set; } = string.Empty;
    public string DocumentUrl { get; set; } = string.Empty;
    public bool IsFeatured { get; set; }
}
